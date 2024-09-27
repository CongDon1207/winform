namespace finalProject
{
    partial class CaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaNhan));
            this.ptbAnhDaiDien = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaiAnh = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new Guna.UI.WinForms.GunaTextBox();
            this.txtCMND = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDT = new Guna.UI.WinForms.GunaTextBox();
            this.dtpNgaySinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.lblDoiMatKhau = new Guna.UI.WinForms.GunaLinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLuuTT = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAnhDaiDien
            // 
            this.ptbAnhDaiDien.BaseColor = System.Drawing.Color.White;
            this.ptbAnhDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("ptbAnhDaiDien.Image")));
            this.ptbAnhDaiDien.Location = new System.Drawing.Point(29, 75);
            this.ptbAnhDaiDien.Name = "ptbAnhDaiDien";
            this.ptbAnhDaiDien.Size = new System.Drawing.Size(166, 155);
            this.ptbAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhDaiDien.TabIndex = 0;
            this.ptbAnhDaiDien.TabStop = false;
            this.ptbAnhDaiDien.UseTransfarantBackground = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ảnh đại diện";
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.AnimationHoverSpeed = 0.07F;
            this.btnTaiAnh.AnimationSpeed = 0.03F;
            this.btnTaiAnh.BaseColor = System.Drawing.Color.LightPink;
            this.btnTaiAnh.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnTaiAnh.BorderSize = 1;
            this.btnTaiAnh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTaiAnh.FocusedColor = System.Drawing.Color.Empty;
            this.btnTaiAnh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiAnh.ForeColor = System.Drawing.Color.White;
            this.btnTaiAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiAnh.Image")));
            this.btnTaiAnh.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTaiAnh.Location = new System.Drawing.Point(39, 247);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTaiAnh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTaiAnh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTaiAnh.OnHoverImage = null;
            this.btnTaiAnh.OnPressedColor = System.Drawing.Color.Black;
            this.btnTaiAnh.Size = new System.Drawing.Size(145, 42);
            this.btnTaiAnh.TabIndex = 3;
            this.btnTaiAnh.Text = "Tải ảnh";
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(531, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin cá nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(232, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và tên:";
            // 
            // txtTen
            // 
            this.txtTen.BaseColor = System.Drawing.Color.LightCyan;
            this.txtTen.BorderColor = System.Drawing.Color.Black;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.Black;
            this.txtTen.Location = new System.Drawing.Point(392, 77);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(216, 32);
            this.txtTen.TabIndex = 16;
            // 
            // txtCMND
            // 
            this.txtCMND.BaseColor = System.Drawing.Color.LightCyan;
            this.txtCMND.BorderColor = System.Drawing.Color.Black;
            this.txtCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCMND.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCMND.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCMND.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(392, 159);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.SelectedText = "";
            this.txtCMND.Size = new System.Drawing.Size(234, 32);
            this.txtCMND.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(232, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "CMND:";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BaseColor = System.Drawing.Color.LightCyan;
            this.txtTenTaiKhoan.BorderColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(863, 75);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(234, 32);
            this.txtTenTaiKhoan.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(692, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên tài khoản:";
            // 
            // txtSoDT
            // 
            this.txtSoDT.BaseColor = System.Drawing.Color.LightCyan;
            this.txtSoDT.BorderColor = System.Drawing.Color.Black;
            this.txtSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSoDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.Location = new System.Drawing.Point(863, 159);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.PasswordChar = '\0';
            this.txtSoDT.SelectedText = "";
            this.txtSoDT.Size = new System.Drawing.Size(234, 32);
            this.txtSoDT.TabIndex = 22;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BaseColor = System.Drawing.Color.LightCyan;
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.Black;
            this.dtpNgaySinh.CustomFormat = null;
            this.dtpNgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgaySinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.dtpNgaySinh.Location = new System.Drawing.Point(863, 247);
            this.dtpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpNgaySinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgaySinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpNgaySinh.OnPressedColor = System.Drawing.Color.Black;
            this.dtpNgaySinh.Size = new System.Drawing.Size(287, 32);
            this.dtpNgaySinh.TabIndex = 23;
            this.dtpNgaySinh.Text = "Tuesday, March 5, 2024";
            this.dtpNgaySinh.Value = new System.DateTime(2024, 3, 5, 9, 41, 30, 821);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(692, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(232, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "Giới tính:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BackColor = System.Drawing.Color.LightPink;
            this.txtGioiTinh.BaseColor = System.Drawing.Color.LightCyan;
            this.txtGioiTinh.BorderColor = System.Drawing.Color.Black;
            this.txtGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.txtGioiTinh.FormattingEnabled = true;
            this.txtGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioiTinh.Location = new System.Drawing.Point(392, 252);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtGioiTinh.Size = new System.Drawing.Size(234, 31);
            this.txtGioiTinh.TabIndex = 27;
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.AutoSize = true;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDoiMatKhau.Location = new System.Drawing.Point(754, 408);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(140, 28);
            this.lblDoiMatKhau.TabIndex = 28;
            this.lblDoiMatKhau.TabStop = true;
            this.lblDoiMatKhau.Text = "Đổi mật khẩu";
            this.lblDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDoiMatKhau_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(692, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "Số điện thoại:";
            // 
            // btnLuuTT
            // 
            this.btnLuuTT.AnimationHoverSpeed = 0.07F;
            this.btnLuuTT.AnimationSpeed = 0.03F;
            this.btnLuuTT.BackColor = System.Drawing.Color.Transparent;
            this.btnLuuTT.BaseColor = System.Drawing.Color.LightPink;
            this.btnLuuTT.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnLuuTT.BorderSize = 1;
            this.btnLuuTT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuuTT.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuuTT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTT.ForeColor = System.Drawing.Color.White;
            this.btnLuuTT.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuTT.Image")));
            this.btnLuuTT.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLuuTT.Location = new System.Drawing.Point(308, 408);
            this.btnLuuTT.Name = "btnLuuTT";
            this.btnLuuTT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuuTT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuuTT.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuuTT.OnHoverImage = null;
            this.btnLuuTT.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuuTT.Radius = 10;
            this.btnLuuTT.Size = new System.Drawing.Size(202, 49);
            this.btnLuuTT.TabIndex = 31;
            this.btnLuuTT.Text = "Lưu thông tin";
            this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BaseColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(170, 75);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(25, 24);
            this.btnXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXoa.TabIndex = 32;
            this.btnXoa.TabStop = false;
            this.btnXoa.UseTransfarantBackground = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // CaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1162, 673);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuuTT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDoiMatKhau);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaiAnh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbAnhDaiDien);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "CaNhan";
            this.Text = "CaNhan";
            this.Load += new System.EventHandler(this.CaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCirclePictureBox ptbAnhDaiDien;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnTaiAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtTen;
        private Guna.UI.WinForms.GunaTextBox txtCMND;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtSoDT;
        private Guna.UI.WinForms.GunaDateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaComboBox txtGioiTinh;
        private Guna.UI.WinForms.GunaLinkLabel lblDoiMatKhau;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton btnLuuTT;
        private Guna.UI.WinForms.GunaCirclePictureBox btnXoa;
    }
}