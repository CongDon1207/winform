using System.Drawing;

namespace finalProject
{
    partial class DangBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangBan));
            this.btnCapNhat = new Guna.UI.WinForms.GunaButton();
            this.txtLoaiSP = new Guna.UI.WinForms.GunaComboBox();
            this.btnTaiAnh = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLSP = new Guna.UI.WinForms.GunaButton();
            this.btnNext = new Guna.UI.WinForms.GunaImageButton();
            this.btnPrev = new Guna.UI.WinForms.GunaImageButton();
            this.txtThoiGian = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiaBan = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaLucMua = new Guna.UI.WinForms.GunaTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenSP = new Guna.UI.WinForms.GunaTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMTTinhTrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoTaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThongTinLH = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AnimationHoverSpeed = 0.07F;
            this.btnCapNhat.AnimationSpeed = 0.03F;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BaseColor = System.Drawing.Color.LightPink;
            this.btnCapNhat.BorderColor = System.Drawing.Color.LemonChiffon;
            this.btnCapNhat.BorderSize = 3;
            this.btnCapNhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCapNhat.Location = new System.Drawing.Point(367, 569);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapNhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhat.OnHoverImage = null;
            this.btnCapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhat.Radius = 5;
            this.btnCapNhat.Size = new System.Drawing.Size(184, 42);
            this.btnCapNhat.TabIndex = 31;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.BackColor = System.Drawing.Color.LightPink;
            this.txtLoaiSP.BaseColor = System.Drawing.Color.LightCyan;
            this.txtLoaiSP.BorderColor = System.Drawing.Color.Black;
            this.txtLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtLoaiSP.FocusedColor = System.Drawing.Color.Empty;
            this.txtLoaiSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSP.ForeColor = System.Drawing.Color.Black;
            this.txtLoaiSP.FormattingEnabled = true;
            this.txtLoaiSP.Items.AddRange(new object[] {
            "Quần áo",
            "Giày dép",
            "Công Nghệ",
            "Đồ Gia Dụng",
            "Khác"});
            this.txtLoaiSP.Location = new System.Drawing.Point(341, 162);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.OnHoverItemBaseColor = System.Drawing.Color.LightCyan;
            this.txtLoaiSP.OnHoverItemForeColor = System.Drawing.Color.Black;
            this.txtLoaiSP.Size = new System.Drawing.Size(298, 31);
            this.txtLoaiSP.TabIndex = 26;
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.AnimationHoverSpeed = 0.07F;
            this.btnTaiAnh.AnimationSpeed = 0.03F;
            this.btnTaiAnh.BackColor = System.Drawing.Color.Transparent;
            this.btnTaiAnh.BaseColor = System.Drawing.Color.LightPink;
            this.btnTaiAnh.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnTaiAnh.BorderSize = 1;
            this.btnTaiAnh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTaiAnh.FocusedColor = System.Drawing.Color.Empty;
            this.btnTaiAnh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiAnh.ForeColor = System.Drawing.Color.White;
            this.btnTaiAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiAnh.Image")));
            this.btnTaiAnh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTaiAnh.Location = new System.Drawing.Point(98, 317);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTaiAnh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTaiAnh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTaiAnh.OnHoverImage = null;
            this.btnTaiAnh.OnPressedColor = System.Drawing.Color.Black;
            this.btnTaiAnh.Radius = 10;
            this.btnTaiAnh.Size = new System.Drawing.Size(159, 43);
            this.btnTaiAnh.TabIndex = 22;
            this.btnTaiAnh.Text = "Tải ảnh";
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox1.Location = new System.Drawing.Point(64, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 222);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(407, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "Thông tin sản phẩm";
            // 
            // btnQLSP
            // 
            this.btnQLSP.AnimationHoverSpeed = 0.07F;
            this.btnQLSP.AnimationSpeed = 0.03F;
            this.btnQLSP.BackColor = System.Drawing.Color.Transparent;
            this.btnQLSP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(201)))), ((int)(((byte)(244)))));
            this.btnQLSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnQLSP.BorderSize = 2;
            this.btnQLSP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQLSP.FocusedColor = System.Drawing.Color.Empty;
            this.btnQLSP.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.btnQLSP.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSP.Image")));
            this.btnQLSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQLSP.Location = new System.Drawing.Point(886, 12);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(182)))), ((int)(((byte)(229)))));
            this.btnQLSP.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnQLSP.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.btnQLSP.OnHoverImage = null;
            this.btnQLSP.OnPressedColor = System.Drawing.Color.Black;
            this.btnQLSP.Radius = 10;
            this.btnQLSP.Size = new System.Drawing.Size(248, 37);
            this.btnQLSP.TabIndex = 43;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.Image = null;
            this.btnNext.ImageSize = new System.Drawing.Size(37, 32);
            this.btnNext.Location = new System.Drawing.Point(295, 178);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnNext.OnHoverImage")));
            this.btnNext.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.Size = new System.Drawing.Size(38, 40);
            this.btnNext.TabIndex = 48;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrev.Image = null;
            this.btnPrev.ImageSize = new System.Drawing.Size(37, 32);
            this.btnPrev.Location = new System.Drawing.Point(20, 178);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.OnHoverImage")));
            this.btnPrev.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnPrev.Size = new System.Drawing.Size(38, 40);
            this.btnPrev.TabIndex = 49;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtThoiGian.BaseColor = System.Drawing.Color.LightCyan;
            this.txtThoiGian.BorderColor = System.Drawing.Color.Black;
            this.txtThoiGian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiGian.FocusedBaseColor = System.Drawing.Color.LightCyan;
            this.txtThoiGian.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtThoiGian.FocusedForeColor = System.Drawing.Color.Black;
            this.txtThoiGian.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGian.ForeColor = System.Drawing.Color.Black;
            this.txtThoiGian.Location = new System.Drawing.Point(341, 478);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.PasswordChar = '\0';
            this.txtThoiGian.SelectedText = "";
            this.txtThoiGian.Size = new System.Drawing.Size(298, 30);
            this.txtThoiGian.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(337, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 24);
            this.label9.TabIndex = 79;
            this.label9.Text = "Thời gian mua:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTinhTrang.BaseColor = System.Drawing.Color.LightCyan;
            this.txtTinhTrang.BorderColor = System.Drawing.Color.Black;
            this.txtTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhTrang.FocusedBaseColor = System.Drawing.Color.LightCyan;
            this.txtTinhTrang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.FocusedForeColor = System.Drawing.Color.Black;
            this.txtTinhTrang.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.Black;
            this.txtTinhTrang.Location = new System.Drawing.Point(341, 398);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.PasswordChar = '\0';
            this.txtTinhTrang.SelectedText = "";
            this.txtTinhTrang.Size = new System.Drawing.Size(298, 30);
            this.txtTinhTrang.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(337, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 77;
            this.label10.Text = "Tình trạng: ";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGiaBan.BaseColor = System.Drawing.Color.LightCyan;
            this.txtGiaBan.BorderColor = System.Drawing.Color.Black;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.FocusedBaseColor = System.Drawing.Color.LightCyan;
            this.txtGiaBan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGiaBan.FocusedForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.Location = new System.Drawing.Point(341, 320);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(298, 30);
            this.txtGiaBan.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(337, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 24);
            this.label11.TabIndex = 75;
            this.label11.Text = "Giá bán: ";
            // 
            // txtGiaLucMua
            // 
            this.txtGiaLucMua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtGiaLucMua.BaseColor = System.Drawing.Color.LightCyan;
            this.txtGiaLucMua.BorderColor = System.Drawing.Color.Black;
            this.txtGiaLucMua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaLucMua.FocusedBaseColor = System.Drawing.Color.LightCyan;
            this.txtGiaLucMua.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGiaLucMua.FocusedForeColor = System.Drawing.Color.Black;
            this.txtGiaLucMua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaLucMua.ForeColor = System.Drawing.Color.Black;
            this.txtGiaLucMua.Location = new System.Drawing.Point(341, 245);
            this.txtGiaLucMua.Name = "txtGiaLucMua";
            this.txtGiaLucMua.PasswordChar = '\0';
            this.txtGiaLucMua.SelectedText = "";
            this.txtGiaLucMua.Size = new System.Drawing.Size(298, 30);
            this.txtGiaLucMua.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(337, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 24);
            this.label12.TabIndex = 73;
            this.label12.Text = "Giá lúc mua: ";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTenSP.BaseColor = System.Drawing.Color.LightCyan;
            this.txtTenSP.BorderColor = System.Drawing.Color.Black;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.FocusedBaseColor = System.Drawing.Color.LightCyan;
            this.txtTenSP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenSP.FocusedForeColor = System.Drawing.Color.Black;
            this.txtTenSP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.Location = new System.Drawing.Point(341, 94);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(298, 33);
            this.txtTenSP.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(337, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 22);
            this.label13.TabIndex = 71;
            this.label13.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(687, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Mô tả tình trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(687, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 85;
            this.label3.Text = "Địa chỉ sản phẩm:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(687, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 83;
            this.label8.Text = "Mô tả về sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(687, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Thông tin liên hệ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(337, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 89;
            this.label5.Text = "Loại sản phẩm";
            // 
            // txtMTTinhTrang
            // 
            this.txtMTTinhTrang.AutoScroll = true;
            this.txtMTTinhTrang.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtMTTinhTrang.BorderColor = System.Drawing.Color.Black;
            this.txtMTTinhTrang.BorderThickness = 2;
            this.txtMTTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMTTinhTrang.DefaultText = "";
            this.txtMTTinhTrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMTTinhTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMTTinhTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMTTinhTrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMTTinhTrang.FillColor = System.Drawing.Color.LightCyan;
            this.txtMTTinhTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMTTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtMTTinhTrang.ForeColor = System.Drawing.Color.Black;
            this.txtMTTinhTrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMTTinhTrang.Location = new System.Drawing.Point(692, 94);
            this.txtMTTinhTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMTTinhTrang.Multiline = true;
            this.txtMTTinhTrang.Name = "txtMTTinhTrang";
            this.txtMTTinhTrang.PasswordChar = '\0';
            this.txtMTTinhTrang.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMTTinhTrang.PlaceholderText = "";
            this.txtMTTinhTrang.SelectedText = "";
            this.txtMTTinhTrang.Size = new System.Drawing.Size(468, 89);
            this.txtMTTinhTrang.TabIndex = 90;
            // 
            // txtMoTaSP
            // 
            this.txtMoTaSP.AutoScroll = true;
            this.txtMoTaSP.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtMoTaSP.BorderColor = System.Drawing.Color.Black;
            this.txtMoTaSP.BorderThickness = 2;
            this.txtMoTaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTaSP.DefaultText = "";
            this.txtMoTaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaSP.FillColor = System.Drawing.Color.LightCyan;
            this.txtMoTaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtMoTaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMoTaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaSP.Location = new System.Drawing.Point(692, 216);
            this.txtMoTaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTaSP.Multiline = true;
            this.txtMoTaSP.Name = "txtMoTaSP";
            this.txtMoTaSP.PasswordChar = '\0';
            this.txtMoTaSP.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMoTaSP.PlaceholderText = "";
            this.txtMoTaSP.SelectedText = "";
            this.txtMoTaSP.Size = new System.Drawing.Size(468, 165);
            this.txtMoTaSP.TabIndex = 91;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoScroll = true;
            this.txtDiaChi.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtDiaChi.BorderColor = System.Drawing.Color.Black;
            this.txtDiaChi.BorderThickness = 2;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FillColor = System.Drawing.Color.LightCyan;
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(692, 414);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(468, 89);
            this.txtDiaChi.TabIndex = 92;
            // 
            // txtThongTinLH
            // 
            this.txtThongTinLH.AutoScroll = true;
            this.txtThongTinLH.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txtThongTinLH.BorderColor = System.Drawing.Color.Black;
            this.txtThongTinLH.BorderThickness = 2;
            this.txtThongTinLH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThongTinLH.DefaultText = "";
            this.txtThongTinLH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThongTinLH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThongTinLH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThongTinLH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThongTinLH.FillColor = System.Drawing.Color.LightCyan;
            this.txtThongTinLH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThongTinLH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtThongTinLH.ForeColor = System.Drawing.Color.Black;
            this.txtThongTinLH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThongTinLH.Location = new System.Drawing.Point(692, 531);
            this.txtThongTinLH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThongTinLH.Multiline = true;
            this.txtThongTinLH.Name = "txtThongTinLH";
            this.txtThongTinLH.PasswordChar = '\0';
            this.txtThongTinLH.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtThongTinLH.PlaceholderText = "";
            this.txtThongTinLH.SelectedText = "";
            this.txtThongTinLH.Size = new System.Drawing.Size(468, 89);
            this.txtThongTinLH.TabIndex = 93;
            // 
            // DangBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1162, 673);
            this.Controls.Add(this.txtThongTinLH);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMoTaSP);
            this.Controls.Add(this.txtMTTinhTrang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtGiaLucMua);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnQLSP);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.btnTaiAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "DangBan";
            this.Text = "DangBan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnCapNhat;
        private Guna.UI.WinForms.GunaComboBox txtLoaiSP;
        private Guna.UI.WinForms.GunaButton btnTaiAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnQLSP;
        private Guna.UI.WinForms.GunaImageButton btnNext;
        private Guna.UI.WinForms.GunaImageButton btnPrev;
        private Guna.UI.WinForms.GunaTextBox txtThoiGian;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaTextBox txtTinhTrang;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox txtGiaBan;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox txtGiaLucMua;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaTextBox txtTenSP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMTTinhTrang;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtThongTinLH;
    }
}