using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace QL_NhaThuoc
{
    public class CheckSQLConnect
    {
        public static bool checkConnectSQL()
        {
            SqlConnection conn = StringSQLConnect.StringSQL();
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
