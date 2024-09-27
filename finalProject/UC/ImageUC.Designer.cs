namespace finalProject
{
    partial class ImageUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageUC));
            this.imgPic = new Guna.UI.WinForms.GunaPictureBox();
            this.lblTen = new Guna.UI.WinForms.GunaLabel();
            this.lblGia = new Guna.UI.WinForms.GunaLabel();
            this.lblThoiGian = new Guna.UI.WinForms.GunaLabel();
            this.lblDiaChi = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPic
            // 
            this.imgPic.BaseColor = System.Drawing.Color.White;
            this.imgPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgPic.Image = ((System.Drawing.Image)(resources.GetObject("imgPic.Image")));
            this.imgPic.Location = new System.Drawing.Point(9, 3);
            this.imgPic.Name = "imgPic";
            this.imgPic.Size = new System.Drawing.Size(207, 157);
            this.imgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPic.TabIndex = 0;
            this.imgPic.TabStop = false;
            this.imgPic.Click += new System.EventHandler(this.imgPic_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoEllipsis = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(3, 163);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(223, 35);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tai nghe JBL";
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // lblGia
            // 
            this.lblGia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGia.AutoSize = true;
            this.lblGia.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Orange;
            this.lblGia.Location = new System.Drawing.Point(3, 194);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(128, 31);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "1000/2000";
            this.lblGia.Click += new System.EventHandler(this.lblGia_Click);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoEllipsis = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblThoiGian.Location = new System.Drawing.Point(21, 229);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(205, 24);
            this.lblThoiGian.TabIndex = 6;
            this.lblThoiGian.Text = "Thời gian";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoEllipsis = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDiaChi.Location = new System.Drawing.Point(23, 253);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(203, 46);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // ImageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.imgPic);
            this.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ImageUC";
            this.Size = new System.Drawing.Size(229, 299);
            this.Click += new System.EventHandler(this.ImageUC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox imgPic;
        private Guna.UI.WinForms.GunaLabel lblTen;
        public Guna.UI.WinForms.GunaLabel lblGia;
        private Guna.UI.WinForms.GunaLabel lblThoiGian;
        private Guna.UI.WinForms.GunaLabel lblDiaChi;
    }
}
