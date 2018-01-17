using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuoc
{
    public class BUS_DangKy
    {
        DAL_DangKy DAL = new DAL_DangKy();
        public bool Bus_btnDangKy(DTO_ThongTinDangKy TV)
        {
           return DAL.Dal_btnDangKy(TV);
        }
        public bool Bus_TextChange(string tv, string select)
        {
            return DAL.Dal_TextChange(tv,select);
        }
    }
}
