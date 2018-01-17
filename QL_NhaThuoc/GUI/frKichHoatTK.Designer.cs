namespace QL_NhaThuoc
{
    partial class frKichHoatTK
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.checkQLUser = new System.Windows.Forms.CheckBox();
            this.checkXuatHang = new System.Windows.Forms.CheckBox();
            this.checkNhapHang = new System.Windows.Forms.CheckBox();
            this.checkSuaDP = new System.Windows.Forms.CheckBox();
            this.checkThemDP = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass_NL = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nhập lại MK";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(519, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 25);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa yêu cầu";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Location = new System.Drawing.Point(647, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 25);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Kích hoạt";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lưu";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(-2, 216);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 24);
            this.panel4.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thông tin tài khoản";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbUsers);
            this.panel3.Location = new System.Drawing.Point(-2, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 24);
            this.panel3.TabIndex = 25;
            // 
            // cbUsers
            // 
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(134, 2);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(178, 21);
            this.cbUsers.TabIndex = 9;
            this.cbUsers.DropDownClosed += new System.EventHandler(this.cbUsers_DropDownClosed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chỉnh sửa quyền";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-2, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 24);
            this.panel2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số ĐT";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(44, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSDT.Location = new System.Drawing.Point(576, 50);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(178, 20);
            this.txtSDT.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(44, 50);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 14;
            // 
            // checkQLUser
            // 
            this.checkQLUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkQLUser.AutoSize = true;
            this.checkQLUser.Location = new System.Drawing.Point(546, 19);
            this.checkQLUser.Name = "checkQLUser";
            this.checkQLUser.Size = new System.Drawing.Size(92, 17);
            this.checkQLUser.TabIndex = 3;
            this.checkQLUser.Text = "Quản lý Users";
            this.checkQLUser.UseVisualStyleBackColor = true;
            // 
            // checkXuatHang
            // 
            this.checkXuatHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkXuatHang.AutoSize = true;
            this.checkXuatHang.Location = new System.Drawing.Point(428, 19);
            this.checkXuatHang.Name = "checkXuatHang";
            this.checkXuatHang.Size = new System.Drawing.Size(75, 17);
            this.checkXuatHang.TabIndex = 4;
            this.checkXuatHang.Text = "Xuất hàng";
            this.checkXuatHang.UseVisualStyleBackColor = true;
            // 
            // checkNhapHang
            // 
            this.checkNhapHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkNhapHang.AutoSize = true;
            this.checkNhapHang.Location = new System.Drawing.Point(305, 19);
            this.checkNhapHang.Name = "checkNhapHang";
            this.checkNhapHang.Size = new System.Drawing.Size(79, 17);
            this.checkNhapHang.TabIndex = 5;
            this.checkNhapHang.Text = "Nhập hàng";
            this.checkNhapHang.UseVisualStyleBackColor = true;
            // 
            // checkSuaDP
            // 
            this.checkSuaDP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkSuaDP.AutoSize = true;
            this.checkSuaDP.Location = new System.Drawing.Point(156, 19);
            this.checkSuaDP.Name = "checkSuaDP";
            this.checkSuaDP.Size = new System.Drawing.Size(101, 17);
            this.checkSuaDP.TabIndex = 6;
            this.checkSuaDP.Text = "Sửa dược phẩm";
            this.checkSuaDP.UseVisualStyleBackColor = true;
            // 
            // checkThemDP
            // 
            this.checkThemDP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkThemDP.AutoSize = true;
            this.checkThemDP.Location = new System.Drawing.Point(11, 19);
            this.checkThemDP.Name = "checkThemDP";
            this.checkThemDP.Size = new System.Drawing.Size(109, 17);
            this.checkThemDP.TabIndex = 7;
            this.checkThemDP.Text = "Thêm dược phẩm";
            this.checkThemDP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ tên";
            // 
            // txtPass_NL
            // 
            this.txtPass_NL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPass_NL.Location = new System.Drawing.Point(317, 76);
            this.txtPass_NL.Name = "txtPass_NL";
            this.txtPass_NL.ReadOnly = true;
            this.txtPass_NL.Size = new System.Drawing.Size(178, 20);
            this.txtPass_NL.TabIndex = 13;
            this.txtPass_NL.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPass.Location = new System.Drawing.Point(317, 50);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(178, 20);
            this.txtPass.TabIndex = 12;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkQLUser);
            this.panel1.Controls.Add(this.checkXuatHang);
            this.panel1.Controls.Add(this.checkNhapHang);
            this.panel1.Controls.Add(this.checkSuaDP);
            this.panel1.Controls.Add(this.checkThemDP);
            this.panel1.Location = new System.Drawing.Point(39, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 51);
            this.panel1.TabIndex = 11;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChucVu.Location = new System.Drawing.Point(576, 76);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(178, 20);
            this.txtChucVu.TabIndex = 13;
            // 
            // frKichHoatTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 347);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtPass_NL);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frKichHoatTK";
            this.Text = "KichHoatTK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frKichHoatTK_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox checkQLUser;
        private System.Windows.Forms.CheckBox checkXuatHang;
        private System.Windows.Forms.CheckBox checkNhapHang;
        private System.Windows.Forms.CheckBox checkSuaDP;
        private System.Windows.Forms.CheckBox checkThemDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass_NL;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.TextBox txtChucVu;
    }
}