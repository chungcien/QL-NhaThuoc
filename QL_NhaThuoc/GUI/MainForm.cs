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
using System.Security.Cryptography;


namespace QL_NhaThuoc
{
    public partial class MainForm : Form
    {
        BUS_MainForm BUS = new BUS_MainForm();
        frKetNoiCSDL kn = new frKetNoiCSDL();
        public static string use = "";
        string Check_QlUser = "";
        public int click = 0;
        Timer timer_Run_Info, timer_Check_Connect_DataBase;
        string info = "                           " +
                        "Chào mừng đến với chương trình quản lý nhà thuốc được làm bởi Chung Ciên MMT14"
                        + "                                  ";
        int BienTime = 0;
        public MainForm()
        {
            InitializeComponent();
            timer_Run_Info = new Timer();
            timer_Run_Info.Tick += timer_Run_Info_Tick;
            timer_Run_Info.Interval = 100;

            timer_Check_Connect_DataBase = new Timer();
            timer_Check_Connect_DataBase.Tick += timer_Check_Connect_DataBase_Tick;
            timer_Check_Connect_DataBase.Interval = 100;
        }

        public bool CheckStringSQL()
        {
            if (CheckSQLConnect.checkConnectSQL() == false)
                return false;
            else
                return true;
        }

        private void timer_Run_Info_Tick(object sender, EventArgs e)
        {
            if (BienTime == info.Length - 30)
            {
                BienTime = 1;
                info = "                           " +
                    "Chào mừng đến với chương trình quản lý nhà thuốc được làm bởi Chung Ciên MMT14"
                    + "                                  ";
            }

            label4.Text = info.Substring(BienTime, 30);
            BienTime++;
            Random auto = new Random();
            if (BienTime % 10 == 0)
                label4.ForeColor = Color.FromArgb(auto.Next(255), auto.Next(255), auto.Next(255));
        }



