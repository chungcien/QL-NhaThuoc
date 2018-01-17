using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class BUS_QLUsers
    {
        DAL_QLUsers DAL = new DAL_QLUsers();
        public DataTable BUS_LoadID()   //load ID vào commboBox
        {
            return DAL.DAL_LoadID();
        }
        public SqlDataReader BUS_KiemTraBangDangKy()    // kiểm tra xem bảng đăng ký có đăng ký mới hay không
        {
            return DAL.DAL_KiemTraBangDangKy();
        }
        public SqlDataReader BUS_GetThuocTinhUser(string strID)
        {
            return DAL.DAL_GetThuocTinhUser(strID);
        }
        public bool BUS_DelUser(string strID)
        {
            return DAL.DAL_DelUser(strID);
        }
        public bool BUS_UpdateThuocTinhUser(string cbChucVu, string Check_ThemDP, string Check_SuaDP, string Check_Nhap, string Check_Xuat, string Check_QL, string strID)
        {
            return DAL.DAL_UpdateThuocTinhUser(cbChucVu, Check_ThemDP, Check_SuaDP, Check_Nhap, Check_Xuat, Check_QL, strID);
        }
        public void BUS_CloseConnect_QlUser()
        {
            DAL.DAL_CloseConnect_QlUser();
        }
    }
}
