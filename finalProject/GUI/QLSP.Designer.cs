namespace finalProject
{
    partial class QLSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.dtQLSP = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnDonHangBiHuy = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnDonHangBiHuy);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.dtQLSP);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 753);
            this.panel1.TabIndex = 1;
            // 
            // btnSua
            // 
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BaseColor = System.Drawing.Color.LightPink;
            this.btnSua.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnSua.BorderSize = 1;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSua.Location = new System.Drawing.Point(759, 703);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Radius = 10;
            this.btnSua.Size = new System.Drawing.Size(159, 38);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.LightPink;
            this.btnXoa.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnXoa.BorderSize = 1;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(25, 25);
            this.btnXoa.Location = new System.Drawing.Point(536, 703);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 10;
            this.btnXoa.Size = new System.Drawing.Size(159, 38);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtQLSP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtQLSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtQLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtQLSP.BackgroundColor = System.Drawing.Color.White;
            this.dtQLSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtQLSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtQLSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtQLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtQLSP.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtQLSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtQLSP.EnableHeadersVisualStyles = false;
            this.dtQLSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtQLSP.Location = new System.Drawing.Point(3, 72);
            this.dtQLSP.Name = "dtQLSP";
            this.dtQLSP.RowHeadersVisible = false;
            this.dtQLSP.RowHeadersWidth = 51;
            this.dtQLSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtQLSP.RowTemplate.Height = 24;
            this.dtQLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtQLSP.Size = new System.Drawing.Size(1476, 597);
            this.dtQLSP.TabIndex = 34;
            this.dtQLSP.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtQLSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtQLSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtQLSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtQLSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtQLSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtQLSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtQLSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtQLSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtQLSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtQLSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtQLSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtQLSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtQLSP.ThemeStyle.HeaderStyle.Height = 20;
            this.dtQLSP.ThemeStyle.ReadOnly = false;
            this.dtQLSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtQLSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtQLSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtQLSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtQLSP.ThemeStyle.RowsStyle.Height = 24;
            this.dtQLSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtQLSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial Black", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Blue;
            this.gunaLabel1.Location = new System.Drawing.Point(513, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(491, 40);
            this.gunaLabel1.TabIndex = 35;
            this.gunaLabel1.Text = "Quản lý sản phẩm đã đăng bán";
            // 
            // btnDonHangBiHuy
            // 
            this.btnDonHangBiHuy.AnimationHoverSpeed = 0.07F;
            this.btnDonHangBiHuy.AnimationSpeed = 0.03F;
            this.btnDonHangBiHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnDonHangBiHuy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(201)))), ((int)(((byte)(244)))));
            this.btnDonHangBiHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnDonHangBiHuy.BorderSize = 2;
            this.btnDonHangBiHuy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDonHangBiHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnDonHangBiHuy.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHangBiHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.btnDonHangBiHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnDonHangBiHuy.Image")));
            this.btnDonHangBiHuy.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDonHangBiHuy.Location = new System.Drawing.Point(1228, 12);
            this.btnDonHangBiHuy.Name = "btnDonHangBiHuy";
            this.btnDonHangBiHuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(182)))), ((int)(((byte)(229)))));
            this.btnDonHangBiHuy.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnDonHangBiHuy.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.btnDonHangBiHuy.OnHoverImage = null;
            this.btnDonHangBiHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnDonHangBiHuy.Radius = 10;
            this.btnDonHangBiHuy.Size = new System.Drawing.Size(217, 37);
            this.btnDonHangBiHuy.TabIndex = 81;
            this.btnDonHangBiHuy.Text = "Đơn hàng bị hủy";
            this.btnDonHangBiHuy.Click += new System.EventHandler(this.btnDonHangBiHuy_Click);
            // 
            // QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.panel1);
            this.Name = "QLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLSP";
            this.Load += new System.EventHandler(this.QLSP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtQLSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaDataGridView dtQLSP;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnDonHangBiHuy;
    }
}