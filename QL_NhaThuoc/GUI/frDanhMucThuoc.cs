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
    public partial class frDanhMucThuoc : Form
    {
        SqlDataReader dr_GetPhanQuyen;
        string Quyen_ThemDP, Quyen_SuaDP;
        public frDanhMucThuoc()
        {
            InitializeComponent();
            load();
        }

        BindingSource bs = new BindingSource();
        BUS_DanhMuc BUS = new BUS_DanhMuc();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        private void load()
        {
            try 
            {
                //BindingSource bs3 = new BindingSource();
                bs.DataSource = BUS.BUS_LoadDataBase("All");

                // Gán nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = bs;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
            
        }

        private void btnThemDuocPham_Click(object sender, EventArgs e)
        {
            if(btnThemDuocPham.Text == "Thêm Dược Phẩm")
            {
                cbDVT.Text = "-Chọn-";
                txtGiaBan.Text = "";
                txtGiaNhap.Text = "";
                txtNhaSanXuat.Text = "";
                txtTenDP.Text = "";

                btnThem_Sua.Text = "Thêm";
                btnNhapLai.Show();
                lbAdd_Sua.Text = "Thêm thông tin dược phẩm";
                btnThemDuocPham.Text = "Quay lại";
                btnDSThuocSapHet.Hide();
                txtTimKiem.Hide();
                label1.Hide();
                pnControls.Controls.Clear();
                dataGridView1.SetBounds(0, 0, pnControls.Size.Width, pnControls.Size.Height*3/5);
                pnControls.Controls.Add(dataGridView1);
                pnControls.Controls.Add(pnadd_sua);
                dataGridView1.Show();
                pnadd_sua.Show();
            }
            else
            {
                btnThemDuocPham.Text = "Thêm Dược Phẩm";
                btnDSThuocSapHet.Show();
                txtTimKiem.Show();
                label1.Show();
                pnControls.Controls.Clear();
                dataGridView1.SetBounds(0, 0, pnControls.Size.Width, pnControls.Size.Height);
                pnControls.Controls.Add(dataGridView1);
                dataGridView1.Show();
            }
            
        }

        private void btnThuocSapHet_Click(object sender, EventArgs e)
        {
            
            if(btnDSThuocSapHet.Text == "Danh sách thuốc sắp hết trong kho")
            {
                btnDSThuocSapHet.Text = "Hiển thị tất cả dược phẩm";

                try
                {
                    BindingSource bs1 = new BindingSource();
                    // Ràng buộc dữ liệu vào BindingSource
                    bs1.DataSource = BUS.BUS_LoadDataBase("SapHet");

                    // Gán nguồn dữ liệu cho DataGridView
                    dataGridView1.DataSource = bs1;
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối CSDL!");
                    kn.ShowDialog();
                }
                
            }
            else
            {
                btnDSThuocSapHet.Text = "Danh sách thuốc sắp hết trong kho";
                try
                {
                    BindingSource bs1 = new BindingSource();
                    bs1.DataSource = BUS.BUS_LoadDataBase("All");
                    dataGridView1.DataSource = bs1;
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối CSDL!");
                    kn.ShowDialog();
                }
            }
        }

        private void frDanhMucThuoc_Load(object sender, EventArgs e)
        {
            pnControls.Controls.Clear();
            dataGridView1.SetBounds(0, 0, pnControls.Size.Width, pnControls.Size.Height);
            pnControls.Controls.Add(dataGridView1);
            dataGridView1.Show();

            try
            {
                dr_GetPhanQuyen = BUS.BUS_GetPhanQuyen(MainForm.use);
                if (dr_GetPhanQuyen.Read())
                {
                    Quyen_ThemDP = dr_GetPhanQuyen[0].ToString();
                    Quyen_SuaDP = dr_GetPhanQuyen[1].ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi khi đọc quyền truy cập các chức năng của tài khoản!");
                }
                dr_GetPhanQuyen.Close();
                BUS.BUS_CloseConnect_PhanQuyen();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbAdd_Sua.Text = "Sửa thông tin dược phẩm";
            btnNhapLai.Hide();
            btnThem_Sua.Text = "Sửa";
            dataGridView1.SetBounds(0, 0, pnControls.Size.Width, pnControls.Size.Height*3/5);
            pnControls.Controls.Add(pnadd_sua);
            dataGridView1.Show();
            pnadd_sua.Show();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtTenDP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TenDP"].Value);
                txtNhaSanXuat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NhaSanXuat"].Value);
                cbDVT.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["DVT"].Value);
                txtGiaNhap.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["GiaNhap"].Value);
                txtGiaBan.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["GiaBan"].Value);
            }
        }

        private void btnThem_Sua_Click(object sender, EventArgs e)
        {
            if(cbDVT.Text == "" || cbDVT.Text == "" || txtTenDP.Text == "" || txtNhaSanXuat.Text == "" || txtGiaBan.Text == "" || txtGiaNhap.Text == "")
            {
                MessageBox.Show("Không được đê trống", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (btnThem_Sua.Text == "Thêm")
                {
                    if (Quyen_ThemDP == "1")
                    {
                        try
                        {
                            if (BUS.BUS_GetTenDP(txtTenDP.Text).Read())
                            {
                                MessageBox.Show("Tên dược phẩm này đã tồn tại!");
                                btnThem_Sua.Enabled = false;
                            }
                            else
                            {
                                DTO_DP DTO_Them_DP = new DTO_DP(txtTenDP.Text, txtNhaSanXuat.Text, cbDVT.Text, txtGiaNhap.Text, txtGiaBan.Text);
                                if(BUS.BUS_ThemDP(DTO_Them_DP))
                                {
                                    DataTable dt = (DataTable)bs.DataSource;
                                    DataRow row = dt.NewRow();
                                    row["TenDP"] = txtTenDP.Text;
                                    row["NhaSanXuat"] = txtNhaSanXuat.Text;
                                    row["DVT"] = cbDVT.Text;
                                    row["SoLuong"] = "0";
                                    row["GiaNhap"] = txtGiaNhap.Text;
                                    row["GiaBan"] = txtGiaBan.Text;
                                    dt.Rows.Add(row);

                                    cbDVT.Text = "";
                                    txtGiaBan.Text = "";
                                    txtGiaNhap.Text = "";
                                    txtNhaSanXuat.Text = "";
                                    txtTenDP.Text = "";
                                    MessageBox.Show("Đã cập nhật dữ liệu này thành công", "Thông báo");
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi kết nối CSDL!");
                                    kn.ShowDialog();
                                }
                            }
                            BUS.BUS_CloseConnect_DanhMuc();
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi kết nối CSDL!");
                            kn.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!\nLiên hệ với Admin để biết thêm chi tiết.", "Thông báo");
                    }
                }
                else
                {
                    if (Quyen_SuaDP == "1")
                    {
                        try
                        {
                            int id = (int)dataGridView1.CurrentRow.Cells["MaDP"].Value;
                            DTO_DP DTO_Sua_DP = new DTO_DP(txtTenDP.Text, txtNhaSanXuat.Text, cbDVT.Text, txtGiaNhap.Text, txtGiaBan.Text);
                            if(BUS.BUS_SuaDP(DTO_Sua_DP, id))
                            {
                                DataRowView row = (DataRowView)bs.Current; // Hàng chọn hiện thời
                                row["TenDP"] = txtTenDP.Text;
                                row["NhaSanXuat"] = txtNhaSanXuat.Text;
                                row["DVT"] = cbDVT.Text;
                                row["GiaNhap"] = txtGiaNhap.Text;
                                row["GiaBan"] = txtGiaBan.Text;
                                bs.ResetCurrentItem();

                                cbDVT.Text = "";
                                txtGiaBan.Text = "";
                                txtGiaNhap.Text = "";
                                txtNhaSanXuat.Text = "";
                                txtTenDP.Text = "";
                                MessageBox.Show("Sửa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Lỗi kết nối CSDL!");
                                kn.ShowDialog();
                            }  
                        }
                        catch
                        {
                            MessageBox.Show("Lỗi kết nối CSDL!");
                            kn.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!\nLiên hệ với Admin để biết thêm chi tiết.", "Thông báo");
                    }
                }
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            cbDVT.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtNhaSanXuat.Text = "";
            txtTenDP.Text = "";

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                String str = "TenDP like '%" + txtTimKiem.Text + "%'";
                bs.Filter = str;
                dataGridView1.DataSource = bs;
            }
            else
            {
                try
                {
                    BindingSource bs1 = new BindingSource();
                    bs1.DataSource = BUS.BUS_LoadDataBase("All");
                    dataGridView1.DataSource = bs1;
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối CSDL!");
                    kn.ShowDialog();
                }
            }
        }

        private void txtTenDP_TextChanged(object sender, EventArgs e)
        {
            btnThem_Sua.Enabled = true;
        }
    }
}