        private void timer_Check_Connect_DataBase_Tick(object sender, EventArgs e)
        {
            if (CheckStringSQL() == false)
            {
                timer_Check_Connect_DataBase.Enabled = false;
                MessageBox.Show("Vui lòng Cập nhật thông tin kết nối CSDL!", "Lỗi kết nối đến CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frKetNoiCSDL kn = new frKetNoiCSDL();
                kn.ShowDialog();
            }
            else
            {
                CheckDangKy();
            }
        }


        private void CheckDangKy()
        {
            try
            {
                SqlDataReader dr3 = BUS.BUS_GetPhanQuyen(use);
                if (dr3.Read())
                {
                    if (dr3[4].ToString() == "1")
                    {
                        Check_QlUser = "1";
                        SqlDataReader dr2 = BUS.BUS_CheckDangKy();
                        if (dr2.Read())
                        {
                            panel3.Show();
                        }
                        else
                        {
                            panel3.Hide();
                        }
                        dr2.Close();
                        BUS.BUS_CheckDangKy().Close();
                        BUS.BUS_Close_Connect_MainForm();
                    }
                    else
                    {
                        Check_QlUser = "0";
                    }
                }
                dr3.Close();
                BUS.BUS_GetPhanQuyen(use).Close();
                BUS.BUS_CloseConnect_PhanQuyen();
            }
            catch(Exception k)
            {
                MessageBox.Show("Lỗi kết nối đến CSDL!" + k.ToString());
                kn.ShowDialog();
            }
            
        }

        private void lbDanhMuc_MouseMove(object sender, MouseEventArgs e)   //sự kiện di chuột vào panel thì đổi màu
        {
            pnDanhMuc.BackColor = Color.DimGray;
            pnNhapHang.BackColor = panel2.BackColor;
            pnXuatHang.BackColor = panel2.BackColor;
            pnXuatToa.BackColor = panel2.BackColor;
            Change_Leave();
        }
        private void lbNhapHang_MouseMove(object sender, MouseEventArgs e)  //sự kiện di chuột vào panel thì đổi màu
        {
            pnNhapHang.BackColor = Color.DimGray;
            pnDanhMuc.BackColor = panel2.BackColor;
            pnXuatHang.BackColor = panel2.BackColor;
            pnXuatToa.BackColor = panel2.BackColor;
            Change_Leave();
        }
        private void lbXuatHang_MouseMove(object sender, MouseEventArgs e)  //sự kiện di chuột vào panel thì đổi màu
        {
            pnXuatHang.BackColor = Color.DimGray;
            pnNhapHang.BackColor = panel2.BackColor;
            pnDanhMuc.BackColor = panel2.BackColor;
            pnXuatToa.BackColor = panel2.BackColor;
            Change_Leave();
        }
        private void lbXuatToa_MouseMove(object sender, MouseEventArgs e)   //sự kiện di chuột vào panel thì đổi màu
        {
            pnXuatToa.BackColor = Color.DimGray;
            pnNhapHang.BackColor = panel2.BackColor;
            pnXuatHang.BackColor = panel2.BackColor;
            pnDanhMuc.BackColor = panel2.BackColor;
            Change_Leave();
        }

        private void pnDanhMuc_MouseLeave(object sender, EventArgs e)   // sự kiện di chuyển chuột ra ngoài panel thì đổi lại như màu nền
        {
            if (pnDanhMuc.BackColor == Color.DimGray)
            {
                pnDanhMuc.BackColor = panel2.BackColor;
            }

        }

        private void pnNhapHang_MouseLeave(object sender, EventArgs e)  // sự kiện di chuyển chuột ra ngoài panel thì đổi lại như màu nền
        {
            if (pnNhapHang.BackColor == Color.DimGray)
            {
                pnNhapHang.BackColor = panel2.BackColor;
            }
        }

        private void pnXuatHang_MouseLeave(object sender, EventArgs e)  // sự kiện di chuyển chuột ra ngoài panel thì đổi lại như màu nền
        {
            if (pnXuatHang.BackColor == Color.DimGray)
            {
                pnXuatHang.BackColor = panel2.BackColor;
            }
        }

        private void pnXuatToa_MouseLeave(object sender, EventArgs e)   // sự kiện di chuyển chuột ra ngoài panel thì đổi lại như màu nền
        {
            if (pnXuatToa.BackColor == Color.DimGray)
            {
                pnXuatToa.BackColor = panel2.BackColor;
            }
        }

        /* khi chuột di chuyển thì các panel sẽ về màu #DimGray cho dù trước đó đã click 
         * và đổi sang màu #DodgerBlue nên hàm này sẽ xác định panel nào đc click và đổi
         * thành màu #DodgerBlue khi chuột di chuyển */
        void Change_Leave()
        {
            if (click == 1)
                ChangeColor(pnDanhMuc);
            else if (click == 2)
                ChangeColor(pnNhapHang);
            else if (click == 3)
                ChangeColor(pnXuatHang);
            else if (click == 4)
                ChangeColor(pnXuatToa);
        }

        void ReChangeColor(Panel a) // hàm đổi màu panel lại giống màu nền
        {
            a.BackColor = panel2.BackColor;
        }
        void ChangeColor(Panel a)   // hàm đổi màu panel
        {
            a.BackColor = Color.DodgerBlue;
        }


        private void pnDanhMuc_MouseDown(object sender, MouseEventArgs e)   // sự kiện click chuột vào panel
        {
            ChangeColor(pnDanhMuc);     // gọi hàm đổi màu của panel đc click vào
            ReChangeColor(pnNhapHang);  // các panel khác màu như màu nền
            ReChangeColor(pnXuatHang);
            ReChangeColor(pnXuatToa);
            pnControls.Controls.Clear();
            frDanhMucThuoc dm = new frDanhMucThuoc();   // gọi form
            dm.TopLevel = false;
            dm.FormBorderStyle = FormBorderStyle.None;
            dm.BackColor = Color.DarkGray;
            pnControls.Controls.Add(dm);
            dm.Show();
            click = 1;
        }

        private void pnNhapHang_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeColor(pnNhapHang);     // gọi hàm đổi màu của panel đc click vào
            ReChangeColor(pnDanhMuc);  // các panel khác màu như màu nền
            ReChangeColor(pnXuatHang);
            ReChangeColor(pnXuatToa);
            pnControls.Controls.Clear();
            frNhapHang dm = new frNhapHang();   // gọi form
            dm.TopLevel = false;
            dm.FormBorderStyle = FormBorderStyle.None;
            dm.BackColor = Color.DarkGray;
            pnControls.Controls.Add(dm);
            dm.Show();
            click = 2;
        }

        private void pnXuatHang_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeColor(pnXuatHang);     // gọi hàm đổi màu của panel đc click vào
            ReChangeColor(pnNhapHang);  // các panel khác màu như màu nền
            ReChangeColor(pnDanhMuc);
            ReChangeColor(pnXuatToa);
            pnControls.Controls.Clear();
            frXuatHang dm = new frXuatHang();   // gọi form
            dm.TopLevel = false;
            dm.FormBorderStyle = FormBorderStyle.None;
            dm.BackColor = Color.DarkGray;
            pnControls.Controls.Add(dm);
            dm.Show();
            click = 3;
        }

