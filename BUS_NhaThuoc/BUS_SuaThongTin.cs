using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_NhaThuoc
{
    public class BUS_SuaThongTin
    {
        DAL_SuaThongTin DAL = new DAL_SuaThongTin();
        public bool BUS_ChangePass(string strID, string pass)
        {
            return DAL.DAL_ChangePass(strID, pass);
        }
        public SqlDataReader BUS_GetPass(string strID)
        {
            return DAL.DAL_GetPass(strID);
        }
        public SqlDataReader BUS_GetThuocTinhUser(string strID)
        {
            return DAL.DAL_GetThuocTinhUser(strID);
        }
        public bool BUS_UpdateUser(string strID, string HoTen, string SDT)
        {
            return DAL.DAL_UpdateUser(strID, HoTen, SDT);
        }
        public void BUS_CloseConnect_SuaThongTin()
        {
            DAL.DAL_CloseConnect_SuaThongTin();
        }
    }
}
