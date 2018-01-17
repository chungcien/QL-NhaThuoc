using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class DAL_XuatHang
    {
        SqlConnection cnn = StringSQLConnect.StringSQL();
        public DataTable DAL_GetDanhSachPX_Thang()  // lấy danh sách phiếu xuất theo tháng cho vào combobox
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ThangNamXuat FROM PhieuXuat GROUP BY ThangNamXuat", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable DAL_Get_All_PX()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaPX, HoTen,TenKH,NgayXuat,TongTien FROM PhieuXuat, Users where PhieuXuat.ID = Users.ID order by PhieuXuat.MaPX DESC ", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        SqlConnection cn;
        public DataTable DAL_ChiTietPX(int MaPX)
        {
            cn = StringSQLConnect.StringSQL();
            DataTable dt = new DataTable();

            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DanhMucDP.TenDP, ChiTietPhieuXuat.SoLuong, ChiTietPhieuXuat.DVT, ChiTietPhieuXuat.GiaBan, ChiTietPhieuXuat.ThanhTien FROM ChiTietPhieuXuat, DanhMucDP WHERE DanhMucDP.MaDP = ChiTietPhieuXuat.MaDP and MaPX = " + MaPX, cn);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable DAL_Load_PX_TrongThang(string cbChonDS)
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaPX,HoTen, TenKH, NgayXuat, TongTien FROM PhieuXuat, Users WHERE PhieuXuat.ID = Users.ID and ThangNamXuat = " + "'" + cbChonDS + "'", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public void DAL_CloseConnect_XuatHang()
        {
            cn.Close();
        }
    }
}
