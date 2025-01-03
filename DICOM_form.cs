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
        public float zoom = 1f;
        public float zoom_step = 0.1f;
        public DICOM_form()
        {
            InitializeComponent();
            string vrXmlFile = "dicom-vr.xml";
            string elementsXmlFile = "dicom-elements.xml";
            DICOM.Load(vrXmlFile, elementsXmlFile);
            
        }

        /*private void DICOM_form_Shown(object sender, EventArgs e)
        {
                MessageBox.Show("Добро пожаловать в программу для чтения DICOM файлов!");
        }*/

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
                DICOM_View vd = new DICOM_View(ofd.FileName);
                vd.OpenFullWIndowHandler += () =>
                {
                    // Скрываем все окна, кроме текущего, и сразу сворачиваем их
                    foreach (var child in this.MdiChildren)
                    {
                        if (child != vd)
                        {
                            child.WindowState = FormWindowState.Minimized; // Сворачиваем
                        }
                    }

                    // Разворачиваем только текущее окно и применяем горизонтальный лейаут
                    vd.WindowState = FormWindowState.Maximized;
                    this.LayoutMdi(MdiLayout.TileHorizontal);

                    // Восстанавливаем видимость остальных окон только при необходимости
                    vd.FormClosed += (s, args) =>
                    {
                        foreach (var child in this.MdiChildren)
                        {
                            if (child.WindowState == FormWindowState.Minimized)
                            {
                                child.WindowState = FormWindowState.Normal; // Восстанавливаем окна
                            }
                        }
                    };
                };

                vd.MdiParent = this;
                vd.Show();
            }
        }
        private void ts_window_cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void ts_window_horizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }
        private void ts_window_vertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void ts_menu_pic_Click(object sender, EventArgs e)
        {
            saveImage.Filter = "Bmp(*.BMP;)|*.BMP|Image Files(*.JPG)|*.JPEG|Image Files(*.PNG)|*.PNG";
            if (saveImage.ShowDialog() != DialogResult.OK)
                return;
            (ActiveMdiChild as DICOM_View).saveToPicViewD(saveImage.FileName);
        }

        private void ts_menu_xml_Click(object sender, EventArgs e)
        {
            saveXML.Filter = "XML-File | *.xml";
            if (this.saveXML.ShowDialog() != DialogResult.OK)
                return;
            (ActiveMdiChild as DICOM_View).saveToXmlViewD(saveXML.FileName);
        }
        
        
        private void zoomPlus_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as DICOM_View).ZoomImage(ZoomType.ZoomPlus);
            sl_zoom.Text = (ActiveMdiChild as DICOM_View).return_child_zoom();
        }

        private void zoomMin_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as DICOM_View).ZoomImage(ZoomType.ZoomMin);
            sl_zoom.Text = (ActiveMdiChild as DICOM_View).return_child_zoom();
        }

        private void fullScr_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as DICOM_View).ZoomImage(ZoomType.ZoomFull);
            sl_zoom.Text = (ActiveMdiChild as DICOM_View).return_child_zoom();
        }

        private void origSize_Click(object sender, EventArgs e)
        {
            (ActiveMdiChild as DICOM_View).ZoomImage(ZoomType.ZoomOrig);
            sl_zoom.Text = (ActiveMdiChild as DICOM_View).return_child_zoom();
        }

        private void DICOM_form_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                var viewDICOM = ActiveMdiChild as DICOM_View;

                if (viewDICOM != null)
                {
                    sl_zoom.Text = viewDICOM.return_child_zoom();
                }
                else
                {
                    MessageBox.Show("Все окна ViewDICOM закрыты.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }

        }

        private void menu_ExitApp_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По всем вопросам обращаться в тех.поддежрку по номеру тел. 89237015172");
        }

        private void DICOM_form_Load(object sender, EventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
