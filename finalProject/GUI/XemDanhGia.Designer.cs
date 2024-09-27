namespace finalProject
{
    partial class XemDanhGia
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDanhGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLuot = new Guna.UI.WinForms.GunaLabel();
            this.chartDanhGia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblTen = new Guna.UI.WinForms.GunaLabel();
            this.ptbAnh = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.fpnlBinhLuan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLuot);
            this.panel1.Controls.Add(this.chartDanhGia);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.lblTen);
            this.panel1.Controls.Add(this.ptbAnh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 556);
            this.panel1.TabIndex = 0;
            // 
            // lblLuot
            // 
            this.lblLuot.AutoSize = true;
            this.lblLuot.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuot.Location = new System.Drawing.Point(225, 183);
            this.lblLuot.Name = "lblLuot";
            this.lblLuot.Size = new System.Drawing.Size(30, 23);
            this.lblLuot.TabIndex = 5;
            this.lblLuot.Text = "10";
            // 
            // chartDanhGia
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDanhGia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDanhGia.Legends.Add(legend1);
            this.chartDanhGia.Location = new System.Drawing.Point(48, 227);
            this.chartDanhGia.Name = "chartDanhGia";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.Yellow;
            dataPoint2.Color = System.Drawing.Color.Yellow;
            dataPoint3.Color = System.Drawing.Color.Yellow;
            dataPoint4.Color = System.Drawing.Color.Yellow;
            dataPoint5.Color = System.Drawing.Color.Yellow;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            this.chartDanhGia.Series.Add(series1);
            this.chartDanhGia.Size = new System.Drawing.Size(441, 317);
            this.chartDanhGia.TabIndex = 4;
            this.chartDanhGia.Text = "chart1";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(44, 183);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(175, 23);
            this.gunaLabel2.TabIndex = 3;
            this.gunaLabel2.Text = "Tổng lượt đánh giá: ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(165, 123);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(125, 23);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên người bán";
            // 
            // ptbAnh
            // 
            this.ptbAnh.Image = ((System.Drawing.Image)(resources.GetObject("ptbAnh.Image")));
            this.ptbAnh.ImageRotate = 0F;
            this.ptbAnh.Location = new System.Drawing.Point(188, 12);
            this.ptbAnh.Name = "ptbAnh";
            this.ptbAnh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptbAnh.Size = new System.Drawing.Size(106, 98);
            this.ptbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnh.TabIndex = 1;
            this.ptbAnh.TabStop = false;
            // 
            // fpnlBinhLuan
            // 
            this.fpnlBinhLuan.AutoScroll = true;
            this.fpnlBinhLuan.BackColor = System.Drawing.Color.White;
            this.fpnlBinhLuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlBinhLuan.Location = new System.Drawing.Point(516, 0);
            this.fpnlBinhLuan.Name = "fpnlBinhLuan";
            this.fpnlBinhLuan.Size = new System.Drawing.Size(726, 556);
            this.fpnlBinhLuan.TabIndex = 1;
            // 
            // XemDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 556);
            this.Controls.Add(this.fpnlBinhLuan);
            this.Controls.Add(this.panel1);
            this.Name = "XemDanhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemDanhGia";
            this.Load += new System.EventHandler(this.XemDanhGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fpnlBinhLuan;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptbAnh;
        private Guna.UI.WinForms.GunaLabel lblTen;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDanhGia;
        private Guna.UI.WinForms.GunaLabel lblLuot;
    }
}