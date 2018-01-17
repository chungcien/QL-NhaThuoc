using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class DAL_QLUsers
    {
        SqlConnection cnn = StringSQLConnect.StringSQL();
        SqlConnection cn;
        public DataTable DAL_LoadID()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID FROM Users", cnn);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public SqlDataReader DAL_KiemTraBangDangKy()
        {
            cn = StringSQLConnect.StringSQL();
            SqlDataReader dr = null;
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DangKy", cn);
            dr = cmd.ExecuteReader();

            return dr;
        }
        public SqlDataReader DAL_GetThuocTinhUser(string strID)
        {
            cn = StringSQLConnect.StringSQL();
            SqlDataReader dr = null;
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT HoTen, SDT, Email, ChucVu, ThemDP, SuaDP, NhapHang, XuatHang, QlUsers, pass From Users Where ID = " + "'" + strID + "'", cn);
            dr = cmd.ExecuteReader();

            return dr;
        }
        public bool DAL_DelUser(string strID)
        {
            try
            {
                cnn.Open();
                string del = "Delete from Users Where ID = " + "'" + strID + "'";
                SqlCommand delete = new SqlCommand(del, cnn);
                if (delete.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
        public bool DAL_UpdateThuocTinhUser(string cbChucVu, string Check_ThemDP, string Check_SuaDP, string Check_Nhap, string Check_Xuat, string Check_QL, string strID)
        {
            try
            {
                cnn.Open();
                string updateuser = "UPDATE Users set ChucVu = N'" + cbChucVu
                        + "', ThemDP = " + "'" + Check_ThemDP
                        + "', SuaDP = " + "'" + Check_SuaDP
                        + "', NhapHang = " + "'" + Check_Nhap
                        + "', XuatHang = " + "'" + Check_Xuat
                        + "', QlUsers = " + "'" + Check_QL + "'"
                        + "Where ID = " + "'" + strID + "'";

                SqlCommand update_user = new SqlCommand(updateuser, cnn);
                if (update_user.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
        public void DAL_CloseConnect_QlUser()
        {
            cn.Close();
        }
    }
}
