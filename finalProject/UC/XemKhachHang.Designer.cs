namespace finalProject
{
    partial class UCKhachHang
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblTenKhachHang = new Guna.UI.WinForms.GunaLabel();
            this.lblSoLanMua = new Guna.UI.WinForms.GunaLabel();
            this.ptbAnhDaiDien = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.lblSoDienThoai = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(82, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(156, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Tên Khách Hàng:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(597, 17);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(111, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Số lần mua:";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(244, 17);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(85, 23);
            this.lblTenKhachHang.TabIndex = 3;
            this.lblTenKhachHang.Text = "username";
            // 
            // lblSoLanMua
            // 
            this.lblSoLanMua.AutoSize = true;
            this.lblSoLanMua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLanMua.Location = new System.Drawing.Point(714, 19);
            this.lblSoLanMua.Name = "lblSoLanMua";
            this.lblSoLanMua.Size = new System.Drawing.Size(19, 23);
            this.lblSoLanMua.TabIndex = 4;
            this.lblSoLanMua.Text = "0";
            // 
            // ptbAnhDaiDien
            // 
            this.ptbAnhDaiDien.BaseColor = System.Drawing.Color.White;
            this.ptbAnhDaiDien.Location = new System.Drawing.Point(16, 3);
            this.ptbAnhDaiDien.Name = "ptbAnhDaiDien";
            this.ptbAnhDaiDien.Size = new System.Drawing.Size(51, 48);
            this.ptbAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhDaiDien.TabIndex = 0;
            this.ptbAnhDaiDien.TabStop = false;
            this.ptbAnhDaiDien.UseTransfarantBackground = false;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(877, 17);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(129, 25);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Số điện thoại:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(1012, 19);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(100, 23);
            this.lblSoDienThoai.TabIndex = 6;
            this.lblSoDienThoai.Text = "0123456789";
            // 
            // UCKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.lblSoLanMua);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.ptbAnhDaiDien);
            this.Name = "UCKhachHang";
            this.Size = new System.Drawing.Size(1345, 54);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox ptbAnhDaiDien;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel lblTenKhachHang;
        private Guna.UI.WinForms.GunaLabel lblSoLanMua;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel lblSoDienThoai;
    }
}
