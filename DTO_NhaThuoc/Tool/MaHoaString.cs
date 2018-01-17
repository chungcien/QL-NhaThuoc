using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QL_NhaThuoc
{
    public class MaHoaString
    {
        public static string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("x2");//Nếu là "X2" thì kết quả sẽ tự chuyển sang ký tự in Hoa
            }

            return str_md5;
        }


        // Giải mã một chuỗi Unicode được mã hóa theo Base64.
        public static string Base64ToString(string src)
        {
            // Giải mã vào mảng kiểu byte.
            byte[] b = Convert.FromBase64String(src);
            // Trả về chuỗi Unicode.
            return Encoding.Unicode.GetString(b);
        }
        // Mã hóa Base64 với chuỗi Unicode.
        public static string StringToBase64(string src)
        {
            // Chuyển chuỗi thành mảng kiểu byte.
            byte[] b = Encoding.Unicode.GetBytes(src);
            // Trả về chuỗi được mã hóa theo Base64.
            return Convert.ToBase64String(b);
        }
    }
}
