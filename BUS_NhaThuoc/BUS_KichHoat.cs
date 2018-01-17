using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_NhaThuoc
{
    public class BUS_KichHoat
    {
        DAL_KichHoat DAL = new DAL_KichHoat();
        public bool BUS_Save(DTO_ThongTinDangKy NV, DTO_ThuocTinhUser TT)
        {
            return DAL.DAL_Save(NV, TT);
        }
        public SqlDataReader BUS_Load(string strID)
        {
            return DAL.DAL_Load(strID);
        }
        public DataTable BUS_LoadUsers()
        {
            return DAL.DAL_LoadUsers();
        }
        public bool BUS_XoaYeuCau(string strID)
        {
            return DAL.DAL_XoaYeuCau(strID);
        }
        public void BUS_CloseConnect_Load()
        {
            DAL.DAL_CloseConnect_Load();
        }
    }
}
