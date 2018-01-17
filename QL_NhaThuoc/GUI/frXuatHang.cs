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
    public partial class frXuatHang : Form
    {
        public frXuatHang()
        {
            InitializeComponent();
        }
        BUS_XuatHang BUS = new BUS_XuatHang();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        SqlConnection cnn = StringSQLConnect.StringSQL();
        BindingSource bs = new BindingSource();
        public  static int SoRow = 0;

        private void frXuatHang_Load(object sender, EventArgs e)
        {
            pndataview.Controls.Clear();
            dataGridView1.SetBounds(0, 0, pndataview.Size.Width, pndataview.Size.Height);
            pndataview.Controls.Add(dataGridView1);
            dataGridView1.Show();

            try
            {
                // lấy ds phiếu xuất theo từng tháng rồi gán vào comboBox
                BindingSource bs1 = new BindingSource();
                bs1.DataSource = BUS.BUS_GetDanhSachPX_Thang();
                cbChonDS.DataSource = bs1;
                cbChonDS.DisplayMember = "ThangNamXuat";

                // lấy tất cả ds phiếu xuất cho vào datagirlview
                bs.DataSource = BUS.BUS_Get_All_PX();
                dataGridView1.DataSource = bs;

                SoRow = dataGridView1.Rows.Count;
            }
            catch(Exception l)
            {
                MessageBox.Show("Lỗi kết nối đến CSDL!"+l.ToString());
                kn.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr_GetPhanQuyen = BUS.BUS_GetPhanQuyen(MainForm.use);
                if (dr_GetPhanQuyen.Read())
                {
                    if (dr_GetPhanQuyen[3].ToString() == "1")
                    {
                        if (btnThemPX.Text == "Thêm Phiếu Xuất Mới")
                        {
                            btnThemPX.Text = "Quay lại";
                            pnControls.Controls.Clear();
                            frPhieuXuat px = new frPhieuXuat();
                            px.TopLevel = false;
                            pnControls.Controls.Add(px);
                            px.Show();
                            cbChonDS.Hide();
                            label1.Hide();
                            label2.Hide();
                            txtTimKiem.Hide();
                        }
                        else
                        {
                            btnThemPX.Text = "Thêm Phiếu Xuất Mới";
                            pnControls.Controls.Clear();
                            pnControls.Controls.Add(pndataview);
                            pndataview.Show();
                            cbChonDS.Show();
                            label2.Show();
                            label1.Show();
                            txtTimKiem.Show();

                            bs.DataSource = BUS.BUS_Get_All_PX();
                            dataGridView1.DataSource = bs;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!\nLiên hệ với Admin để biết thêm chi tiết.", "Thông báo");
                    }
                }
                dr_GetPhanQuyen.Close();
                BUS.BUS_CloseConnect_PhanQuyen();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến CSDL!");
                kn.ShowDialog();
            }
        }

        private void cbChonDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs2 = new BindingSource();

                // Ràng buộc dữ liệu vào BindingSource
                bs2.DataSource = BUS.BUS_Load_PX_TrongThang(cbChonDS.Text);

                // Gán nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = bs2;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến CSDL!");
                kn.ShowDialog();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bs.DataSource = BUS.BUS_Get_All_PX();
                String str = "TenKH like '%" + txtTimKiem.Text + "%'";
                bs.Filter = str;
                dataGridView1.DataSource = bs;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối đến CSDL!");
                kn.ShowDialog();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView2.Rows.Clear();
            dataGridView1.SetBounds(0, 0, pndataview.Size.Width, pndataview.Size.Height / 2);
            pnTTCT.SetBounds(0, dataGridView1.Size.Height + 10, pndataview.Size.Width, pndataview.Size.Height / 2);    //resize panel thông tin chi tiết
            pndataview.Controls.Add(pnTTCT);
            pndataview.Controls.Add(dataGridView1);
            pnTTCT.Show();
            dataGridView1.Show();
            //lấy Mã phiếu xuất trong bảng 1
            int MaPX = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.CurrentRow.Cells["MaPX"].Value.ToString() != "")
            {
                MaPX = Convert.ToInt16(dataGridView1.CurrentRow.Cells["MaPX"].Value.ToString());
            }

            try
            {
                // lấy ra trường có thông tin của tên dược phẩm, số lượng, ĐVT.
                BindingSource bs5 = new BindingSource();
                bs5.DataSource = BUS.BUS_ChiTietPX(MaPX);

                dataGridView2.DataSource = bs5;                 
                
            }
            catch (Exception k)
            {
                MessageBox.Show("Lỗi kết nối đến CSDL!" + k.ToString());
                kn.ShowDialog();
            }
        }
    }
}
