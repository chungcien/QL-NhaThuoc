namespace QL_NhaThuoc
{
    partial class frDanhMucThuoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnDSThuocSapHet = new System.Windows.Forms.Button();
            this.btnThemDuocPham = new System.Windows.Forms.Button();
            this.pnControls = new System.Windows.Forms.Panel();
            this.pnadd_sua = new System.Windows.Forms.Panel();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.btnThem_Sua = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtNhaSanXuat = new System.Windows.Forms.TextBox();
            this.txtTenDP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbAdd_Sua = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnControls.SuspendLayout();
            this.pnadd_sua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo tên thuốc";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(137, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(216, 20);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnDSThuocSapHet
            // 
            this.btnDSThuocSapHet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDSThuocSapHet.Location = new System.Drawing.Point(493, 6);
            this.btnDSThuocSapHet.Name = "btnDSThuocSapHet";
            this.btnDSThuocSapHet.Size = new System.Drawing.Size(201, 24);
            this.btnDSThuocSapHet.TabIndex = 3;
            this.btnDSThuocSapHet.Text = "Danh sách thuốc sắp hết trong kho";
            this.btnDSThuocSapHet.UseVisualStyleBackColor = true;
            this.btnDSThuocSapHet.Click += new System.EventHandler(this.btnThuocSapHet_Click);
            // 
            // btnThemDuocPham
            // 
            this.btnThemDuocPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDuocPham.Location = new System.Drawing.Point(714, 6);
            this.btnThemDuocPham.Name = "btnThemDuocPham";
            this.btnThemDuocPham.Size = new System.Drawing.Size(113, 24);
            this.btnThemDuocPham.TabIndex = 4;
            this.btnThemDuocPham.Text = "Thêm Dược Phẩm";
            this.btnThemDuocPham.UseVisualStyleBackColor = true;
            this.btnThemDuocPham.Click += new System.EventHandler(this.btnThemDuocPham_Click);
            // 
            // pnControls
            // 
            this.pnControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnControls.Controls.Add(this.pnadd_sua);
            this.pnControls.Controls.Add(this.dataGridView1);
            this.pnControls.Location = new System.Drawing.Point(12, 41);
            this.pnControls.Name = "pnControls";
            this.pnControls.Size = new System.Drawing.Size(817, 336);
            this.pnControls.TabIndex = 5;
            // 
            // pnadd_sua
            // 
            this.pnadd_sua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnadd_sua.BackColor = System.Drawing.Color.Silver;
            this.pnadd_sua.Controls.Add(this.cbDVT);
            this.pnadd_sua.Controls.Add(this.btnThem_Sua);
            this.pnadd_sua.Controls.Add(this.btnNhapLai);
            this.pnadd_sua.Controls.Add(this.txtGiaBan);
            this.pnadd_sua.Controls.Add(this.txtGiaNhap);
            this.pnadd_sua.Controls.Add(this.txtNhaSanXuat);
            this.pnadd_sua.Controls.Add(this.txtTenDP);
            this.pnadd_sua.Controls.Add(this.label3);
            this.pnadd_sua.Controls.Add(this.label4);
            this.pnadd_sua.Controls.Add(this.label10);
            this.pnadd_sua.Controls.Add(this.label11);
            this.pnadd_sua.Controls.Add(this.label12);
            this.pnadd_sua.Controls.Add(this.lbAdd_Sua);
            this.pnadd_sua.Location = new System.Drawing.Point(3, 231);
            this.pnadd_sua.Name = "pnadd_sua";
            this.pnadd_sua.Size = new System.Drawing.Size(812, 102);
            this.pnadd_sua.TabIndex = 6;
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
            this.cbDVT.Location = new System.Drawing.Point(621, 29);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(166, 21);
            this.cbDVT.TabIndex = 3;
            // 
            // btnThem_Sua
            // 
            this.btnThem_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem_Sua.Location = new System.Drawing.Point(706, 61);
            this.btnThem_Sua.Name = "btnThem_Sua";
            this.btnThem_Sua.Size = new System.Drawing.Size(81, 31);
            this.btnThem_Sua.TabIndex = 2;
            this.btnThem_Sua.Text = "Thêm";
            this.btnThem_Sua.UseVisualStyleBackColor = true;
            this.btnThem_Sua.Click += new System.EventHandler(this.btnThem_Sua_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNhapLai.Location = new System.Drawing.Point(619, 61);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(81, 31);
            this.btnNhapLai.TabIndex = 2;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaBan.Location = new System.Drawing.Point(367, 58);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(166, 20);
            this.txtGiaBan.TabIndex = 1;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaNhap.Location = new System.Drawing.Point(108, 54);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(166, 20);
            this.txtGiaNhap.TabIndex = 1;
            // 
            // txtNhaSanXuat
            // 
            this.txtNhaSanXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhaSanXuat.Location = new System.Drawing.Point(367, 30);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(166, 20);
            this.txtNhaSanXuat.TabIndex = 1;
            // 
            // txtTenDP
            // 
            this.txtTenDP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenDP.Location = new System.Drawing.Point(108, 29);
            this.txtTenDP.Name = "txtTenDP";
            this.txtTenDP.Size = new System.Drawing.Size(166, 20);
            this.txtTenDP.TabIndex = 1;
            this.txtTenDP.TextChanged += new System.EventHandler(this.txtTenDP_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá nhập";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Đơn vị tính";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nhà sản xuất";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên Dược Phẩm";
            // 
            // lbAdd_Sua
            // 
            this.lbAdd_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAdd_Sua.AutoSize = true;
            this.lbAdd_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdd_Sua.Location = new System.Drawing.Point(12, 7);
            this.lbAdd_Sua.Name = "lbAdd_Sua";
            this.lbAdd_Sua.Size = new System.Drawing.Size(189, 16);
            this.lbAdd_Sua.TabIndex = 0;
            this.lbAdd_Sua.Text = "Thêm thông tin dược phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDP,
            this.TenDP,
            this.NhaSanXuat,
            this.DVT,
            this.SoLuong,
            this.GiaNhap,
            this.GiaBan});
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(812, 224);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaDP
            // 
            this.MaDP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaDP.DataPropertyName = "MaDP";
            this.MaDP.HeaderText = "Mã DP";
            this.MaDP.Name = "MaDP";
            this.MaDP.ReadOnly = true;
            this.MaDP.Width = 65;
            // 
            // TenDP
            // 
            this.TenDP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDP.DataPropertyName = "TenDP";
            this.TenDP.HeaderText = "Tên Dược Phẩm";
            this.TenDP.Name = "TenDP";
            this.TenDP.ReadOnly = true;
            // 
            // NhaSanXuat
            // 
            this.NhaSanXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NhaSanXuat.DataPropertyName = "NhaSanXuat";
            this.NhaSanXuat.HeaderText = "Nhà Sản Xuất";
            this.NhaSanXuat.Name = "NhaSanXuat";
            this.NhaSanXuat.ReadOnly = true;
            this.NhaSanXuat.Width = 120;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn Vị Tính";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 90;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 80;
            // 
            // GiaNhap
            // 
            this.GiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // frDanhMucThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 389);
            this.ControlBox = false;
            this.Controls.Add(this.pnControls);
            this.Controls.Add(this.btnThemDuocPham);
            this.Controls.Add(this.btnDSThuocSapHet);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frDanhMucThuoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Danh Mục";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frDanhMucThuoc_Load);
            this.pnControls.ResumeLayout(false);
            this.pnadd_sua.ResumeLayout(false);
            this.pnadd_sua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnDSThuocSapHet;
        private System.Windows.Forms.Button btnThemDuocPham;
        private System.Windows.Forms.Panel pnControls;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnadd_sua;
        private System.Windows.Forms.Button btnThem_Sua;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtNhaSanXuat;
        private System.Windows.Forms.TextBox txtTenDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbAdd_Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.ComboBox cbDVT;

    }
}