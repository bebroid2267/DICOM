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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.bt_open = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.sl_zoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_imgsize = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_filesize = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_vrmean = new System.Windows.Forms.ToolStripStatusLabel();
            this.sl_enc = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.zoomPlus = new System.Windows.Forms.ToolStripButton();
            this.zoomMin = new System.Windows.Forms.ToolStripButton();
            this.fullScr = new System.Windows.Forms.ToolStripButton();
            this.origSize = new System.Windows.Forms.ToolStripButton();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_saveXMLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_saveImageFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_ExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ViewZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ViewZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToFullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToOriginalSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImage = new System.Windows.Forms.SaveFileDialog();
            this.saveXML = new System.Windows.Forms.SaveFileDialog();
            this.iconImageList = new System.Windows.Forms.ImageList(this.components);
            this.bS = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS)).BeginInit();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 23);
            this.panel3.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sl_zoom,
            this.sl_imgsize,
            this.sl_filesize,
            this.sl_vrmean,
            this.sl_enc});
            this.statusStrip.Location = new System.Drawing.Point(0, 1);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(817, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
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
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.toolStrip);
            this.panel4.Controls.Add(this.menu);
            this.panel4.Controls.Add(this.bt_open);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(817, 51);
            this.panel4.TabIndex = 2;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomPlus,
            this.zoomMin,
            this.fullScr,
            this.origSize});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(817, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // zoomPlus
            // 
            this.zoomPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomPlus.Image = global::DICOM.Properties.Resources.free_icon_magnifier_2350259;
            this.zoomPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomPlus.Name = "zoomPlus";
            this.zoomPlus.Size = new System.Drawing.Size(24, 24);
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
            this.zoomMin.Size = new System.Drawing.Size(24, 24);
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
            this.fullScr.Size = new System.Drawing.Size(24, 24);
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
            this.origSize.Size = new System.Drawing.Size(24, 24);
            this.origSize.Text = "toolStripButton4";
            this.origSize.ToolTipText = "Original size";
            this.origSize.Click += new System.EventHandler(this.origSize_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(817, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_openFile,
            this.toolStripSeparator3,
            this.menu_saveXMLFile,
            this.menu_saveImageFile,
            this.toolStripSeparator4,
            this.menu_ExitApp});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menu_openFile
            // 
            this.menu_openFile.Name = "menu_openFile";
            this.menu_openFile.Size = new System.Drawing.Size(148, 22);
            this.menu_openFile.Text = "Open";
            this.menu_openFile.Click += new System.EventHandler(this.ts_menu_open_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // menu_saveXMLFile
            // 
            this.menu_saveXMLFile.Name = "menu_saveXMLFile";
            this.menu_saveXMLFile.Size = new System.Drawing.Size(148, 22);
            this.menu_saveXMLFile.Text = "Save as XML";
            this.menu_saveXMLFile.Click += new System.EventHandler(this.ts_menu_xml_Click);
            // 
            // menu_saveImageFile
            // 
            this.menu_saveImageFile.Name = "menu_saveImageFile";
            this.menu_saveImageFile.Size = new System.Drawing.Size(148, 22);
            this.menu_saveImageFile.Text = "Save as Image";
            this.menu_saveImageFile.Click += new System.EventHandler(this.ts_menu_pic_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(145, 6);
            // 
            // menu_ExitApp
            // 
            this.menu_ExitApp.Name = "menu_ExitApp";
            this.menu_ExitApp.Size = new System.Drawing.Size(148, 22);
            this.menu_ExitApp.Text = "Exit";
            this.menu_ExitApp.Click += new System.EventHandler(this.menu_ExitApp_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ViewZoomIn,
            this.menu_ViewZoomOut,
            this.zoomToFullscreenToolStripMenuItem,
            this.zoomToOriginalSizeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // menu_ViewZoomIn
            // 
            this.menu_ViewZoomIn.Name = "menu_ViewZoomIn";
            this.menu_ViewZoomIn.Size = new System.Drawing.Size(185, 22);
            this.menu_ViewZoomIn.Text = "Zoom in";
            this.menu_ViewZoomIn.Click += new System.EventHandler(this.zoomPlus_Click);
            // 
            // menu_ViewZoomOut
            // 
            this.menu_ViewZoomOut.Name = "menu_ViewZoomOut";
            this.menu_ViewZoomOut.Size = new System.Drawing.Size(185, 22);
            this.menu_ViewZoomOut.Text = "Zoom out";
            this.menu_ViewZoomOut.Click += new System.EventHandler(this.zoomMin_Click);
            // 
            // zoomToFullscreenToolStripMenuItem
            // 
            this.zoomToFullscreenToolStripMenuItem.Name = "zoomToFullscreenToolStripMenuItem";
            this.zoomToFullscreenToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.zoomToFullscreenToolStripMenuItem.Text = "Zoom to Fullscreen";
            this.zoomToFullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullScr_Click);
            // 
            // zoomToOriginalSizeToolStripMenuItem
            // 
            this.zoomToOriginalSizeToolStripMenuItem.Name = "zoomToOriginalSizeToolStripMenuItem";
            this.zoomToOriginalSizeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.zoomToOriginalSizeToolStripMenuItem.Text = "Zoom to original size";
            this.zoomToOriginalSizeToolStripMenuItem.Click += new System.EventHandler(this.origSize_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Cascade";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ts_window_cascade_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Horizontal";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ts_window_horizontal_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Vertical";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ts_window_vertical_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
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
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "DICOM_form";
            this.Text = "DICOM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DICOM_form_Load);
            this.MdiChildActivate += new System.EventHandler(this.DICOM_form_MdiChildActivate);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.BindingSource bS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.StatusStrip statusStrip;
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
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.SaveFileDialog saveImage;
        private System.Windows.Forms.SaveFileDialog saveXML;
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
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_openFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menu_saveXMLFile;
        private System.Windows.Forms.ToolStripMenuItem menu_saveImageFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menu_ExitApp;
        private System.Windows.Forms.ToolStripMenuItem menu_ViewZoomIn;
        private System.Windows.Forms.ToolStripMenuItem zoomToFullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToOriginalSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        protected internal System.Windows.Forms.ToolStripMenuItem menu_ViewZoomOut;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

