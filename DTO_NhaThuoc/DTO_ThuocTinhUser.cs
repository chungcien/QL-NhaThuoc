using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuoc
{
    public class DTO_ThuocTinhUser
    {
        private string _Check_ThemDP;
        private string _Check_SuaDP;
        private string _Check_Nhap;
        private string _Check_Xuat;
        private string _Check_QL;

        /* ======== GETTER/SETTER ======== */
        public string Check_ThemDP
        {
            get
            {
                return _Check_ThemDP;
            }

            set
            {
                _Check_ThemDP = value;
            }
        }

        public string Check_SuaDP
        {
            get
            {
                return _Check_SuaDP;
            }

            set
            {
                _Check_SuaDP = value;
            }
        }

        public string Check_Nhap
        {
            get
            {
                return _Check_Nhap;
            }

            set
            {
                _Check_Nhap = value;
            }
        }

        public string Check_Xuat
        {
            get
            {
                return _Check_Xuat;
            }

            set
            {
                _Check_Xuat = value;
            }
        }
        public string Check_QL
        {
            get
            {
                return _Check_QL;
            }

            set
            {
                _Check_QL = value;
            }
        }

        /* === Constructor === */
        public DTO_ThuocTinhUser()
        {

        }

        public DTO_ThuocTinhUser(string ThemDP, string SuaDP, string Nhap, string Xuat, string QL)
        {
            this.Check_ThemDP = ThemDP;
            this.Check_SuaDP = SuaDP;
            this.Check_Nhap = Nhap;
            this.Check_Xuat = Xuat;
            this.Check_QL = QL;
        }
    }
}