        private void pnXuatToa_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeColor(pnXuatToa);     // gọi hàm đổi màu của panel đc click vào
            ReChangeColor(pnNhapHang);  // các panel khác màu như màu nền
            ReChangeColor(pnXuatHang);
            ReChangeColor(pnDanhMuc);
            pnControls.Controls.Clear();


            if (Check_QlUser == "1")
            {
                frQuanLyUser dm = new frQuanLyUser();   // gọi form
                dm.TopLevel = false;
                dm.FormBorderStyle = FormBorderStyle.None;
                dm.BackColor = Color.DarkGray;
                pnControls.Controls.Add(dm);
                dm.Show();
                click = 4;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!\nLiên hệ với Admin để biết thêm chi tiết.", "Thông báo");
            }

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (click == 1)
            {
                frDanhMucThuoc dm = new frDanhMucThuoc();   // gọi form
                dm.TopLevel = false;
                dm.FormBorderStyle = FormBorderStyle.None;
                dm.BackColor = Color.DarkGray;
                pnControls.Controls.Clear();
                pnControls.Controls.Add(dm);
                dm.Show();
            }
            else if (click == 2)
            {
                pnControls.Controls.Clear();
                frNhapHang nh = new frNhapHang();
                nh.TopLevel = false;
                nh.FormBorderStyle = FormBorderStyle.None;
                nh.BackColor = Color.DarkGray;
                pnControls.Controls.Add(nh);
                nh.Show();
            }
            else if (click == 3)
            {
                pnControls.Controls.Clear();
                frXuatHang xh = new frXuatHang();
                xh.TopLevel = false;
                xh.FormBorderStyle = FormBorderStyle.None;
                xh.BackColor = Color.DarkGray;
                pnControls.Controls.Add(xh);
                xh.Show();
            }
            else if (click == 4)
            {
                pnControls.Controls.Clear();
                frQuanLyUser xtt = new frQuanLyUser();
                xtt.TopLevel = false;
                xtt.FormBorderStyle = FormBorderStyle.None;
                xtt.BackColor = Color.DarkGray;
                pnControls.Controls.Add(xtt);
                xtt.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer_Run_Info.Enabled = true;
            //timer_Check_Connect_DataBase.Enabled = true;
            panel2.Hide();
            button1.Hide();
            lbWelcome.Hide();
            txtPass.Focus();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button1, "Đăng xuất");
            panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnControls.Controls.Clear();
            pnControls.Controls.Add(pnLogin);
            panel2.Hide();
            pnLogin.Show();
            txtUser.Text = "";
            txtPass.Text = "";
            lbWelcome.Hide();
            button1.Hide();
            use = "";
            panel3.Hide();

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            btnLogin();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frDangKy dk = new frDangKy();
            dk.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frKichHoatTK dm = new frKichHoatTK();
            pnControls.Controls.Clear();
            dm.TopLevel = false;
            dm.FormBorderStyle = FormBorderStyle.None;
            dm.BackColor = Color.DarkGray;
            pnControls.Controls.Add(dm);
            dm.Show();
            panel3.Hide();
        }

        void btnLogin()
        {

            if (txtPass.Text != "" || txtUser.Text != "")
            {

                try
                {
                    SqlDataReader dr = BUS.BUS_DangNhap(txtUser.Text);
                    if (dr.Read())
                    {
                        if (txtUser.Text == dr[0].ToString() && MaHoaString.GetMD5(MaHoaString.GetMD5(txtPass.Text)) == dr[1].ToString())
                        {
                            MessageBox.Show("Đăng nhập thành công", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panel2.Show();
                            pnLogin.Hide();
                            button1.Show();
                            lbWelcome.Text = txtUser.Text;
                            lbWelcome.Show();
                            use = txtUser.Text;
                            CheckDangKy();
                        }
                        else
                        {
                            MessageBox.Show("Username hoặc Password không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username hoặc Password không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dr.Close();
                    BUS.BUS_DangNhap(txtUser.Text).Close();
                    BUS.BUS_Close_Connect_MainForm();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối CSDL!");
                    kn.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin();
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin();
            }
        }


        private void lbWelcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frSuaThongTin s = new frSuaThongTin();
            s.ShowDialog();
        }
    }
}
