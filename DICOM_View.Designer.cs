using System;

namespace DICOM
{
    partial class DICOM_View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DICOM_View));
            this.pn2 = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.pn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // pn2
            // 
            this.pn2.AutoScroll = true;
            this.pn2.AutoSize = true;
            this.pn2.Controls.Add(this.pb);
            this.pn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn2.Location = new System.Drawing.Point(0, 170);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(1112, 687);
            this.pn2.TabIndex = 4;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_table);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 160);
            this.panel1.TabIndex = 5;
            // 
            // dgv_table
            // 
            this.dgv_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_table.Location = new System.Drawing.Point(0, 0);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_table.Size = new System.Drawing.Size(1112, 160);
            this.dgv_table.TabIndex = 0;
            this.dgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellContentClick);
            // 
            // DICOM_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1112, 857);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DICOM_View";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Text = "View_DICOM";
            this.TopMost = true;
            this.SizeChanged += new System.EventHandler(this.DICOM_View_MaximumSizeChanged);
            this.pn2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_table;
    }
}