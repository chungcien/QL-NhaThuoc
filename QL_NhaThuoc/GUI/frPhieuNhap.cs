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
    public partial class frPhieuNhap : Form
    {
        public int sl;
        public frPhieuNhap()
        {
            InitializeComponent();
            txtNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbNgay.Text = DateTime.Now.ToString("dd");
            cbThang.Text = DateTime.Now.ToString("MM");
            cbNam.Text = DateTime.Now.ToString("yyyy");
            lbDVT.Text = "";

            Load_All_DP();
        }
        BindingSource bs = new BindingSource();
        BUS_PhieuNhap BUS = new BUS_PhieuNhap();
        frKetNoiCSDL kn = new frKetNoiCSDL();

        void Load_All_DP()
        {
            try
            {
                bs.DataSource = BUS.BUS_LoadDP();
                dataGridView1.DataSource = bs;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }

        Boolean checkin()
        {
            Boolean check = true;
            if (txtMaDP.Text == "" || txtTenDP.Text == "" || txtGiaBan.Text == "" || txtGiaNhap.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Luu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
            }

            return check;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString() != "")
            {
                sl = 0;
                txtTenDP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TenDP"].Value);
                txtMaDP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaDp"].Value);
                sl = Convert.ToInt16(dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString());
                lbDVT.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["DVT"].Value);
                txtGiaNhap.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["GiaNhap"].Value);
                txtGiaBan.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["GiaBan"].Value);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Load_All_DP();

            String str = "TenDP like '%" + txtTim.Text + "%'";
            bs.Filter = str;
            dataGridView1.DataSource = bs;
        }

        private void frPhieuNhap_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Thêm dược phẩm mới");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "«")
            {
                pnControls.Controls.Clear();
                frThemDuocPham n = new frThemDuocPham();
                n.TopLevel = false;
                pnControls.Controls.Add(n);
                n.Show();
                pnPhai.BackColor = Color.Teal;
                button1.Text = "×";
                label4.Text = "Thông tin dược phẩm";
            }
            else
            {
                button1.Text = "«";
                pnControls.Controls.Clear();
                pnControls.Controls.Add(pnThongTinNhap);
                pnThongTinNhap.Show();
                pnPhai.BackColor = panel1.BackColor;
                label4.Text = "Thông tin nhập hàng";

                Load_All_DP();  // load lại tất cả DP lên datagirlview

            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (txtMaDP.Text == "" || txtTenDP.Text == "" || txtGiaBan.Text == "" || txtGiaNhap.Text == ""
                || cbNgay.Text == "Ngày" || cbThang.Text == "Tháng" || cbNam.Text == "Năm")
            {
                MessageBox.Show("Không được để trống!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (checkin() == true)
                {
                    if (BUS.BUS_btnNhapHang(txtMaDP.Text, txtSoLuong.Text, txtGiaNhap.Text, txtGiaBan.Text, txtNgay.Text, cbThang.Text, cbNam.Text, lbDVT.Text, sl) == true)
                    {
                        MessageBox.Show("Nhập hàng thành công");
                    }
                    else
                    {
                        MessageBox.Show("Nhập hàng không thành công!\nLỗi kết nối CSDL!");
                        kn.ShowDialog();
                    }
                }
            }
        }

        private void cbThang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtNgay.Text = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
        }

        private void cbNam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtNgay.Text = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
        }

        private void cbNgay_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtNgay.Text = cbNgay.Text + "/" + cbThang.Text + "/" + cbNam.Text;
        }
    }
}
