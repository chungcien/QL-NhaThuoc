using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaThuoc
{
    public class DTO_DP
    {
        private string TenDP;
        private string NhaSanXuat;
        private string DVT;
        private string GiaNhap;
        private string GiaBan;

        /* ======== GETTER/SETTER ======== */
        public string txtTenDP
        {
            get
            {
                return TenDP;
            }

            set
            {
                TenDP = value;
            }
        }

        public string txtNhaSanXuat
        {
            get
            {
                return NhaSanXuat;
            }

            set
            {
                NhaSanXuat = value;
            }
        }

        public string cbDVT
        {
            get
            {
                return DVT;
            }

            set
            {
                DVT = value;
            }
        }

        public string txtGiaNhap
        {
            get
            {
                return GiaNhap;
            }

            set
            {
                GiaNhap = value;
            }
        }
        public string txtGiaBan
        {
            get
            {
                return GiaBan;
            }

            set
            {
                GiaBan = value;
            }
        }

        /* === Constructor === */
        public DTO_DP()
        {

        }

        public DTO_DP(string Ten, string NhaSanXuat, string DVT, string GiaNhap, string GiaBan)
        {
            this.txtTenDP = Ten;
            this.txtNhaSanXuat = NhaSanXuat;
            this.cbDVT = DVT;
            this.txtGiaNhap = GiaNhap;
            this.txtGiaBan = GiaBan;
        }
    }
}
