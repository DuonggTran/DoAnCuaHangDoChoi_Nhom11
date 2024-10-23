namespace DoAnCuaHangDoChoi
{
    partial class frmNhap
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
            this.btnCTHDN = new System.Windows.Forms.Button();
            this.btnHoaDonNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCTHDN
            // 
            this.btnCTHDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
            this.btnCTHDN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCTHDN.FlatAppearance.BorderSize = 0;
            this.btnCTHDN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.btnCTHDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTHDN.Font = new System.Drawing.Font("Segoe UI", 25.8F);
            this.btnCTHDN.ForeColor = System.Drawing.Color.White;
            this.btnCTHDN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTHDN.Location = new System.Drawing.Point(0, 54);
            this.btnCTHDN.Name = "btnCTHDN";
            this.btnCTHDN.Size = new System.Drawing.Size(220, 59);
            this.btnCTHDN.TabIndex = 3;
            this.btnCTHDN.Text = "Chi tiết";
            this.btnCTHDN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCTHDN.UseVisualStyleBackColor = false;
            this.btnCTHDN.Click += new System.EventHandler(this.btnCTHDN_Click);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
            this.btnHoaDonNhap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHoaDonNhap.FlatAppearance.BorderSize = 0;
            this.btnHoaDonNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.btnHoaDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonNhap.Font = new System.Drawing.Font("Segoe UI", 25.8F);
            this.btnHoaDonNhap.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(0, 0);
            this.btnHoaDonNhap.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(220, 54);
            this.btnHoaDonNhap.TabIndex = 2;
            this.btnHoaDonNhap.Text = "Hoá đơn nhập";
            this.btnHoaDonNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDonNhap.UseVisualStyleBackColor = false;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // frmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 113);
            this.Controls.Add(this.btnCTHDN);
            this.Controls.Add(this.btnHoaDonNhap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhap";
            this.Text = "frmNhap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCTHDN;
        private System.Windows.Forms.Button btnHoaDonNhap;
    }
}