using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NhaThuoc
{
    public class DTO_NgayThangNam
    {
        private string Ngay;
        private string Thang;
        private string Nam;


        /* ======== GETTER/SETTER ======== */
        public string txtNgay
        {
            get
            {
                return Ngay;
            }

            set
            {
                Ngay = value;
            }
        }

        public string txtThang
        {
            get
            {
                return Thang;
            }

            set
            {
                Thang = value;
            }
        }

        public string txtNam
        {
            get
            {
                return Nam;
            }

            set
            {
                Nam = value;
            }
        }

        /* === Constructor === */
        public DTO_NgayThangNam()
        {

        }

        public DTO_NgayThangNam(string Ngay, string Thang, string Nam)
        {
            this.txtNgay = Ngay;
            this.txtThang = Thang;
            this.txtNam = Nam;
        }
    }
}

