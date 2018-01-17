using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_NhaThuoc
{
    public partial class frSuaThongTin : Form
    {
        public frSuaThongTin()
        {
            InitializeComponent();
        }
        BUS_SuaThongTin BUS = new BUS_SuaThongTin();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        SqlDataReader dr;
        string pass;
        private void frSuaThongTin_Load(object sender, EventArgs e)
        {
            txtPassMoi.ForeColor = Color.DarkGray;
            txtMK.ForeColor = Color.DarkGray;
            txtMatKhau_DoiMK.ForeColor = Color.DarkGray;
            txtPass_NL.ForeColor = Color.DarkGray;

            try
            {
                dr = BUS.BUS_GetThuocTinhUser(MainForm.use);        // lấy các thông tin của user
                if (dr.Read())
                {
                    txtHoTen.Text = dr[0].ToString();
                    txtSDT.Text = dr[1].ToString();
                    txtEmail.Text = dr[2].ToString();
                    txtChucVu.Text = dr[3].ToString();
                    pass = dr[4].ToString();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi load thuộc tính User: " + MainForm.use, "Lỗi");
                }
                dr.Close();
                BUS.BUS_CloseConnect_SuaThongTin();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }

        


        // khi click vào thì cho ô ấy trống, bật chế độ gõ password
        private void txtMatKhau_DoiMK_Enter(object sender, EventArgs e)
        {
            txtMatKhau_DoiMK.Text = "";
            txtMatKhau_DoiMK.UseSystemPasswordChar = true;
        }

        //khi rời đi thì kiểm tra textbox trống thì hiện dòng chữ..., không trống thì để nguyên
        private void txtMatKhau_DoiMK_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau_DoiMK.Text == "")
            {
                txtMatKhau_DoiMK.UseSystemPasswordChar = false;
                txtMatKhau_DoiMK.Text = "Mật khẩu hiện tại";
                txtMatKhau_DoiMK.ForeColor = Color.DarkGray;
            }
        }

        // khi gõ chữ thì set lại màu chữ
        private void txtMatKhau_DoiMK_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau_DoiMK.ForeColor = Color.Black;
        }

        private void txtPassMoi_TextChanged(object sender, EventArgs e)
        {
            txtPassMoi.ForeColor = Color.Black;
        }

        private void txtPassMoi_Enter(object sender, EventArgs e)
        {
            txtPassMoi.Text = "";
            txtPassMoi.UseSystemPasswordChar = true;
        }

        private void txtPassMoi_Leave(object sender, EventArgs e)
        {
            if (txtPassMoi.Text == "")
            {
                txtPassMoi.UseSystemPasswordChar = false;
                txtPassMoi.Text = "Nhập mật khẩu mới";
                txtPassMoi.ForeColor = Color.DarkGray;
            }
        }

        private void txtPass_NL_TextChanged(object sender, EventArgs e)
        {
            txtPass_NL.ForeColor = Color.Black;
        }

        private void txtPass_NL_Enter(object sender, EventArgs e)
        {
            txtPass_NL.Text = "";
            txtPass_NL.UseSystemPasswordChar = true;
        }

        private void txtPass_NL_Leave(object sender, EventArgs e)
        {
            if (txtPass_NL.Text == "")
            {
                txtPass_NL.UseSystemPasswordChar = false;
                txtPass_NL.Text = "Nhập lại mật khẩu mới";
                txtPass_NL.ForeColor = Color.DarkGray;
            }
        }

        private void btnLuu_TT_Click(object sender, EventArgs e)
        {
            if(MaHoaString.GetMD5(MaHoaString.GetMD5(txtMK.Text)) == pass)
            {
                if (BUS.BUS_UpdateUser(MainForm.use, txtHoTen.Text, txtSDT.Text))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật dữ liệu!", "Error");
                    kn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu bạn nhập không đúng!", "Error");
            }
        }

        private void btnLuu_MK_Click(object sender, EventArgs e)
        {
            if(txtPass_NL.Text != txtPassMoi.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Error");
            }
            else
            {
                try
                {
                    SqlDataReader dr = BUS.BUS_GetPass(MainForm.use);
                    if (dr.Read())
                    {
                        if (dr[0].ToString() == MaHoaString.GetMD5(MaHoaString.GetMD5(txtMatKhau_DoiMK.Text)))
                        {
                            if (BUS.BUS_ChangePass(MainForm.use, MaHoaString.GetMD5(MaHoaString.GetMD5(txtPass_NL.Text))) == true)
                            {
                                MessageBox.Show("Đã đổi Mật khẩu thành công!", "Thông báo");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Đã xảy ra lỗi!", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không đúng!", "Error");
                        }
                    }
                    dr.Close();
                    BUS.BUS_CloseConnect_SuaThongTin();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối CSDL!");
                    kn.ShowDialog();
                }
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            txtMK.ForeColor = Color.Black;
        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtMK.UseSystemPasswordChar = true;
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                txtMK.UseSystemPasswordChar = false;
                txtMK.Text = "Nhập mật khẩu để xác thực";
                txtMK.ForeColor = Color.DarkGray;
            }
        }
    }
}
