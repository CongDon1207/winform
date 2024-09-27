namespace finalProject
{
    partial class DanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhGia));
            this.label1 = new System.Windows.Forms.Label();
            this.ptbAnhDaiDien = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.lblTenNguoiBan = new System.Windows.Forms.Label();
            this.rtsSoSao = new Guna.UI2.WinForms.Guna2RatingStar();
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDanhGia = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đánh giá người bán";
            // 
            // ptbAnhDaiDien
            // 
            this.ptbAnhDaiDien.BaseColor = System.Drawing.Color.White;
            this.ptbAnhDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("ptbAnhDaiDien.Image")));
            this.ptbAnhDaiDien.Location = new System.Drawing.Point(311, 62);
            this.ptbAnhDaiDien.Name = "ptbAnhDaiDien";
            this.ptbAnhDaiDien.Size = new System.Drawing.Size(146, 127);
            this.ptbAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhDaiDien.TabIndex = 3;
            this.ptbAnhDaiDien.TabStop = false;
            this.ptbAnhDaiDien.UseTransfarantBackground = false;
            // 
            // lblTenNguoiBan
            // 
            this.lblTenNguoiBan.AutoSize = true;
            this.lblTenNguoiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiBan.Location = new System.Drawing.Point(307, 204);
            this.lblTenNguoiBan.Name = "lblTenNguoiBan";
            this.lblTenNguoiBan.Size = new System.Drawing.Size(127, 20);
            this.lblTenNguoiBan.TabIndex = 4;
            this.lblTenNguoiBan.Text = "Tên người bán";
            // 
            // rtsSoSao
            // 
            this.rtsSoSao.Location = new System.Drawing.Point(206, 227);
            this.rtsSoSao.Name = "rtsSoSao";
            this.rtsSoSao.RatingColor = System.Drawing.Color.Yellow;
            this.rtsSoSao.Size = new System.Drawing.Size(360, 59);
            this.rtsSoSao.TabIndex = 5;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.AutoScroll = true;
            this.txtNoiDung.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtNoiDung.BorderColor = System.Drawing.Color.Black;
            this.txtNoiDung.BorderThickness = 2;
            this.txtNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDung.DefaultText = "";
            this.txtNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDung.FillColor = System.Drawing.Color.Azure;
            this.txtNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.ForeColor = System.Drawing.Color.Black;
            this.txtNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDung.Location = new System.Drawing.Point(27, 302);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.Size = new System.Drawing.Size(737, 198);
            this.txtNoiDung.TabIndex = 7;
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.AnimationHoverSpeed = 0.07F;
            this.btnDanhGia.AnimationSpeed = 0.03F;
            this.btnDanhGia.BackColor = System.Drawing.Color.Transparent;
            this.btnDanhGia.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btnDanhGia.BorderColor = System.Drawing.Color.Bisque;
            this.btnDanhGia.BorderSize = 2;
            this.btnDanhGia.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDanhGia.FocusedColor = System.Drawing.Color.Empty;
            this.btnDanhGia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhGia.ForeColor = System.Drawing.Color.White;
            this.btnDanhGia.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhGia.Image")));
            this.btnDanhGia.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDanhGia.Location = new System.Drawing.Point(297, 518);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDanhGia.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDanhGia.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDanhGia.OnHoverImage = null;
            this.btnDanhGia.OnPressedColor = System.Drawing.Color.Black;
            this.btnDanhGia.Radius = 10;
            this.btnDanhGia.Size = new System.Drawing.Size(179, 51);
            this.btnDanhGia.TabIndex = 8;
            this.btnDanhGia.Text = "Đánh giá";
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(776, 581);
            this.Controls.Add(this.btnDanhGia);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.rtsSoSao);
            this.Controls.Add(this.lblTenNguoiBan);
            this.Controls.Add(this.ptbAnhDaiDien);
            this.Controls.Add(this.label1);
            this.Name = "DanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhGia";
            this.Load += new System.EventHandler(this.DanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCirclePictureBox ptbAnhDaiDien;
        private System.Windows.Forms.Label lblTenNguoiBan;
        private Guna.UI2.WinForms.Guna2RatingStar rtsSoSao;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
        private Guna.UI.WinForms.GunaButton btnDanhGia;
    }    
}