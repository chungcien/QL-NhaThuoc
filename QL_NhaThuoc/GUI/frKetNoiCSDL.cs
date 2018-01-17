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
    public partial class frKetNoiCSDL : Form
    {
        string connect;
        public frKetNoiCSDL()
        {
            InitializeComponent();
            btnConnect.Enabled = false;
            raBtnWindows.Checked = true;
        }

        private void raBtnWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtPass.Enabled = false;
            
        }

        private void raBtnSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(raBtnWindows.Checked == true)
            {

                connect = txtServerName.Text + ";Initial Catalog=" + txtDataBaseName.Text + ";Integrated Security=True";
            }
            else
            {
                connect = txtServerName.Text + ";Initial Catalog="
                        + txtDataBaseName.Text + ";Persist Security Info=True;User ID=" + txtUser.Text + ";Password=" + txtPass.Text;
            }

            SqlConnection conn = new SqlConnection("Data Source= " +  connect);

            try
            {
                conn.Open();
                System.IO.StreamWriter ghi = new System.IO.StreamWriter("DataBase\\Setting.txt");
                ghi.Write("SS" + MaHoaString.StringToBase64(connect));
                ghi.Close();
                ghi.Dispose();
                MessageBox.Show("Kết nối thành công!\nChương trình sẽ khởi động lại trong vài giây!");
                this.Close();
                Application.Restart();
            }
            catch (Exception u)
            {
                MessageBox.Show("Vui lòng kiểm tra lại kết nối\nError: " + u.Message, "Lỗi kết nối đến CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void frKetNoiCSDL_Load(object sender, EventArgs e)
        {
            txtServerName.Focus();
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            if(txtServerName.Text == "")
            {
                btnConnect.Enabled = false;
            }
            else
            {
                btnConnect.Enabled = true;
            }
        }
    }
}
