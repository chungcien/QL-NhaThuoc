using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuoc
{
    public class DTO_ThongTinDangKy
    {
        private string ID;
        private string pass;
        private string Name;
        private string chucvu;
        private string email;
        private string sdt;

        
        public string txtDT
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }

        public string txtID
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }
        public string txtpass
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
        }
        public string txtName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public string txtEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string txtChucvu
        {
            get
            {
                return chucvu;
            }
            set
            {
                chucvu = value;
            }
        }
        public DTO_ThongTinDangKy()
        {

        }

        public DTO_ThongTinDangKy(string ID, string pass, string Name, string sdt, string email, string chucvu)
        {
            this.txtID = ID;
            this.txtpass = pass;
            this.txtName = Name;
            this.txtEmail = email;
            this.txtChucvu = chucvu;
            this.txtDT = sdt;
        }
    }
}
