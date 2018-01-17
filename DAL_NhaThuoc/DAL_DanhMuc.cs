using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class DAL_DanhMuc
    {
        SqlConnection cnn = StringSQLConnect.StringSQL();
        SqlConnection cn;
        public DataTable DAL_LoadDataBase(string btnClick)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            if (btnClick == "SapHet")    // tham số truyền vào là sắp hết thì load danh mục thuốc sắp hết trong kho
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DanhMucDP WHERE SoLuong <= 15 ", cnn);
                da.Fill(dt);
                    
            }
            else if (btnClick == "All") // load tất cả danh mục thuốc
            {
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM DanhMucDP", cnn);
                da2.Fill(dt);    
            }
            cnn.Close();
            return dt;
        }

        public bool DAL_ThemDP(DTO_DP DP)
        {
            try
            {
                cnn.Open();
                string commandText2 = "insert into DanhMucDP (TenDP, NhaSanXuat, DVT, SoLuong, GiaNhap, GiaBan) values (@TenDP, @NhaSanXuat, @DVT, @SoLuong, @GiaNhap, @GiaBan)";

                SqlCommand sqlCommand2 = new SqlCommand(commandText2, cnn);

                sqlCommand2.Parameters.AddWithValue("@TenDP", DP.txtTenDP);
                sqlCommand2.Parameters.AddWithValue("@NhaSanXuat", DP.txtNhaSanXuat);
                sqlCommand2.Parameters.AddWithValue("@DVT", DP.cbDVT);
                sqlCommand2.Parameters.AddWithValue("@SoLuong", "0");
                sqlCommand2.Parameters.AddWithValue("@GiaNhap", DP.txtGiaNhap);
                sqlCommand2.Parameters.AddWithValue("@GiaBan", DP.txtGiaBan);
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

        public bool DAL_SuaDP(DTO_DP DP, int id)
        {
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE DanhMucDP Set TenDP = N'" + DP.txtTenDP + "', NhaSanXuat = N'" + DP.txtNhaSanXuat
                + "', DVT = N'" + DP.cbDVT + "', GiaNhap = N'" + DP.txtGiaNhap + "', GiaBan = N'" + DP.txtGiaBan + "'WHERE MaDP = " + id, cnn);
                if (cmd.ExecuteNonQuery() > 0)
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
        public SqlDataReader DAL_GetTenDP(string TenDP)
        {
            cn = StringSQLConnect.StringSQL();
            SqlDataReader dr = null;
            cn.Open();
            SqlCommand cmd = new SqlCommand("select TenDP from DanhMucDP where TenDP = N'" + TenDP + "'", cn);
            dr = cmd.ExecuteReader();

            return dr;
        }
        public void DAL_CloseConnect_DanhMuc()
        {
            cn.Close();
        }
    }
}
