using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DICOM
{
    public partial class DICOM_form : Form
    {
        DICOM_File dicom_file;
        public string SizeFile;
        public string ExpOrImpVR;
        public string EncodingN;
        public string ImageSize;
        public string ZoomNow;
        //public
        public float zoom = 1f;
        public float zoom_step = 0.1f;
        public DICOM_form()
        {
            InitializeComponent();
            string vrXmlFile = "dicom-vr.xml";
            string elementsXmlFile = "dicom-elements.xml";
            DICOM.Load(vrXmlFile, elementsXmlFile);
            
        }

        private void DICOM_form_Shown(object sender, EventArgs e)
        {
            if ((DICOM.vrCollection.Count > 0) && (DICOM.elementsCollection.Count > 0))
            {
                MessageBox.Show("VR list and DICOM tags list uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // отладка - все выводится в консоль
            //foreach (var item in DICOM.GetAllElements())
            //    Console.WriteLine($"{item.GroupID}, {item.ElementID}, {item.VR}, {item.Name}");
            //foreach (var item in DICOM.GetAllVRs())
            //    Console.WriteLine($"{item.Name}, {item.Description}, {item.PseudoType}");
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bS1_CurrentChanged(object sender, EventArgs e)
        {

        }
        public enum ZoomType
        {
            ZoomPlus,
            ZoomMin,
            ZoomFull,
            ZoomOrig,
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ts_menu_open_Click(object sender, EventArgs e)
        {
            ofd.Filter = "DCM Files(*.dcm)|*.dcm|DCM Files(*.DCM)|*.DCM|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                dicom_file = new DICOM_File(filePath);
                DataTable table = new DataTable();
                table.Columns.Add("group and element id", typeof(string));
                table.Columns.Add("VR", typeof(string));
                table.Columns.Add("description", typeof(string));
                table.Columns.Add("value", typeof(string));
                table.Columns.Add("length", typeof(int));

                foreach (DICOM_DataSet dataset in dicom_file)
                {
                    table.Rows.Add(dataset.DICOM_element.ToString(), dataset.DICOM_element.VR, dataset.DICOM_element.Name, dataset.ToString(), dataset.DLength);
                }

                dgv_table.DataSource = table;
                bS1.DataSource = dicom_file;

                int i = 1;
                foreach (DataGridViewRow row in dgv_table.Rows)
                {
                    row.HeaderCell.Value = i.ToString();
                    i++;
                }
                pb.Image = dicom_file.bmp;
                pb.Width = (int)dicom_file.bmp.Width;
                pb.Height = (int)dicom_file.bmp.Height;
                SizeFile = "Size of file: " + (dicom_file.file_info.Length / 1024.0).ToString("# 000.") + " Kb";
                ExpOrImpVR = dicom_file.ImplicitVR ? "Implicit VR" : "Explicit VR";
                EncodingN = "Encoding of file: " + dicom_file.encoding.EncodingName;
                ImageSize = "Size of image: " + dicom_file.BmpSize.Width.ToString() + " x " + dicom_file.BmpSize.Height.ToString() + " px";
                ZoomNow = "Zoom: " + (zoom * 100f).ToString("F0") + "%";
                sl_zoom.Text = ZoomNow;
                sl_imgsize.Text = ImageSize;
                sl_filesize.Text = SizeFile;
                sl_vrmean.Text = ExpOrImpVR;
                sl_enc.Text = EncodingN;
            }
        }

        private void ts_menu_pic_Click(object sender, EventArgs e)
        {
            saveImage.Filter = "Bmp(*.BMP;)|*.BMP|Image Files(*.JPG)|*.JPEG|Image Files(*.PNG)|*.PNG";
            if (saveImage.ShowDialog() != DialogResult.OK)
                return;
            switch (Path.GetExtension(saveImage.FileName))
            {
                case ".BMP":
                    pb.Image.Save(saveImage.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case ".JPG":
                case ".JPEG":
                    pb.Image.Save(saveImage.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".PNG":
                    pb.Image.Save(saveImage.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                default:
                    Console.WriteLine("SAVE IMAGE ERROR");
                    break;
            }
        }

        private void ts_menu_xml_Click(object sender, EventArgs e)
        {
            saveXML.Filter = "XML-File | *.xml";
            if (this.saveXML.ShowDialog() != DialogResult.OK)
                return;
            dicom_file.SaveFileToXML(saveXML.FileName);
        }
        
        public void ZoomImage(ZoomType zoomType)
        {
            if (dicom_file.bmp == null)
                return;
            Console.WriteLine(zoomType);
            switch (zoomType)
            {
                case ZoomType.ZoomPlus:
                    zoom += zoom_step;
                    Console.WriteLine(zoom);
                    break;
                case ZoomType.ZoomMin:
                    zoom -= zoom_step;
                    Console.WriteLine(zoom);
                    break;
                case ZoomType.ZoomOrig:
                    zoom = 1f;
                    Console.WriteLine(zoom);
                    break;
                case ZoomType.ZoomFull:
                    
                    zoom = (float)pn2.ClientSize.Width / (float)dicom_file.bmp.Width;
                    Console.WriteLine(pn2.ClientSize.Width);
                    Console.WriteLine(zoom);
                    break;
            }
            zoom = zoom > 5.0 ? 5f : zoom; //ограничения на зум
            zoom = zoom < 0.101 ? 0.1f : zoom;
            //Console.WriteLine(zoom);
            pb.Width = (int)(dicom_file.bmp.Width * zoom);
            pb.Height = (int)(dicom_file.bmp.Height * zoom);
            ZoomNow = "Zoom: " + (zoom * 100f).ToString("F0") + "%";
            //pb.Invalidate();
            sl_zoom.Text = ZoomNow;
        }
        private void zoomPlus_Click(object sender, EventArgs e)
        {
            ZoomImage(ZoomType.ZoomPlus);
        }

        private void zoomMin_Click(object sender, EventArgs e)
        {
            ZoomImage(ZoomType.ZoomMin);
        }

        private void fullScr_Click(object sender, EventArgs e)
        {
            ZoomImage(ZoomType.ZoomFull);
        }

        private void origSize_Click(object sender, EventArgs e)
        {
            ZoomImage(ZoomType.ZoomOrig);
        }
    }
}
