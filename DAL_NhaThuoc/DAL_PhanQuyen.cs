using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_NhaThuoc
{
    public class DAL_PhanQuyen
    {
        SqlConnection cnn1 = StringSQLConnect.StringSQL();
        SqlDataReader dr;
        public SqlDataReader DAL_GetPhanQuyen(string use)
        {
            if (cnn1.State == System.Data.ConnectionState.Closed)
                cnn1.Open();

            SqlCommand cmd = new SqlCommand("SELECT ThemDP, SuaDP, NhapHang, XuatHang, QlUsers FROM Users Where ID = " + "'" + use + "'", cnn1);
            dr = cmd.ExecuteReader();
            return dr;
        }
        public void DAL_CloseConnect_PhanQuyen()
        {
            dr.Close();
            cnn1.Close();
        }
    }
}
