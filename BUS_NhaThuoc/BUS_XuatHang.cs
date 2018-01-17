using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class BUS_XuatHang
    {
        DAL_PhanQuyen PhanQuyen = new DAL_PhanQuyen();
        DAL_XuatHang DAL = new DAL_XuatHang();
        public SqlDataReader BUS_GetPhanQuyen(string use)
        {
            return PhanQuyen.DAL_GetPhanQuyen(use);
        }
        public DataTable BUS_GetDanhSachPX_Thang()
        {
            return DAL.DAL_GetDanhSachPX_Thang();
        }
        public DataTable BUS_Get_All_PX()
        {
            return DAL.DAL_Get_All_PX();
        }
        public DataTable BUS_ChiTietPX(int MaPX)
        {
            return DAL.DAL_ChiTietPX(MaPX);
        }
        public DataTable BUS_Load_PX_TrongThang(string cbChonDS)
        {
            return DAL.DAL_Load_PX_TrongThang(cbChonDS);
        }
        public void BUS_CloseConnect_PhanQuyen()
        {
            PhanQuyen.DAL_CloseConnect_PhanQuyen();
        }
        public void BUS_CloseConnect_XuatHang()
        {
            DAL.DAL_CloseConnect_XuatHang();
        }
    }
}
