using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace QL_NhaThuoc
{
    public class DAL_DangKy
    {
        
        public bool Dal_btnDangKy(DTO_ThongTinDangKy TV)
        {
            SqlConnection cnn = StringSQLConnect.StringSQL();

            try
            {
                cnn.Open();
                string stradd = "insert into DangKy (ID, pass, HoTen, SDT, Email, ChucVu) values (N'" + TV.txtID + "', N'" 
                    + MaHoaString.GetMD5(MaHoaString.GetMD5(TV.txtpass)) + "', N'" + TV.txtName + "', N'" + TV.txtDT + "', N'" + TV.txtEmail + "', N'" + TV.txtChucvu + "')";
                SqlCommand add = new SqlCommand(stradd, cnn);

                //add.ExecuteNonQuery();
                if (add.ExecuteNonQuery() > 0)
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

        public bool Dal_TextChange(string text, string Select)
        {
            SqlConnection cnn = StringSQLConnect.StringSQL();
            SqlConnection cnn2 = StringSQLConnect.StringSQL();
            cnn.Open();
            cnn2.Open();
            try
            {
                string SQL, SQL2;
                if(Select == "ID")
                {
                    SQL = "select ID from Users Where ID = " + "N'" + text + "'";
                    SQL2 = "select ID from DangKy Where ID = " + "N'" + text + "'";
                }
                else
                {
                    SQL = "select Email from Users Where Email = " + "N'" + text + "'";
                    SQL2 = "select Email from DangKy Where Email = " + "N'" + text + "'";
                }

                SqlCommand cmd = new SqlCommand(SQL, cnn);
                SqlCommand cmd2 = new SqlCommand(SQL2, cnn2);
                if (cmd.ExecuteReader().Read() || cmd2.ExecuteReader().Read())
                    return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cnn.Close();
            }
            return false;
        }
    }
}
