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
    public partial class frNhapHang : Form
    {
        public frNhapHang()
        {
            InitializeComponent();
        }
        SqlConnection cnn = StringSQLConnect.StringSQL();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        BUS_NhapHang BUS = new BUS_NhapHang();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = BUS.BUS_GetPhanQuyen(MainForm.use);
                if (dr.Read())
                {
                    if (dr[2].ToString() == "1")
                    {
                        if (button1.Text == "Quay lại")
                        {
                            button1.Text = "Thêm Phiếu Nhập Mới";
                            panel1.Controls.Clear();
                            panel1.Controls.Add(dataGridView1);
                            dataGridView1.Show();
                            comboBox1.Show();
                            label1.Show();

                            // khi ấn quay lại thì load lại database
                            LoadDatabase();
                        }
                        else if (button1.Text == "Thêm Phiếu Nhập Mới")
                        {
                            button1.Text = "Quay lại";
                            comboBox1.Hide();
                            label1.Hide();
                            frPhieuNhap pn = new frPhieuNhap();
                            panel1.Controls.Clear();
                            pn.TopLevel = false;
                            panel1.Controls.Add(pn);
                            pn.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!\nLiên hệ với Admin để biết thêm chi tiết.", "Thông báo");
                    } 
                }
                dr.Close();
                BUS.DAL_Close_Connect();
            }
            catch(Exception a)
            {
                MessageBox.Show("Lỗi kết nối CSDL!" +a.ToString());
                kn.ShowDialog();
            }
            
        }

        private void frNhapHang_Load(object sender, EventArgs e)
        {
            LoadDatabase();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = BUS.BUS_GetDPTheoThang(comboBox1.Text);
                dataGridView1.DataSource = bs;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }

        private void LoadDatabase()
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = BUS.BUS_GetThangNamNhap();
                comboBox1.DataSource = bs;
                comboBox1.DisplayMember = "ThangNamNhap";

                BindingSource bs1 = new BindingSource();
                bs1.DataSource = BUS.BUS_GetDuocPham();
                dataGridView1.DataSource = bs1;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                kn.ShowDialog();
            }
        }
    }
}
