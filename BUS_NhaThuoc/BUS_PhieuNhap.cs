using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class BUS_PhieuNhap
    {
        DAL_PhieuNhap DAL = new DAL_PhieuNhap();
        public DataTable BUS_LoadDP()
        {
            return DAL.DAL_LoadDP();
        }
        public bool BUS_btnNhapHang(string txtMaDP, string txtSoLuong, string txtGiaNhap, string txtGiaBan, string txtNgay, string cbThang, string cbNam, string lbDVT, int sl)
        {
            return DAL.DAL_btnNhapHang(txtMaDP,txtSoLuong,txtGiaNhap,txtGiaBan,txtNgay,cbThang,cbNam,lbDVT,sl);
        }
    }
}
