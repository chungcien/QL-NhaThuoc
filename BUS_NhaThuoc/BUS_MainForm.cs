using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class BUS_MainForm
    {
        DAL_PhanQuyen PhanQuyen = new DAL_PhanQuyen();
        DAL_MainForm DAL = new DAL_MainForm();
        public SqlDataReader BUS_GetPhanQuyen(string use)
        {
            return PhanQuyen.DAL_GetPhanQuyen(use);
        }
        public SqlDataReader BUS_DangNhap(string txtUser)
        {
            return DAL.DAL_DangNhap(txtUser);
        }
        public SqlDataReader BUS_CheckDangKy()
        {
            return DAL.DAL_CheckDangKy();
        }
        public void BUS_CloseConnect_PhanQuyen()
        {
            PhanQuyen.DAL_CloseConnect_PhanQuyen();
        }
        public void BUS_Close_Connect_MainForm()
        {
            DAL.DAL_Close_Connect_MainForm();
        }
    }
}
