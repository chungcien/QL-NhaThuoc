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
    public partial class frQuanLyUser : Form
    {
        public frQuanLyUser()
        {
            InitializeComponent();
        }

        SqlConnection cnn = StringSQLConnect.StringSQL();
        BindingSource bs = new BindingSource();
        BUS_QLUsers BUS = new BUS_QLUsers();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        private void frQuanLyUser_Load(object sender, EventArgs e)
        {
            try 
            {
                // load các users lên combobox
                // Ràng buộc dữ liệu vào BindingSource
                bs.DataSource = BUS.BUS_LoadID();

                // Gán nguồn dữ liệu cho DataGridView
                cbUsers.DataSource = bs;
                cbUsers.DisplayMember = "ID";

                // kiểm tra xem có dữ liệu trong bảng đăng ký hay không
                SqlDataReader dr2 = BUS.BUS_KiemTraBangDangKy();
                if (dr2.Read())
                {
                    btnDuyetUser.Show();    // nếu có dữ liệu thì show btn Duyệt lên
                }
                else
                {
                    btnDuyetUser.Hide();
                    panel2.SetBounds(0, 0, panel1.Size.Width, panel1.Size.Height);
                }
                dr2.Close();
                BUS.BUS_CloseConnect_QlUser();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
         
        }

        void Read(string strID)     // hàm lấy thuộc tính của user truyền vào
        {
            try 
            {
                SqlDataReader dr = BUS.BUS_GetThuocTinhUser(strID);
                if (dr.Read())
                {
                    txtName.Text = dr[0].ToString();
                    txtSDT.Text = dr[1].ToString();
                    txtEmail.Text = dr[2].ToString();
                    cbChucVu.Text = dr[3].ToString();
                    txtPass.Text = dr[9].ToString();
                    txtPass_NL.Text = dr[9].ToString();
                    if (dr[4].ToString() == "1")
                    {
                        checkThemDP.Checked = true;
                    }
                    else
                    {
                        checkThemDP.Checked = false;
                    }
                    if (dr[5].ToString() == "1")
                    {
                        checkSuaDP.Checked = true;
                    }
                    else
                    {
                        checkSuaDP.Checked = false;
                    }
                    if (dr[6].ToString() == "1")
                    {
                        checkNhapHang.Checked = true;
                    }
                    else
                    {
                        checkNhapHang.Checked = false;
                    }
                    if (dr[7].ToString() == "1")
                    {
                        checkXuatHang.Checked = true;
                    }
                    else
                    {
                        checkXuatHang.Checked = false;
                    }
                    if (dr[8].ToString() == "1")
                    {
                        checkQLUser.Checked = true;
                    }
                    else
                    {
                        checkQLUser.Checked = false;
                    }
                }
                dr.Close();
                BUS.BUS_CloseConnect_QlUser();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (cbUsers.Text == "admin")
            {
                MessageBox.Show("Không thể xóa User Admin", "Thông báo");
            }
            else
            {
                DialogResult dg = MessageBox.Show("Xóa User " + cbUsers.Text + " ?", "Xóa?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    // xóa user
                    if(BUS.BUS_DelUser(cbUsers.Text) == true)
                    {
                        MessageBox.Show("Đã xóa " + cbUsers.Text, "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được User: " + cbUsers.Text, "Lỗi");
                    }

                    try
                    {
                        //reload lại các user còn lại
                        BindingSource bs1 = new BindingSource();
                        // Ràng buộc dữ liệu vào BindingSource
                        bs1.DataSource = BUS.BUS_LoadID();

                        // Gán nguồn dữ liệu cho DataGridView
                        cbUsers.DataSource = bs1;
                        cbUsers.DisplayMember = "ID";
                        txtName.Text = "";
                        txtPass.Text = "";
                        txtPass_NL.Text = "";
                        txtSDT.Text = "";
                        txtEmail.Text = "";
                        cbChucVu.Text = "";
                        Read(cbUsers.Text);//lấy các thuộc tính của user hiển thị trên combobox sau khi xóa
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi kết nối CSDL!");
                        kn.ShowDialog();
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Lưu thay đổi?", "Lưu?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                ////lấy ra ID có địa chỉ mail vừa nhập vào
                //if (cnn.State == ConnectionState.Closed)
                //    cnn.Open();
                //SqlCommand cmd2 = new SqlCommand("select ID from Users Where Email = " + "N'" + txtEmail.Text + "'", cnn);
                //SqlDataReader dr2 = cmd2.ExecuteReader();
                //if (dr2.Read() && (cbUsers.Text != dr2[0].ToString())) // nếu lấy ra đc (có nghĩa là có ID nào đó đã đăng ký mail này rồi)
                //{
                //      // nếu ID vừa lấy trong DataBase ra không trùng với ID trong combobox
                    
                //        MessageBox.Show("Email này đã được đăng ký tài khoản\nVui lòng nhập Email khác!");
                    
                //}
                //else if (txtPass.Text != txtPass_NL.Text)
                //{
                //    MessageBox.Show("Mật khẩu nhập lại không khớp!\nVui lòng nhập lại!");
                //    txtPass.Text = "";
                //    txtPass_NL.Text = "";
                //}
                //else
                //{
                    if(cbUsers.Text == "admin")
                    {
                        MessageBox.Show("Không thể thay đổi quyền của Admin!", "Error");
                    }
                    else
                    {
                        string Check_ThemDP = "";
                        if (checkThemDP.Checked == true)
                        {
                            Check_ThemDP = "1";
                        }
                        else
                        {
                            Check_ThemDP = "0";
                        }

                        string Check_SuaDP = "";
                        if (checkSuaDP.Checked == true)
                        {
                            Check_SuaDP = "1";
                        }
                        else
                        {
                            Check_SuaDP = "0";
                        }

                        string Check_Nhap = "";
                        if (checkNhapHang.Checked == true)
                        {
                            Check_Nhap = "1";
                        }
                        else
                        {
                            Check_Nhap = "0";
                        }

                        string Check_Xuat = "";
                        if (checkXuatHang.Checked == true)
                        {
                            Check_Xuat = "1";
                        }
                        else
                        {
                            Check_Xuat = "0";
                        }

                        string Check_QL = "";
                        if (checkQLUser.Checked == true)
                        {
                            Check_QL = "1";
                        }
                        else
                        {
                            Check_QL = "0";
                        }

                        if (BUS.BUS_UpdateThuocTinhUser(cbChucVu.Text, Check_ThemDP, Check_SuaDP, Check_Nhap, Check_Xuat, Check_QL, cbUsers.Text) == true)
                        {
                            MessageBox.Show("Đã lưu thay đổi!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi!", "Lỗi");
                        }
                    }

                //}
                //cnn.Close();
            }
        }


        private void cbUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Read(cbUsers.Text);
        }

        private void btnDuyetUser_Click(object sender, EventArgs e)
        {
            frKichHoatTK dm = new frKichHoatTK();
            if (btnDuyetUser.Text == "Hiển thị danh sách Users chờ phê duyệt")
            {
                dm.TopLevel = false;
                dm.FormBorderStyle = FormBorderStyle.None;
                dm.BackColor = Color.DarkGray;
                panel2.Hide();
                panel1.Controls.Add(dm);
                dm.Show();
                btnDuyetUser.Text = "Quay lại trang Quản lý Users";
            }
            else
            {
                btnDuyetUser.Text = "Hiển thị danh sách Users chờ phê duyệt";
                dm.Hide();
                panel1.Controls.Clear();
                panel1.Controls.Add(panel2);
                panel2.Show();
            }
        }
    }
}
