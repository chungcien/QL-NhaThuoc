using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class DAL_PhieuXuat
    {
        SqlConnection cnn = StringSQLConnect.StringSQL();
        public bool DAL_Drop_SL_DP(string MaDP, string ten, int sl, string lbDVT, string GiaBan, string MaPX)
        {
            //try
            //{
                cnn.Open();
                string commandText = "insert into ChiTietPhieuXuat values (N'" + MaPX + "', '" + MaDP + "',N'" + sl + "', N'" + lbDVT + "',N'" + GiaBan + "',N'" + Convert.ToInt32(GiaBan) * sl + "')";
                

                string Updata = "UPDATE DanhMucDP Set SoLuong -= " + sl + " WHERE MaDP = '" + MaDP + "' and SoLuong >=" + sl;
                string ckeck = "select COUNT(*) from DanhMucDP where MaDP = N'" + MaDP + "' and SoLuong >=" + sl;
                SqlCommand cmd3 = new SqlCommand(commandText + "  " + ckeck + "  " + Updata, cnn);

                if (cmd3.ExecuteScalar().ToString() != "0")
                {
                    cnn.Close();
                    return true;
                }
                else
                {
                    cnn.Close();
                    return false;
                }
            //}
            //catch
            //{
            //    return false;
            //}
            //finally
            //{
                //cnn.Close();
            //}
        }
        public bool DAL_ThemPhieuXuat(string txtNgay, string cbThang, string cbNam, string txtTenKH, string ID, int TongTien, string txtSoLuong, int MaPX)
        {
            try
            {
                cnn.Open();
                string commandText2 = "insert into PhieuXuat (MaPX, ID, NgayXuat, ThangNamXuat, TenKH, TongTien) values (@MaPX, @ID, @NgayXuat, @ThangNamXuat, @TenKH, @TongTien)";
                SqlCommand sqlCommand2 = new SqlCommand(commandText2, cnn);
                sqlCommand2.Parameters.AddWithValue("@MaPX", MaPX);
                sqlCommand2.Parameters.AddWithValue("@ID", ID);
                sqlCommand2.Parameters.AddWithValue("@NgayXuat", txtNgay);
                sqlCommand2.Parameters.AddWithValue("@ThangNamXuat", cbThang + "/" + cbNam);
                sqlCommand2.Parameters.AddWithValue("@TenKH", txtTenKH);
                sqlCommand2.Parameters.AddWithValue("@TongTien", TongTien.ToString());


                if (sqlCommand2.ExecuteNonQuery() > 0)
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

        public bool DAL_UpdateTongTien(string TongTien, int MaPX)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                string commandText = "update PhieuXuat set TongTien = N'" + TongTien + "' where MaPX = " + MaPX;
                SqlCommand sqlCommand = new SqlCommand(commandText, cnn);

                if (sqlCommand.ExecuteNonQuery() > 0)
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

        //public bool DAL_ThemChiTietPhieuXuat(string txtTenDP, string lbDVT, string GiaBan, int SoLuong, string MaPX)
        //{
        //    try
        //    {
        //        if(cnn.State == ConnectionState.Closed)
        //        cnn.Open();

        //        string commandText = "insert into ChiTietPhieuXuat values (N'" + MaPX +"', N'" + txtTenDP + "',N'" +SoLuong+"', N'"+ lbDVT + "',N'" + GiaBan + "',N'" + Convert.ToInt16(GiaBan) * SoLuong+"')";
        //        SqlCommand sqlCommand = new SqlCommand(commandText, cnn);

        //        if (sqlCommand.ExecuteNonQuery() > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        cnn.Close();
        //    }
        //}
        public DataTable DAL_LoadTenDP()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaDp, TenDP FROM DanhMucDP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        SqlConnection cn;
        SqlDataReader dr = null;
        public SqlDataReader DAL_LoadThuocTinhDP(string MaDP)
        {
            cn = StringSQLConnect.StringSQL();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DVT,SoLuong,GiaBan FROM DanhMucDP WHERE MaDP = '" + MaDP + "'", cn);
            dr = cmd.ExecuteReader(); 
            return dr;
        }
        public void DAL_CloseConnect_LoadThuocTinhDP()
        {
            cn.Close();
        }
    }
}
