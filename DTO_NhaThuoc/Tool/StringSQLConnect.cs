using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_NhaThuoc
{
    public class StringSQLConnect
    {
        public static SqlConnection StringSQL()
        {
            string CreateFolder = @"DataBase"; // tạo thư mục DataBase
            if (!System.IO.Directory.Exists(CreateFolder)) // kiểm tra xem có tồn tại hay không
            {
                System.IO.Directory.CreateDirectory(CreateFolder);
            }
            string CreateFileTxt = @"DataBase\\Setting.txt";
            if (!System.IO.File.Exists(CreateFileTxt))
            {
                System.IO.FileStream cr = new System.IO.FileStream(CreateFileTxt, System.IO.FileMode.Create);
                cr.Close();
                cr.Dispose();
            }

            System.IO.StreamReader docFile = new System.IO.StreamReader("DataBase\\Setting.txt");
            string ketnoi = "";
            try
            {
                string con = docFile.ReadLine();
                ketnoi = MaHoaString.Base64ToString(con.Substring(2).ToString());
            }
            catch
            {

            }
            docFile.Close();
            docFile.Dispose();
            SqlConnection cnn = new SqlConnection("Data Source=" + ketnoi);

            //try
            //{
            //    if (cnn.State == System.Data.ConnectionState.Closed)
            //    {
            //        cnn.Open();
            //        return cnn;
            //    }
            //}
            //catch
            //{
                
            //}
            //finally
            //{
            //    cnn.Close();
            //}
            return cnn;
        }
    }
}
