
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class DAL_PhieuNhap
    {
        SqlConnection cnn = StringSQLConnect.StringSQL();
        public DataTable DAL_LoadDP()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaDP,TenDP,NhaSanXuat,SoLuong, DVT,GiaNhap,GiaBan FROM DanhMucDP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool DAL_btnNhapHang(string txtMaDP, string txtSoLuong, string txtGiaNhap, string txtGiaBan, string txtNgay, string cbThang, string cbNam, string lbDVT, int sl)
        {
            try
            {
                cnn.Open();
                int id = Convert.ToInt16(txtMaDP);
                sl = sl + Convert.ToInt16(txtSoLuong);
                SqlCommand cmd = new SqlCommand("UPDATE DanhMucDP Set SoLuong = N'" + sl
                        + "', GiaNhap = N'" + txtGiaNhap + "', GiaBan = N'" + txtGiaBan + "'WHERE MaDP = " + id, cnn);
                cmd.ExecuteNonQuery();


                string commandText2 = "insert into PhieuNhap (MaDP, NgayNhap, ThangNamNhap, SoLuong, DVT) values ( @MaDP, @NgayNhap, @ThangNamNhap, @SoLuong, @DVT)";

                SqlCommand sqlCommand2 = new SqlCommand(commandText2, cnn);

                //sqlCommand2.Parameters.AddWithValue("@MaDP", txtMaDP);
                sqlCommand2.Parameters.AddWithValue("@MaDP", txtMaDP);
                sqlCommand2.Parameters.AddWithValue("@NgayNhap", txtNgay);
                sqlCommand2.Parameters.AddWithValue("@ThangNamNhap", cbThang + "/" + cbNam);
                sqlCommand2.Parameters.AddWithValue("@SoLuong", txtSoLuong);
                sqlCommand2.Parameters.AddWithValue("@DVT", lbDVT);

                if (sqlCommand2.ExecuteNonQuery() > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
