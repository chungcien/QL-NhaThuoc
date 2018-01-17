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
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace QL_NhaThuoc
{
    public partial class frDangKy : Form
    {
        BUS_DangKy BUS = new BUS_DangKy();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        public frDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtDT.Text == "" || txtEmail.Text == "" || txtID.Text == ""
                || txtMK.Text == "" || txtNhapLaiMK.Text == "" || cbChucVu.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtNhapLaiMK.Text != txtMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!\nVui lòng nhập lại.");
            }
            else
            {
                try
                {
                    DTO_ThongTinDangKy TV = new DTO_ThongTinDangKy(txtID.Text, txtNhapLaiMK.Text, txtHoTen.Text, txtDT.Text, txtEmail.Text, cbChucVu.Text);
                    int loi = 0;
                    if (BUS.Bus_TextChange(txtID.Text, "ID"))
                    {
                        MessageBox.Show("Tên đăng nhập này đã tồn tại\nVui lòng chọn tên đăng nhập khác!");
                        loi = 1;
                    }

                    if (BUS.Bus_TextChange(txtEmail.Text, "Email"))
                    {
                        //if (dr2[0].ToString() == txtEmail.Text)

                        MessageBox.Show("Email này đã được đăng ký tài khoản\nVui lòng nhập Email khác!");
                        loi = 1;
                    }
                    if (loi == 0 && BUS.Bus_btnDangKy(TV))
                    {
                        MessageBox.Show("Đã đăng ký thành công!\nVui lòng đợi Admin kiểm duyệt và kích hoạt tài khoản!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối CSDL!");
                    kn.ShowDialog();
                }
            }
            
        }

        //định dạng các ô chỉ đc nhập số, không được nhập ký tự
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }

        private void txtNhapLaiMK_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        public bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.ToCharArray().Any(c => c > MaxAnsiCode);
        }

        private void txtDT_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtDT.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txtDT.Text = "";
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
                panel1.BackColor = Color.Tomato;
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void txtDT_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void txtDT_Leave(object sender, EventArgs e)
        {
            if (txtDT.Text == "")
            {
                panel2.BackColor = Color.Tomato;
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Transparent;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                panel4.BackColor = Color.Tomato;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Transparent;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(txtEmail.Text))
                panel3.BackColor = Color.Transparent;
            else
                panel3.BackColor = Color.Tomato;
        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.Transparent;
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                panel5.BackColor = Color.Tomato;
            }
        }

        private void txtNhapLaiMK_Enter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Transparent;
        }

        private void txtNhapLaiMK_Leave(object sender, EventArgs e)
        {
            if (txtNhapLaiMK.Text == "")
            {
                panel6.BackColor = Color.Tomato;
            }
            else if (txtMK.Text != txtNhapLaiMK.Text)
            {
                panel6.BackColor = Color.Tomato;
            }
            else
            {
                panel6.BackColor = Color.Transparent;
            }
        }

        private void txtNhapLaiMK_KeyPress(object sender, KeyPressEventArgs e)
        {

            string strRegex = @"^([a-zA-Z0-9_\-\.]+)";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(txtNhapLaiMK.Text))
                panel3.BackColor = Color.Transparent;
            else
                panel3.BackColor = Color.Tomato;
        }

        private void frDangKy_Load(object sender, EventArgs e)
        {
            
        }
    }
}
