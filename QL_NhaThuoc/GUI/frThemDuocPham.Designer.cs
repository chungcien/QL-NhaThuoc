namespace QL_NhaThuoc
{
    partial class frThemDuocPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtNhaSanXuat = new System.Windows.Forms.TextBox();
            this.txtTenDP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.cbDVT);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtGiaBan);
            this.panel2.Controls.Add(this.txtGiaNhap);
            this.panel2.Controls.Add(this.txtNhaSanXuat);
            this.panel2.Controls.Add(this.txtTenDP);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 245);
            this.panel2.TabIndex = 8;
            // 
            // cbDVT
            // 
            this.cbDVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Items.AddRange(new object[] {
            "Lọ",
            "Chai",
            "Viên",
            "Vỉ",
            "Hộp",
            "Ống",
            "Gói",
            "Tuýp"});
            this.cbDVT.Location = new System.Drawing.Point(138, 89);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(288, 21);
            this.cbDVT.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(243, 179);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 31);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm dược phẩm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaBan.Location = new System.Drawing.Point(138, 142);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(288, 20);
            this.txtGiaBan.TabIndex = 1;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaNhap.Location = new System.Drawing.Point(138, 116);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(288, 20);
            this.txtGiaNhap.TabIndex = 1;
            // 
            // txtNhaSanXuat
            // 
            this.txtNhaSanXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhaSanXuat.Location = new System.Drawing.Point(138, 64);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(288, 20);
            this.txtNhaSanXuat.TabIndex = 1;
            // 
            // txtTenDP
            // 
            this.txtTenDP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDP.Location = new System.Drawing.Point(138, 38);
            this.txtTenDP.Name = "txtTenDP";
            this.txtTenDP.Size = new System.Drawing.Size(288, 20);
            this.txtTenDP.TabIndex = 1;
            this.txtTenDP.TextChanged += new System.EventHandler(this.txtTenDP_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giá nhập";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn vị tính";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhà sản xuất";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Dược Phẩm";
            // 
            // frThemDuocPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(459, 256);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frThemDuocPham";
            this.Text = "frThemDuocPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frThemDuocPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtNhaSanXuat;
        private System.Windows.Forms.TextBox txtTenDP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDVT;
        private System.Windows.Forms.TextBox txtGiaNhap;

    }
}