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
    public partial class frPhieuXuat : Form
    {
        int dem,Gia;
        int maPX = frXuatHang.SoRow;
        string Selected_MaDP = "";
        Timer timer_DongBoData;
        public frPhieuXuat()
        {
            InitializeComponent();            
        }

        BindingSource bs = new BindingSource();
        BUS_PhieuXuat BUS = new BUS_PhieuXuat();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            int Loi_xh = 0;
            if(dem == 0)
            {
                MessageBox.Show("Chưa chọn dược phẩm để xuất", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int sl;
                int TongTien = 0;
                BUS.BUS_ThemPhieuXuat(txtNgay.Text, cbThang.Text, cbNam.Text, txtTenKH.Text, MainForm.use, TongTien, txtSoLuong.Text, maPX);
                for (int i = 0; i < dem;i++ )
                {
                    sl = 0;
                    sl = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    string GiaBan = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string DVT = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string ten = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string MaDP = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    try
                    {
                        
                        if (BUS.BUS_Drop_SL_DP(MaDP,ten, sl, DVT, GiaBan, maPX.ToString()) == true)
                        {

                            //LoadThuocTinh();
                            TongTien = TongTien + Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Không đủ số lượng " + ten + " cần xuất!\nVui lòng thử lại.", "Thiếu hàng trong kho");
                            LoadThuocTinh();
                            Loi_xh++;
                            continue;
                        }
                    }
                    catch(Exception o)
                    {
                        MessageBox.Show("Xuất hiện lỗi:\n" + o.ToString());
                    }
                }
                BUS.BUS_UpdateTongTien(TongTien.ToString(), maPX);
                MessageBox.Show("Đã xuất " + (dem - Loi_xh) + " mặt hàng", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maPX++;
                dataGridView1.Rows.Clear();
                dem = 0;
            }
        }

        private void frPhieuXuat_Load(object sender, EventArgs e)
        {
            txtTenKH.Focus();
            txtNgay.Text = DateTime.Now.ToString("dd/M/yyyy");
            cbNgay.Text = DateTime.Now.ToString("dd");
            cbThang.Text = DateTime.Now.ToString("MM");
            cbNam.Text = DateTime.Now.ToString("yyyy");
            dem = 0;

            try
            {
                // Ràng buộc dữ liệu vào BindingSource
            bs.DataSource = BUS.BUS_LoadTenDP();
            // Gán nguồn dữ liệu cho DataGridView
            dataGridView2.DataSource = bs;
            //cbTenDP.DataSource = bs;
            //cbTenDP.DisplayMember = "TenDP";
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }

            timer_DongBoData = new Timer();
            timer_DongBoData.Tick += timer_DongBoData_Tick;
            timer_DongBoData.Interval = 100;
            //timer_DongBoData.Enabled = true;

        }


        private void timer_DongBoData_Tick(object sender, EventArgs e)
        {
            LoadThuocTinh();
        }

        private void cbTenDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadThuocTinh();
        }

        void LoadThuocTinh()
        {
            try
            {
                SqlDataReader dr = BUS.BUS_LoadThuocTinhDP(Selected_MaDP);

                if (dr.Read())
                {
                    txtSLConTrongKho.Text = dr[1].ToString();
                    lbDVT1.Text = dr[0].ToString();
                    lbDVT2.Text = dr[0].ToString();
                    Gia = Convert.ToInt32(dr[2]);
                }
                dr.Close();
                BUS.BUS_CloseConnect_LoadThuocTinhDP();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text == "" || txtTenKH.Text == "" || txtSLConTrongKho.Text == "" || Selected_MaDP == "")
            {
                MessageBox.Show("Không được để trống!", "Lưu ý");
            }
            else if (Convert.ToInt16(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Convert.ToInt16(txtSLConTrongKho.Text) < Convert.ToInt16(txtSoLuong.Text))
            {
                MessageBox.Show("Không đủ số lượng cần xuất!\nTrong kho chỉ còn " 
                    +txtSLConTrongKho.Text+" "+lbDVT2.Text+" "+Selected_MaDP, "Hết hàng trong kho"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(checkin() == false)
            {

            }
            else
            {
                
                txtTenKH.ReadOnly = true;
                bool Check_trung_ten = false;
                int temp = 0;
                if(dataGridView1.Rows.Count > 1)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == Selected_MaDP)
                        {
                            Check_trung_ten = true;
                            temp = i;
                            break;
                        }    
                    }
                }
                    


                if (Check_trung_ten == true)
                {
                    int Sl_old = Convert.ToInt32(dataGridView1.Rows[temp].Cells[2].Value.ToString());
                    dataGridView1.Rows.RemoveAt(temp);
                    dataGridView1.Rows.Insert(temp,Selected_MaDP,dataGridView2.CurrentRow.Cells[1].Value, Convert.ToInt32(txtSoLuong.Text)+Sl_old, lbDVT1.Text, Gia, Gia * (Convert.ToInt32(txtSoLuong.Text)+Sl_old));

                }
                else
                {
                    dem++;
                    dataGridView1.Rows.Add(Selected_MaDP, dataGridView2.CurrentRow.Cells[1].Value, txtSoLuong.Text, lbDVT1.Text, Gia, Gia * Convert.ToInt16(txtSoLuong.Text));
                }
                txtSLConTrongKho.Text = (Convert.ToInt32(txtSLConTrongKho.Text) - Convert.ToInt32(txtSoLuong.Text)).ToString();
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
            }
        }

        Boolean checkin()
        {
            Boolean check = true;
            if (Convert.ToInt16(cbThang.Text) < 1 || Convert.ToInt16(cbThang.Text) > 12)
            {
                MessageBox.Show("Không có tháng " + cbThang.Text);
                check = false;
            }
            else
            {
                if (Convert.ToInt16(cbThang.Text) == 1 || Convert.ToInt16(cbThang.Text) == 3 ||
                    Convert.ToInt16(cbThang.Text) == 5 || Convert.ToInt16(cbThang.Text) == 7 ||
                    Convert.ToInt16(cbThang.Text) == 8 || Convert.ToInt16(cbThang.Text) == 10 ||
                    Convert.ToInt16(cbThang.Text) == 12)
                {
                    if (Convert.ToInt16(cbNgay.Text) < 1 || Convert.ToInt16(cbNgay.Text) > 31)
                    {
                        MessageBox.Show("Tháng " + cbThang.Text + " không có ngày " + cbNgay.Text);
                        check = false;
                    }
                }
                else if (Convert.ToInt16(cbThang.Text) == 4 || Convert.ToInt16(cbThang.Text) == 6 ||
                    Convert.ToInt16(cbThang.Text) == 9 || Convert.ToInt16(cbThang.Text) == 11)
                {
                    if (Convert.ToInt16(cbNgay.Text) < 1 || Convert.ToInt16(cbNgay.Text) > 30)
                    {
                        MessageBox.Show("Tháng " + cbThang.Text + " không có ngày " + cbNgay.Text);
                        check = false;
                    }
                }
                else if (Convert.ToInt16(cbThang.Text) == 2)
                {
                    if (Convert.ToInt16(cbNam.Text) % 4 == 0 && Convert.ToInt16(cbNam.Text) % 100 != 0 || Convert.ToInt16(cbNam.Text) % 400 == 0)
                    {
                        if (Convert.ToInt16(cbNgay.Text) < 1 || Convert.ToInt16(cbNgay.Text) > 29)
                        {
                            MessageBox.Show("Tháng " + cbThang.Text + " năm " + cbNam.Text + " không có ngày " + cbNgay.Text);
                            check = false;
                        }
                    }
                    else
                    {
                        if (Convert.ToInt16(cbNgay.Text) < 1 || Convert.ToInt16(cbNgay.Text) > 28)
                        {
                            MessageBox.Show("Tháng " + cbThang.Text + " năm " + cbNam.Text + " không có ngày " + cbNgay.Text);
                            check = false;
                        }
                    }
                }
            }    

            return check;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNgay.Text = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            dem--;
        }

        private void cbTenDP_TextChanged(object sender, EventArgs e)
        {
            if(cbTenDP.Text == "")
            {
                try
                {
                    bs.DataSource = BUS.BUS_LoadTenDP();
                    String str = "TenDP like '%'";
                    bs.Filter = str;
                    dataGridView2.DataSource = bs;
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối đến CSDL!");
                    kn.ShowDialog();
                }
            }
            else
            {
                try
                {
                    bs.DataSource = BUS.BUS_LoadTenDP();
                    String str = "TenDP like '%" + cbTenDP.Text + "%'";
                    bs.Filter = str;
                    dataGridView2.DataSource = bs;
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối đến CSDL!");
                    kn.ShowDialog();
                }
            }
            
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            //Selected_MaDP = dataGridView2.CurrentCell.Value.ToString();
        }

        private void dataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //Selected_MaDP = dataGridView2.CurrentCell.Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected_MaDP = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show("Mã DP đc chọn " + Selected_MaDP);
            LoadThuocTinh();
        }

        
    }
}
