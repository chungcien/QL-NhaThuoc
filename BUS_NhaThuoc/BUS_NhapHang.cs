using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class BUS_NhapHang
    {
        DAL_PhanQuyen DAL_PhanQuyen = new DAL_PhanQuyen();
        DAL_NhapHang DAL = new DAL_NhapHang();
        public SqlDataReader BUS_GetPhanQuyen(string use)
        {
            return DAL_PhanQuyen.DAL_GetPhanQuyen(use);
        }
        public DataTable BUS_GetThangNamNhap()
        {
            return DAL.DAL_GetThangNamNhap();
        }
        public DataTable BUS_GetDPTheoThang(string cbBox)
        {
            return DAL.DAL_GetDPTheoThang(cbBox);
        }
        public DataTable BUS_GetDuocPham()
        {
            return DAL.DAL_GetDuocPham();
        }
        public void DAL_Close_Connect()
        {
             DAL_PhanQuyen.DAL_CloseConnect_PhanQuyen();
        }
    }
}
