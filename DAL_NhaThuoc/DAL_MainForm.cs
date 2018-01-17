using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class DAL_MainForm
    {
        SqlConnection cn;
        
        public SqlDataReader DAL_DangNhap(string txtUser)
        {
            SqlDataReader dr = null;
            cn = StringSQLConnect.StringSQL();

            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, Pass FROM Users WHERE ID = " + "'" + txtUser + "'", cn);
            dr = cmd.ExecuteReader();

            return dr;
        }
        public SqlDataReader DAL_CheckDangKy()
        {
            SqlDataReader dr = null;
            cn = StringSQLConnect.StringSQL();

            if (cn.State == ConnectionState.Closed)
                cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DangKy", cn);
            dr = cmd.ExecuteReader();
            return dr;
        }
        public void DAL_Close_Connect_MainForm()
        {
            cn.Close();
        }
    }
}
