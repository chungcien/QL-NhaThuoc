using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class BUS_DanhMuc
    {
        DAL_DanhMuc d = new DAL_DanhMuc();
        DAL_PhanQuyen PhanQuyen = new DAL_PhanQuyen();
        public DataTable BUS_LoadDataBase(string btnClick)
        {
            return d.DAL_LoadDataBase(btnClick);
        }
        public SqlDataReader BUS_GetPhanQuyen(string use)
        {
            return PhanQuyen.DAL_GetPhanQuyen(use);
        }
        public bool BUS_ThemDP(DTO_DP DP)
        {
            return d.DAL_ThemDP(DP);
        }
        public bool BUS_SuaDP(DTO_DP DP, int id)
        {
            return d.DAL_SuaDP(DP, id);
        }
        public SqlDataReader BUS_GetTenDP(string TenDP)
        {
            return d.DAL_GetTenDP(TenDP);
        }
        public void BUS_CloseConnect_DanhMuc()
        {
            d.DAL_CloseConnect_DanhMuc();
        }
        public void BUS_CloseConnect_PhanQuyen()
        {
            PhanQuyen.DAL_CloseConnect_PhanQuyen();
        }
    }
}
