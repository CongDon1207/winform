namespace finalProject.RTO
{
    partial class LiDoHuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiDoHuy));
            this.txtNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuiDi = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
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
            this.txtNoiDung.Location = new System.Drawing.Point(57, 101);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PasswordChar = '\0';
            this.txtNoiDung.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNoiDung.PlaceholderText = "";
            this.txtNoiDung.SelectedText = "";
            this.txtNoiDung.Size = new System.Drawing.Size(700, 198);
            this.txtNoiDung.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lí do hủy đơn hàng ";
            // 
            // btnGuiDi
            // 
            this.btnGuiDi.AnimationHoverSpeed = 0.07F;
            this.btnGuiDi.AnimationSpeed = 0.03F;
            this.btnGuiDi.BackColor = System.Drawing.Color.Transparent;
            this.btnGuiDi.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btnGuiDi.BorderColor = System.Drawing.Color.Bisque;
            this.btnGuiDi.BorderSize = 2;
            this.btnGuiDi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuiDi.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuiDi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiDi.ForeColor = System.Drawing.Color.Black;
            this.btnGuiDi.Image = ((System.Drawing.Image)(resources.GetObject("btnGuiDi.Image")));
            this.btnGuiDi.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGuiDi.Location = new System.Drawing.Point(301, 326);
            this.btnGuiDi.Name = "btnGuiDi";
            this.btnGuiDi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGuiDi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuiDi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuiDi.OnHoverImage = null;
            this.btnGuiDi.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuiDi.Radius = 10;
            this.btnGuiDi.Size = new System.Drawing.Size(179, 51);
            this.btnGuiDi.TabIndex = 10;
            this.btnGuiDi.Text = "Gửi đi";
            this.btnGuiDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuiDi.Click += new System.EventHandler(this.btnGuiDi_Click);
            // 
            // LiDoHuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(805, 389);
            this.Controls.Add(this.btnGuiDi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoiDung);
            this.Name = "LiDoHuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiDoHuy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNoiDung;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnGuiDi;
    }
}