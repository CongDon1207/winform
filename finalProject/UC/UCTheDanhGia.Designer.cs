namespace finalProject
{
    partial class UCTheDanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTheDanhGia));
            this.lblTen = new Guna.UI.WinForms.GunaLabel();
            this.rtsSao = new Guna.UI2.WinForms.Guna2RatingStar();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptbAnhDaiDien = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.DimGray;
            this.lblTen.Location = new System.Drawing.Point(62, 23);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(103, 23);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "gunaLabel1";
            // 
            // rtsSao
            // 
            this.rtsSao.Location = new System.Drawing.Point(18, 52);
            this.rtsSao.Name = "rtsSao";
            this.rtsSao.RatingColor = System.Drawing.Color.Gold;
            this.rtsSao.Size = new System.Drawing.Size(147, 28);
            this.rtsSao.TabIndex = 2;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BorderColor = System.Drawing.Color.White;
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.DefaultText = "";
            this.txtNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.FillColor = System.Drawing.Color.AliceBlue;
            this.txtNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.ForeColor = System.Drawing.Color.DimGray;
            this.txtNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Location = new System.Drawing.Point(20, 87);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.ReadOnly = true;
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.Size = new System.Drawing.Size(695, 147);
            this.txtNoiDung.TabIndex = 3;
            // 
            // ptbAnhDaiDien
            // 
            this.ptbAnhDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("ptbAnhDaiDien.Image")));
            this.ptbAnhDaiDien.ImageRotate = 0F;
            this.ptbAnhDaiDien.Location = new System.Drawing.Point(18, 13);
            this.ptbAnhDaiDien.Name = "ptbAnhDaiDien";
            this.ptbAnhDaiDien.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbAnhDaiDien.Size = new System.Drawing.Size(38, 33);
            this.ptbAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhDaiDien.TabIndex = 0;
            this.ptbAnhDaiDien.TabStop = false;
            // 
            // UCTheDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.rtsSao);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.ptbAnhDaiDien);
            this.Name = "UCTheDanhGia";
            this.Size = new System.Drawing.Size(731, 256);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbAnhDaiDien;
        private Guna.UI.WinForms.GunaLabel lblTen;
        private Guna.UI2.WinForms.Guna2RatingStar rtsSao;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
    }
}
