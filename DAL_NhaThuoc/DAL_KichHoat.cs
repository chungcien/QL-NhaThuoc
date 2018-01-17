using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class DAL_KichHoat
    {
        SqlConnection cnn = StringSQLConnect.StringSQL();
        public bool DAL_Save(DTO_ThongTinDangKy NV, DTO_ThuocTinhUser TT)
        {
            try
            {
                cnn.Open();
                string add_new = "insert into Users (ID, pass, HoTen, SDT, Email, ChucVu, ThemDP, SuaDP, NhapHang, XuatHang, QlUsers ) values (@ID, @Pass, @Ten, @SDT, @Email, @ChucVu, @ThemDP, @SuaDP, @NhapHang, @XuatHang, @QL)";
                SqlCommand add = new SqlCommand(add_new, cnn);

                add.Parameters.AddWithValue("@ID", NV.txtID);
                add.Parameters.AddWithValue("@Pass", NV.txtpass);
                add.Parameters.AddWithValue("@SDT", NV.txtName);
                add.Parameters.AddWithValue("@Ten", NV.txtDT);
                add.Parameters.AddWithValue("@Email", NV.txtEmail);
                add.Parameters.AddWithValue("@ChucVu", NV.txtChucvu);
                add.Parameters.AddWithValue("@ThemDP", TT.Check_ThemDP);
                add.Parameters.AddWithValue("@SuaDP", TT.Check_SuaDP);
                add.Parameters.AddWithValue("@NhapHang", TT.Check_Nhap);
                add.Parameters.AddWithValue("@XuatHang", TT.Check_Xuat);
                add.Parameters.AddWithValue("@QL", TT.Check_QL);
                if (add.ExecuteNonQuery() > 0 && DAL_Xoa(NV.txtID) == true)
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


        // xóa user đã kiểm duyệt trong bảng DangKy
        public bool DAL_Xoa(string cbUsers)
        {
            SqlConnection cn = StringSQLConnect.StringSQL();
            try
            {
                cn.Open();
                string del = "Delete from DangKy Where ID = " + "'" + cbUsers + "'";
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
                cn.Close();
            }
  
        }

        SqlConnection cne;
        public SqlDataReader DAL_Load(string strID)
        {
            cne = StringSQLConnect.StringSQL();
            cne.Open();
            SqlCommand cmd = new SqlCommand("SELECT HoTen, SDT, Email, ChucVu, pass From DangKy Where ID = " + "'" + strID + "'", cne);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public DataTable DAL_LoadUsers()
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID FROM DangKy", cnn);
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //xóa yêu cầu kiểm duyệt
        public bool DAL_XoaYeuCau(string strID)
        {
            try
            {
                cnn.Open();
                string del = "Delete from DangKy Where ID = " + "'" + strID + "'";
                SqlCommand delete = new SqlCommand(del, cnn);
                if(delete.ExecuteNonQuery() > 0)
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
        public void DAL_CloseConnect_Load()
        {
            cne.Close();
        }
    }
}
