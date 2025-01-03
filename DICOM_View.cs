using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DICOM.DICOM_form;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DICOM
{
    public partial class DICOM_View : Form
    {
        public string filePath;
        DICOM_File dicom_file;
        public string SizeFile;
        public string ExpOrImpVR;
        public string EncodingN;
        public string ImageSize;
        public string ZoomNow;
        public float zoom = 1f;
        public float zoom_step = 0.1f;

        public Action OpenFullWIndowHandler;
        public DICOM_View(string filename_from)
        {
            filePath = filename_from;
            InitializeComponent();
            dicom_file = new DICOM_File(filePath);
            DataTable table = new DataTable();
            table.Columns.Add("group and element id", typeof(string));
            table.Columns.Add("VR", typeof(string));
            table.Columns.Add("description", typeof(string));
            table.Columns.Add("value", typeof(string));
            table.Columns.Add("length", typeof(int));

            string patientName = string.Empty;
            foreach (DICOM_DataSet dataset in dicom_file)
            {
                if (dataset.DICOM_element.VR == "PN" && dataset.DICOM_element.Name == "Patient's Name")
                    patientName = dataset.ToString();
                table.Rows.Add(dataset.DICOM_element.ToString(), dataset.DICOM_element.VR, dataset.DICOM_element.Name, dataset.ToString(), dataset.DLength);
            }
            this.Text = Path.GetFileName(dicom_file.filename) + ", Patient: " + patientName;

            dgv_table.DataSource = table;

            int i = 1;
            foreach (DataGridViewRow row in dgv_table.Rows)
            {
                row.HeaderCell.Value = i.ToString();
                i++;
            }
            if (dicom_file.bmp == null)
            {
                return;
            }
            pb.Image = dicom_file.bmp;
            pb.Width = (int)dicom_file.bmp.Width;
            pb.Height = (int)dicom_file.bmp.Height;
            SizeFile = "Size of file: " + ((double)this.dicom_file.file_info.Length / 1024.0).ToString("# 000.") + " Kb";
            ExpOrImpVR = this.dicom_file.ImplicitVR ? "Implicit VR" : "Explicit VR";
            EncodingN = "Encoding of file: " + this.dicom_file.encoding.EncodingName;
            ImageSize = "Size of image: " + this.dicom_file.BmpSize.Width.ToString() + " x " + this.dicom_file.BmpSize.Height.ToString() + " px";
            ZoomNow = "Zoom: " + (zoom * 100f).ToString("F0") + "%";

            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        public string return_child_size() { return SizeFile; }
        public string return_child_VR() { return ExpOrImpVR; }
        public string return_child_Encod() { return EncodingN; }
        public string return_child_ImageSize() { return ImageSize; }
        public string return_child_zoom() { return ZoomNow; }
        public void saveToXmlViewD(string filename_DICOM)
        {
            dicom_file.SaveToXML(filename_DICOM);
        }

        public void saveToPicViewD(string filename_DICOM)
        {
            switch (Path.GetExtension(filename_DICOM))
            {
                case ".BMP":
                    pb.Image.Save(filename_DICOM, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case ".JPG":
                case ".JPEG":
                    pb.Image.Save(filename_DICOM, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".PNG":
                    pb.Image.Save(filename_DICOM, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                default:
                    Console.WriteLine("SAVE IMAGE ERROR");
                    break;
            }
        }

        public void ZoomImage(ZoomType zoomType)
        {
            if (dicom_file.bmp == null)
                return;
            Console.WriteLine(zoomType);
            switch (zoomType)
            {
                case ZoomType.ZoomPlus:
                    zoom += 0.1f;
                    Console.WriteLine(zoom);
                    break;
                case ZoomType.ZoomMin:
                    zoom -= 0.1f;
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
            pb.Width = (int)(dicom_file.bmp.Width * zoom);
            pb.Height = (int)(dicom_file.bmp.Height * zoom);
            ZoomNow = "Zoom: " + (zoom * 100f).ToString("F0") + "%";
        }
        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DICOM_View_MaximumSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                OpenFullWIndowHandler?.Invoke();
            }
        }
    }
}
