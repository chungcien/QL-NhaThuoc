namespace QL_NhaThuoc
{
    partial class frSuaThongTin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLuu_TT = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu_MK = new System.Windows.Forms.Button();
            this.txtMatKhau_DoiMK = new System.Windows.Forms.TextBox();
            this.txtPassMoi = new System.Windows.Forms.TextBox();
            this.txtPass_NL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 238);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLuu_TT);
            this.tabPage1.Controls.Add(this.txtMK);
            this.tabPage1.Controls.Add(this.txtHoTen);
            this.tabPage1.Controls.Add(this.txtSDT);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtChucVu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLuu_MK);
            this.tabPage2.Controls.Add(this.txtMatKhau_DoiMK);
            this.tabPage2.Controls.Add(this.txtPassMoi);
            this.tabPage2.Controls.Add(this.txtPass_NL);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đổi mật khẩu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLuu_TT
            // 
            this.btnLuu_TT.Location = new System.Drawing.Point(198, 166);
            this.btnLuu_TT.Name = "btnLuu_TT";
            this.btnLuu_TT.Size = new System.Drawing.Size(88, 26);
            this.btnLuu_TT.TabIndex = 37;
            this.btnLuu_TT.Text = "Lưu";
            this.btnLuu_TT.UseVisualStyleBackColor = true;
            this.btnLuu_TT.Click += new System.EventHandler(this.btnLuu_TT_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(133, 127);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(214, 20);
            this.txtMK.TabIndex = 36;
            this.txtMK.Text = "Nhập mật khẩu để xác thực";
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            this.txtMK.Enter += new System.EventHandler(this.txtMK_Enter);
            this.txtMK.Leave += new System.EventHandler(this.txtMK_Leave);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(133, 20);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(214, 20);
            this.txtHoTen.TabIndex = 32;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(133, 46);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(214, 20);
            this.txtSDT.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Chức vụ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(133, 98);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(214, 20);
            this.txtChucVu.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Họ tên";
            // 
            // btnLuu_MK
            // 
            this.btnLuu_MK.Location = new System.Drawing.Point(200, 137);
            this.btnLuu_MK.Name = "btnLuu_MK";
            this.btnLuu_MK.Size = new System.Drawing.Size(88, 26);
            this.btnLuu_MK.TabIndex = 23;
            this.btnLuu_MK.Text = "Lưu";
            this.btnLuu_MK.UseVisualStyleBackColor = true;
            this.btnLuu_MK.Click += new System.EventHandler(this.btnLuu_MK_Click);
            // 
            // txtMatKhau_DoiMK
            // 
            this.txtMatKhau_DoiMK.Location = new System.Drawing.Point(136, 50);
            this.txtMatKhau_DoiMK.Name = "txtMatKhau_DoiMK";
            this.txtMatKhau_DoiMK.Size = new System.Drawing.Size(214, 20);
            this.txtMatKhau_DoiMK.TabIndex = 20;
            this.txtMatKhau_DoiMK.Text = "Mật khẩu hiện tại";
            this.txtMatKhau_DoiMK.TextChanged += new System.EventHandler(this.txtMatKhau_DoiMK_TextChanged);
            this.txtMatKhau_DoiMK.Enter += new System.EventHandler(this.txtMatKhau_DoiMK_Enter);
            this.txtMatKhau_DoiMK.Leave += new System.EventHandler(this.txtMatKhau_DoiMK_Leave);
            // 
            // txtPassMoi
            // 
            this.txtPassMoi.Location = new System.Drawing.Point(136, 76);
            this.txtPassMoi.Name = "txtPassMoi";
            this.txtPassMoi.Size = new System.Drawing.Size(214, 20);
            this.txtPassMoi.TabIndex = 21;
            this.txtPassMoi.Text = "Nhập mật khẩu mới";
            this.txtPassMoi.TextChanged += new System.EventHandler(this.txtPassMoi_TextChanged);
            this.txtPassMoi.Enter += new System.EventHandler(this.txtPassMoi_Enter);
            this.txtPassMoi.Leave += new System.EventHandler(this.txtPassMoi_Leave);
            // 
            // txtPass_NL
            // 
            this.txtPass_NL.Location = new System.Drawing.Point(136, 102);
            this.txtPass_NL.Name = "txtPass_NL";
            this.txtPass_NL.Size = new System.Drawing.Size(214, 20);
            this.txtPass_NL.TabIndex = 22;
            this.txtPass_NL.Text = "Nhập lại mật khẩu mới";
            this.txtPass_NL.TextChanged += new System.EventHandler(this.txtPass_NL_TextChanged);
            this.txtPass_NL.Enter += new System.EventHandler(this.txtPass_NL_Enter);
            this.txtPass_NL.Leave += new System.EventHandler(this.txtPass_NL_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mật khẩu";
            // 
            // frSuaThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 238);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frSuaThongTin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.frSuaThongTin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLuu_TT;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLuu_MK;
        private System.Windows.Forms.TextBox txtMatKhau_DoiMK;
        private System.Windows.Forms.TextBox txtPassMoi;
        private System.Windows.Forms.TextBox txtPass_NL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

    }
}