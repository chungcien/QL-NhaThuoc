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
    public partial class frKichHoatTK : Form
    {
        public frKichHoatTK()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        BindingSource bs = new BindingSource();
        BUS_KichHoat BUS = new BUS_KichHoat();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        SqlConnection cnn = StringSQLConnect.StringSQL();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Kích hoạt?", "Lưu?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
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
                DTO_ThongTinDangKy NV = new DTO_ThongTinDangKy(cbUsers.Text, txtPass_NL.Text, txtName.Text, txtSDT.Text, txtEmail.Text, txtChucVu.Text);
                DTO_ThuocTinhUser TT = new DTO_ThuocTinhUser(Check_ThemDP, Check_SuaDP, Check_Nhap, Check_Xuat, Check_QL);
                if(BUS.BUS_Save(NV,TT))
                {
                    MessageBox.Show("Đã kích hoạt User thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Kích hoạt không thành công!\nLỗi kết nối CSDL!", "Thông báo");
                    kn.ShowDialog();
                }
                
                //load lại các user chưa kiểm duyệt
                try
                {
                    bs.DataSource = BUS.BUS_LoadUsers();
                    cbUsers.DataSource = bs;
                    cbUsers.DisplayMember = "ID";
                    Read_Quyen(cbUsers.Text);
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối CSDL!");
                    kn.ShowDialog();
                }
            }
        }
        


        private void frKichHoatTK_Load(object sender, EventArgs e)
        {
            try
            {
                bs.DataSource = BUS.BUS_LoadUsers();

                // Gán nguồn dữ liệu cho DataGridView
                cbUsers.DataSource = bs;
                cbUsers.DisplayMember = "ID";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }

        private void cbUsers_DropDownClosed(object sender, EventArgs e)
        {
            Read_Quyen(cbUsers.Text);
        }

        void Read_Quyen(string strID)
        {
            try
            {
                dr = BUS.BUS_Load(strID);
                if (dr.Read())
                {
                    //MessageBox.Show("" + strID);
                    txtName.Text = dr[0].ToString();
                    txtSDT.Text = dr[1].ToString();
                    txtEmail.Text = dr[2].ToString();
                    txtChucVu.Text = dr[3].ToString();
                    txtPass.Text = dr[4].ToString();
                    txtPass_NL.Text = dr[4].ToString();
                }
                dr.Close();
                BUS.BUS_CloseConnect_Load();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // xóa user yêu cầu kiểm duyệt trong bảng DangKy
            
            if(BUS.BUS_XoaYeuCau(cbUsers.Text) == true)
            {
                txtName.Text = "";
                txtSDT.Text = "";
                txtEmail.Text = "";
                txtChucVu.Text = "";
                txtPass.Text = "";
                txtPass_NL.Text = "";
                MessageBox.Show("Đã xóa yêu cầu kích hoạt ID: " + cbUsers.Text, "Thông báo");
            }
            else
            {
                MessageBox.Show("Không xóa được kích hoạt ID: " + cbUsers.Text+"\nLỗi kết nối CSDL!","Lỗi");
                kn.ShowDialog();
            }

            try
            {
                //reload lại các user còn lại chưa kiểm duyệt
                bs.DataSource = BUS.BUS_LoadUsers();
                cbUsers.DataSource = bs;
                cbUsers.DisplayMember = "ID";
                Read_Quyen(cbUsers.Text);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }
    }
}
