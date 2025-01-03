using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace DICOM
{
    public class DICOM_DataSet
    {
        public DICOM_Element DICOM_element;
        public byte[] Data;
        private readonly Encoding encoding;
        public string fileName;

        public string TagAndGroup { get { return this.DICOM_element.ToString(); } }
        public string VRS { get { return this.DICOM_element.VR; } }
        public string Description { get { return this.DICOM_element.Name; } }
        public string DataInFile { get { return this.ToString(); } }
        public int DLength { get { return Data == null ? 0 : Data.Length; } }


        public DICOM_DataSet(DICOM_Element dicom_element, Encoding enc)
        {
            encoding = enc != null ? enc : Encoding.ASCII;
            DICOM_element = dicom_element;
        } // было (DICOM_Element dicom_element, byte[] v)

        override public string ToString()
        {
            string str = string.Empty;
            // добавлены варианты текстового описания датасетов, содержимое которых не читаем
            if (DICOM_element.VR == "SQ")
            {
                DICOMParser parser = new DICOMParser(fileName);
                List<Dictionary<string, string>> sequences = parser.ParseFileForSQSequences(DICOM_element);

                if (sequences != null)
                {
                    foreach (var sequence in sequences)
                    {
                        Console.WriteLine("Новая последовательность:");
                        foreach (var kvp in sequence)
                        {
                            str += ($"  {kvp.Key}: {kvp.Value}");
                        }
                    }
                }
                else
                {
                    str = "empty";
                }
            }

            else if (DICOM_element.IsPixelData)
                str = "(Pixel Data)";
            else if (Data is null || Data.Length == 0)
                str = string.Empty;

            else
                switch (DICOM_element.VR)
                {
                    case "SS":
                        str = BitConverter.ToInt16(Data, 0).ToString(); break;
                    case "SL":
                        str = BitConverter.ToInt32(Data, 0).ToString(); break;
                    case "US":
                        str = BitConverter.ToUInt16(Data, 0).ToString(); break;
                    case "UL":
                        str = BitConverter.ToUInt32(Data, 0).ToString(); break;
                    case "FL":
                        str = BitConverter.ToSingle(Data, 0).ToString(); break;
                    case "FD":
                        str = BitConverter.ToDouble(Data, 0).ToString(); break;
                    default:
                        str = encoding.GetString(Data); break;
                }
            return str.Trim(new char[] { (char)0 });

        }
        public XmlNode GetXmlNode(XmlDocument xml)
        {
            XmlElement xmlel = xml.CreateElement("DataSet");

            XmlAttribute attr1 = xml.CreateAttribute("GroupID");
            attr1.Value = DICOM_element.GroupID;
            xmlel.Attributes.Append(attr1);

            XmlAttribute attr2 = xml.CreateAttribute("ElementID");
            attr2.Value = DICOM_element.ElementID;
            xmlel.Attributes.Append(attr2);

            XmlAttribute attr3 = xml.CreateAttribute("Description");
            attr3.Value = DICOM_element.Name;
            xmlel.Attributes.Append(attr3);

            XmlNode chel1 = (XmlNode)xml.CreateElement("VR");
            chel1.InnerText = DICOM_element.VR;
            xmlel.AppendChild(chel1);

            XmlNode chel2 = (XmlNode)xml.CreateElement("Length");
            chel2.InnerText = DLength.ToString();
            xmlel.AppendChild(chel2);

            XmlNode chel3 = (XmlNode)xml.CreateElement("Value");
            chel3.InnerText = this.DataInFile;
            xmlel.AppendChild(chel3);

            return (XmlNode)xmlel;
        }

    }
    public class DICOM_File : List<DICOM_DataSet>
    {
        public string filename;
        public readonly FileInfo file_info;
        private readonly BinaryReader reader;
        public readonly bool ImplicitVR;
        public Encoding encoding;

        public Size BmpSize;
        ushort BitsAllocated;
        double WW;
        double WL;
        IntPtr pointer;
        public Bitmap bmp;
        public DICOM_File(string file_name)
        {
            filename = file_name; // во второй группе vr всегда указан
            encoding = Encoding.ASCII;
            reader = new BinaryReader(File.Open(filename, FileMode.Open));
            if (Is_DICOM())
            {
                NumberFormatInfo nfi = new CultureInfo("ru-RU", false).NumberFormat;
                nfi.NumberDecimalSeparator = ".";
                this.file_info = new FileInfo(filename);
                encoding = Encoding.ASCII;
                ImplicitVR = false;

                DICOM_DataSet ds = ReadDataSet();
                ds.fileName = file_name;
                Add(ds);
                uint group_0002_length = BitConverter.ToUInt32(ds.Data, 0);
                long group_0002_end = reader.BaseStream.Position + (long)group_0002_length;

                while (reader.BaseStream.Position < group_0002_end)
                {
                    ds = ReadDataSet(is_group_0002: true);  // обратите внимание на то, что и так параметр можно задавать
                    ds.fileName = file_name;
                    Add(ds);
                    if (ds.DICOM_element.ElementID == "0010")
                        ImplicitVR = ds.ToString() == "1.2.840.10008.1.2";
                }
                do
                {
                    ds = ReadDataSet();
                    ds.fileName = file_name;
                    Add(ds);

                    // анализируем прочитанный датасет
                    if ((ds.DICOM_element.GroupID == "0008") && (ds.DICOM_element.ElementID == "0005"))
                    {
                        if (Encoding.ASCII.GetString(ds.Data) == "ISO_IR 144")
                            encoding = Encoding.GetEncoding(28595);
                        else if (Encoding.ASCII.GetString(ds.Data) == "ISO 2022 IR 6\\IS")
                            encoding = Encoding.GetEncoding(1251);
                        else if (Encoding.ASCII.GetString(ds.Data) == "ISO_IR 192")
                            encoding = Encoding.UTF8;
                    }
                    else if (ds.DICOM_element.GroupID == "0028" && ds.DICOM_element.ElementID == "0010")
                    {
                        BmpSize.Height = BitConverter.ToUInt16(ds.Data, 0);
                    }
                    else if (ds.DICOM_element.GroupID == "0028" && ds.DICOM_element.ElementID == "0011")
                    {
                        BmpSize.Width = BitConverter.ToUInt16(ds.Data, 0);
                    }
                    else if (ds.DICOM_element.GroupID == "0028" && ds.DICOM_element.ElementID == "0100")
                    {
                        BitsAllocated = BitConverter.ToUInt16(ds.Data, 0);
                    }
                    else if (ds.DICOM_element.GroupID == "0028" && ds.DICOM_element.ElementID == "1050")
                    {
                        WL = Convert.ToDouble(ds.ToString(), nfi);
                    }
                    else if (ds.DICOM_element.GroupID == "0028" && ds.DICOM_element.ElementID == "1051")
                    {
                        WW = Convert.ToDouble(ds.ToString(), nfi);
                    }


                }
                while (!ds.DICOM_element.IsPixelData);
                reader.Close();
            }
            else
            {
                reader.Close();
                throw new FormatException("Not DICOM file");
            }
        }

        private DICOM_DataSet ReadDataSet(bool is_group_0002 = false)
        {
            string group_id = reader.ReadInt16().ToString("X4");
            string element_id = reader.ReadInt16().ToString("X4");
            Console.WriteLine($"{group_id}, {element_id}");
            DICOM_Element tag = DICOM.FindElement(group_id, element_id);
            DICOM_DataSet ds = new DICOM_DataSet(tag, encoding);

            uint length;
            Console.WriteLine($"{tag}, {tag.VR}");

            if (is_group_0002 || !ImplicitVR)
            {
                ds.DICOM_element.VR = Encoding.ASCII.GetString(reader.ReadBytes(2));
                if (isLongValue(ds.DICOM_element.VR))
                {
                    reader.ReadBytes(2);
                    length = reader.ReadUInt32();
                }
                else
                    length = (uint)reader.ReadUInt16();
            }
            else
                length = reader.ReadUInt32();

            if (ds.DICOM_element.VR == "SQ")
            {
                ReadSequence(length);
            }
            else if (ds.DICOM_element.IsPixelData)
            {
                CreateBitmap();
            }
            else
                ds.Data = reader.ReadBytes((int)length);

            return ds;
        }

        private void ReadSequence(uint v_length)
        {
            if (v_length == 0xFFFFFFFF)
            {
                bool stop = false;
                do
                {
                    ushort tmp = reader.ReadUInt16();
                    if (tmp == 0xfffe)
                    {
                        tmp = reader.ReadUInt16();
                        stop = (tmp == 0xe0dd);
                    }

                }
                while (!stop);
                reader.ReadBytes(4);
            }
        }

        private void CreateBitmap()
        {
            int source_bpp = BitsAllocated / 8;
            int target_bpp = 24 / 8;
            byte[] source = reader.ReadBytes(BmpSize.Height * BmpSize.Width * source_bpp);
            byte[] target = new Byte[BmpSize.Width * BmpSize.Height * target_bpp];
            int j = 0;
            for (int i = 0; i < source.Length; i += source_bpp)
            {
                int gray = source[i] + (source[i + 1] << 8);
                int gray8bit = 0;
                if (gray <= (WL - 0.5 - (WW - 1) / 2))
                    gray8bit = 0;
                else if (gray > (WL - 0.5 + (WW - 1) / 2))
                    gray8bit = 255;
                else
                {
                    gray8bit = (int)(((gray - (WL - 0.5)) / (WW - 1) + 0.5) * 255);
                }
                target[j] = (byte)gray8bit;
                target[j + 1] = (byte)gray8bit;
                target[j + 2] = (byte)gray8bit;
                j += target_bpp;
            }

            int size = Marshal.SizeOf(target[0]) * target.Length;
            pointer = Marshal.AllocHGlobal(size);
            Marshal.Copy(target, 0, pointer, size);
            bmp = new Bitmap(BmpSize.Width, BmpSize.Height, BmpSize.Width * target_bpp,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb, pointer);
        }
        private bool Is_DICOM()
        {
            //reader.ReadBytes(128);
            //byte[] dicm = reader.ReadBytes(4);
            //return dicm.ToString() == "DICM";
            reader.ReadBytes(128);
            byte[] h = reader.ReadBytes(4);
            return Encoding.ASCII.GetString(h) == "DICM";
        }

        public void SaveToXML(string p_filename)
        {
            XmlDocument xml = new XmlDocument();
            XmlDeclaration xmlDeclaration = xml.CreateXmlDeclaration("1.0", "utf-8", (string)null);
            xml.AppendChild((XmlNode)xmlDeclaration);
            XmlNode element = (XmlNode)xml.CreateElement("DataSets");
            xml.AppendChild(element);
            foreach (DICOM_DataSet ds in (List<DICOM_DataSet>)this)
                element.AppendChild(ds.GetXmlNode(xml));
            xml.Save(p_filename);
        }

        private bool isLongValue(string vr)
        {
            var longVRs = new HashSet<string>
            {
                "OB", "OT", "OW", "UN", "UT", "SQ"
            };
            return longVRs.Contains(vr);
        }
    }

}
