using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_NhaThuoc
{
    public class DAL_SuaThongTin
    {
        SqlConnection cnn = StringSQLConnect.StringSQL();
        SqlConnection cn;
        public bool DAL_ChangePass(string strID, string pass)
        {
            try
            {
                cnn.Open();
                string updateuser = "UPDATE Users set pass = '" + pass + "' Where ID = '" + strID + "'";
                SqlCommand cmd = new SqlCommand(updateuser, cnn);
                if (cmd.ExecuteNonQuery() > 0)
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
        public SqlDataReader DAL_GetPass(string strID)
        {
            cn = StringSQLConnect.StringSQL();
            SqlDataReader dr = null;

            cn.Open();
            SqlCommand cmd = new SqlCommand("select pass from Users where ID = '" + strID + "'", cn);
            dr = cmd.ExecuteReader();

            return dr;
        }
        public SqlDataReader DAL_GetThuocTinhUser(string strID)
        {
            cn = StringSQLConnect.StringSQL();
            SqlDataReader dr = null;

            cn.Open();
            SqlCommand cmd = new SqlCommand("select HoTen,SDT,Email,ChucVu,pass from Users where ID = '" + strID + "'", cn);
            dr = cmd.ExecuteReader();

            return dr;
        }
        public bool DAL_UpdateUser(string strID, string HoTen, string SDT)
        {
            try
            {
                cnn.Open();
                string updateuser = "UPDATE Users set HoTen = N'" + HoTen
                        + "', SDT = '" + SDT
                        //+ "', Email = " + "'" + Email
                        //+ "', NhapHang = " + "'" + Check_Nhap
                        //+ "', XuatHang = " + "'" + Check_Xuat
                        //+ "', QlUsers = " + "'" + Check_QL
                        + "' Where ID = '" + strID + "'";

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
        public void DAL_CloseConnect_SuaThongTin()
        {
            cn.Close();
        }
    }
}
