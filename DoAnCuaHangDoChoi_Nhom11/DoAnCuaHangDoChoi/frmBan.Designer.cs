namespace DoAnCuaHangDoChoi
{
    partial class frmBan
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
            this.btnCTHDB = new System.Windows.Forms.Button();
            this.btnHoaDonBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCTHDB
            // 
            this.btnCTHDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
            this.btnCTHDB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCTHDB.FlatAppearance.BorderSize = 0;
            this.btnCTHDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.btnCTHDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCTHDB.Font = new System.Drawing.Font("Segoe UI", 25.8F);
            this.btnCTHDB.ForeColor = System.Drawing.Color.White;
            this.btnCTHDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTHDB.Location = new System.Drawing.Point(0, 54);
            this.btnCTHDB.Name = "btnCTHDB";
            this.btnCTHDB.Size = new System.Drawing.Size(220, 59);
            this.btnCTHDB.TabIndex = 5;
            this.btnCTHDB.Text = "Chi tiết ";
            this.btnCTHDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCTHDB.UseVisualStyleBackColor = false;
            this.btnCTHDB.Click += new System.EventHandler(this.btnCTHDB_Click);
            // 
            // btnHoaDonBan
            // 
            this.btnHoaDonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(58)))), ((int)(((byte)(45)))));
            this.btnHoaDonBan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHoaDonBan.FlatAppearance.BorderSize = 0;
            this.btnHoaDonBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(183)))));
            this.btnHoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonBan.Font = new System.Drawing.Font("Segoe UI", 25.8F);
            this.btnHoaDonBan.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonBan.Location = new System.Drawing.Point(0, 0);
            this.btnHoaDonBan.Margin = new System.Windows.Forms.Padding(3, 7, 7, 3);
            this.btnHoaDonBan.Name = "btnHoaDonBan";
            this.btnHoaDonBan.Size = new System.Drawing.Size(220, 54);
            this.btnHoaDonBan.TabIndex = 4;
            this.btnHoaDonBan.Text = "Hoá đơn bán";
            this.btnHoaDonBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDonBan.UseVisualStyleBackColor = false;
            this.btnHoaDonBan.Click += new System.EventHandler(this.btnHoaDonBan_Click);
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 113);
            this.Controls.Add(this.btnCTHDB);
            this.Controls.Add(this.btnHoaDonBan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBan";
            this.Text = "frmBan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCTHDB;
        private System.Windows.Forms.Button btnHoaDonBan;
    }
}