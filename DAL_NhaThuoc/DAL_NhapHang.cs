using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_NhaThuoc
{
    public class DAL_NhapHang
    {
        SqlConnection cnn = StringSQLConnect.StringSQL();
        public DataTable DAL_GetDPTheoThang(string cbBox)
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT PhieuNhap.MaPhieuNhap, DanhMucDP.TenDP, PhieuNhap.NgayNhap, PhieuNhap.SoLuong, PhieuNhap.DVT FROM PhieuNhap, DanhMucDP WHERE DanhMucDP.MaDP = PhieuNhap.MaDP and ThangNamNhap = " + "'" + cbBox + "'", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable DAL_GetThangNamNhap()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ThangNamNhap FROM PhieuNhap GROUP BY ThangNamNhap", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable DAL_GetDuocPham()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT PhieuNhap.MaPhieuNhap, DanhMucDP.TenDP, PhieuNhap.NgayNhap, PhieuNhap.SoLuong, PhieuNhap.DVT FROM PhieuNhap, DanhMucDP  where DanhMucDP.MaDP = PhieuNhap.MaDP order by MaPhieuNhap DESC", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
