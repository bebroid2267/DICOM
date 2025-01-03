namespace DICOM
{
    partial class DICOM_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DICOM_form));
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.bt_open = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sl_zoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_imgsize = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_filesize = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_vrmean = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_enc = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ts_menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_menu_xml = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_menu_pic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomPlus = new System.Windows.Forms.ToolStripButton();
            this.zoomMin = new System.Windows.Forms.ToolStripButton();
            this.fullScr = new System.Windows.Forms.ToolStripButton();
            this.origSize = new System.Windows.Forms.ToolStripButton();
            this.saveImage = new System.Windows.Forms.SaveFileDialog();
            this.saveXML = new System.Windows.Forms.SaveFileDialog();
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.bS1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_table
            // 
            this.dgv_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_table.Location = new System.Drawing.Point(0, 0);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_table.Size = new System.Drawing.Size(817, 160);
            this.dgv_table.TabIndex = 0;
            this.dgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellContentClick);
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(657, -1);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(75, 23);
            this.bt_open.TabIndex = 1;
            this.bt_open.Text = "open";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_table);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 160);
            this.panel1.TabIndex = 2;
            // 
            // pn2
            // 
            this.pn2.AutoScroll = true;
            this.pn2.AutoSize = true;
            this.pn2.Controls.Add(this.pb);
            this.pn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn2.Location = new System.Drawing.Point(0, 189);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(817, 300);
            this.pn2.TabIndex = 3;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(0, 10);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(2000, 2000);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 23);
            this.panel3.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl_zoom,
            this.sl_imgsize,
            this.sl_filesize,
            this.sl_vrmean,
            this.sl_enc});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(817, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sl_zoom
            // 
            this.sl_zoom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sl_zoom.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.sl_zoom.Name = "sl_zoom";
            this.sl_zoom.Size = new System.Drawing.Size(0, 17);
            // 
            // sl_imgsize
            // 
            this.sl_imgsize.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sl_imgsize.Name = "sl_imgsize";
            this.sl_imgsize.Size = new System.Drawing.Size(0, 17);
            // 
            // sl_filesize
            // 
            this.sl_filesize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sl_filesize.Name = "sl_filesize";
            this.sl_filesize.Size = new System.Drawing.Size(0, 17);
            // 
            // sl_vrmean
            // 
            this.sl_vrmean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sl_vrmean.Name = "sl_vrmean";
            this.sl_vrmean.Size = new System.Drawing.Size(0, 17);
            // 
            // sl_enc
            // 
            this.sl_enc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sl_enc.Name = "sl_enc";
            this.sl_enc.Size = new System.Drawing.Size(0, 17);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Controls.Add(this.bt_open);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(817, 29);
            this.panel4.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.zoomPlus,
            this.zoomMin,
            this.fullScr,
            this.origSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menu_open,
            this.toolStripSeparator1,
            this.ts_menu_xml,
            this.ts_menu_pic});
            this.toolStripDropDownButton1.Image = global::DICOM.Properties.Resources.free_icon_menu_1828859;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // ts_menu_open
            // 
            this.ts_menu_open.Name = "ts_menu_open";
            this.ts_menu_open.Size = new System.Drawing.Size(148, 22);
            this.ts_menu_open.Text = "Open File";
            this.ts_menu_open.Click += new System.EventHandler(this.ts_menu_open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // ts_menu_xml
            // 
            this.ts_menu_xml.Name = "ts_menu_xml";
            this.ts_menu_xml.Size = new System.Drawing.Size(148, 22);
            this.ts_menu_xml.Text = "Save as XML";
            this.ts_menu_xml.Click += new System.EventHandler(this.ts_menu_xml_Click);
            // 
            // ts_menu_pic
            // 
            this.ts_menu_pic.Name = "ts_menu_pic";
            this.ts_menu_pic.Size = new System.Drawing.Size(148, 22);
            this.ts_menu_pic.Text = "Save to image";
            this.ts_menu_pic.Click += new System.EventHandler(this.ts_menu_pic_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // zoomPlus
            // 
            this.zoomPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomPlus.Image = global::DICOM.Properties.Resources.free_icon_magnifier_2350259;
            this.zoomPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomPlus.Name = "zoomPlus";
            this.zoomPlus.Size = new System.Drawing.Size(23, 22);
            this.zoomPlus.Text = "toolStripButton1";
            this.zoomPlus.ToolTipText = "Zoom in";
            this.zoomPlus.Click += new System.EventHandler(this.zoomPlus_Click);
            // 
            // zoomMin
            // 
            this.zoomMin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomMin.Image = global::DICOM.Properties.Resources.free_icon_magnifier_2350267;
            this.zoomMin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomMin.Name = "zoomMin";
            this.zoomMin.Size = new System.Drawing.Size(23, 22);
            this.zoomMin.Text = "toolStripButton2";
            this.zoomMin.ToolTipText = "Zoom out";
            this.zoomMin.Click += new System.EventHandler(this.zoomMin_Click);
            // 
            // fullScr
            // 
            this.fullScr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fullScr.Image = global::DICOM.Properties.Resources.free_icon_full_size_93640;
            this.fullScr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fullScr.Name = "fullScr";
            this.fullScr.Size = new System.Drawing.Size(23, 22);
            this.fullScr.Text = "toolStripButton3";
            this.fullScr.ToolTipText = "Full screen size";
            this.fullScr.Click += new System.EventHandler(this.fullScr_Click);
            // 
            // origSize
            // 
            this.origSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.origSize.Image = global::DICOM.Properties.Resources.free_icon_original_size_157944;
            this.origSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.origSize.Name = "origSize";
            this.origSize.Size = new System.Drawing.Size(23, 22);
            this.origSize.Text = "toolStripButton4";
            this.origSize.ToolTipText = "Original size";
            this.origSize.Click += new System.EventHandler(this.origSize_Click);
            // 
            // iconImageList
            // 
            this.iconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconImageList.ImageStream")));
            this.iconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconImageList.Images.SetKeyName(0, "origsize.png");
            this.iconImageList.Images.SetKeyName(1, "fullscreen.png");
            this.iconImageList.Images.SetKeyName(2, "zoomout.png");
            this.iconImageList.Images.SetKeyName(3, "zoomin.png");
            this.iconImageList.Images.SetKeyName(4, "menu.png");
            // 
            // DICOM_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 512);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DICOM_form";
            this.Text = "Best DICOM files viewer";
            this.TransparencyKey = System.Drawing.Color.Snow;
            this.Shown += new System.EventHandler(this.DICOM_form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.BindingSource bS1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagAndGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vRSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_xml;
        private System.Windows.Forms.ToolStripMenuItem ts_menu_pic;
        private System.Windows.Forms.SaveFileDialog saveImage;
        private System.Windows.Forms.SaveFileDialog saveXML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton zoomPlus;
        private System.Windows.Forms.ToolStripButton zoomMin;
        private System.Windows.Forms.ToolStripButton fullScr;
        private System.Windows.Forms.ToolStripButton origSize;
        public System.Windows.Forms.ImageList iconImageList;
        private System.Windows.Forms.ToolStripStatusLabel sl_zoom;
        private System.Windows.Forms.ToolStripStatusLabel sl_imgsize;
        private System.Windows.Forms.ToolStripStatusLabel sl_filesize;
        private System.Windows.Forms.ToolStripStatusLabel sl_vrmean;
        private System.Windows.Forms.ToolStripStatusLabel sl_enc;
    }
}

