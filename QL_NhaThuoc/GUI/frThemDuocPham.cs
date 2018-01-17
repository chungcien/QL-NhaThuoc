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
    public partial class frThemDuocPham : Form
    {
        public frThemDuocPham()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        string Quyen_ThemDP;
        BUS_DanhMuc BUS = new BUS_DanhMuc();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbDVT.Text == "" || cbDVT.Text == "" || txtTenDP.Text == "" || txtNhaSanXuat.Text == "" || txtGiaBan.Text == "" || txtGiaNhap.Text == "")
            {
                MessageBox.Show("Không được đê trống", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(Quyen_ThemDP == "1")
                {
                    try
                    {
                        if (BUS.BUS_GetTenDP(txtTenDP.Text).Read())
                        {
                            MessageBox.Show("Tên Dược phẩm này đã tồn tại!\nVui lòng nhập lại tên khác.", "Thông báo");
                            btnThem.Enabled = false;
                        }
                        else
                        {
                            DTO_DP DP = new DTO_DP(txtTenDP.Text, txtNhaSanXuat.Text, cbDVT.Text, txtGiaNhap.Text, txtGiaBan.Text);
                            if (BUS.BUS_ThemDP(DP) == true)
                            {
                                MessageBox.Show("Đã cập nhật dữ liệu này thành công", "Thông báo");
                                cbDVT.Text = "";
                                txtGiaBan.Text = "";
                                txtGiaNhap.Text = "";
                                txtNhaSanXuat.Text = "";
                                txtTenDP.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Lỗi!\nKhông thể cập nhật dữ liệu!", "Thông báo");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi kết nối đến CSDL!");
                        kn.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!\nLiên hệ với Admin để biết thêm chi tiết.", "Thông báo");
                }
                
            }   
        }

        private void txtTenDP_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
        }

        private void frThemDuocPham_Load(object sender, EventArgs e)
        {
            try
            {
                dr = BUS.BUS_GetPhanQuyen(MainForm.use);
                if (dr.Read())
                {
                    Quyen_ThemDP = dr[0].ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi khi đọc quyền truy cập các chức năng của tài khoản!");
                }
                dr.Close();
                BUS.BUS_CloseConnect_PhanQuyen();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến CSDL!");
                kn.ShowDialog();
            }
        }
    }
}
