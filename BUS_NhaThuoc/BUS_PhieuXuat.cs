using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_NhaThuoc
{
    public class BUS_PhieuXuat
    {
        DAL_PhieuXuat DAL = new DAL_PhieuXuat();
        public bool BUS_Drop_SL_DP(string MaDP, string ten, int sl, string lbDVT, string GiaBan, string MaPX)
        {
            return DAL.DAL_Drop_SL_DP(MaDP, ten, sl, lbDVT , GiaBan , MaPX);
        }
        public bool BUS_ThemPhieuXuat(string txtNgay, string cbThang, string cbNam, string txtTenKH, string ID, int TongTien, string txtSoLuong, int SoRow)
        {
            return DAL.DAL_ThemPhieuXuat(txtNgay, cbThang, cbNam, txtTenKH, ID, TongTien, txtSoLuong, SoRow);
        }
        //public bool BUS_ThemChiTietPhieuXuat(string txtTenDP, string lbDVT, string GiaBan, int SoLuong, string MaPX)
        //{
        //    return DAL.DAL_ThemChiTietPhieuXuat(txtTenDP, lbDVT, GiaBan, SoLuong, MaPX);
        //}
        public DataTable BUS_LoadTenDP()
        {
            return DAL.DAL_LoadTenDP();
        }
        public SqlDataReader BUS_LoadThuocTinhDP(string cbTenDP)
        {
            return DAL.DAL_LoadThuocTinhDP(cbTenDP);
        }
        public bool BUS_UpdateTongTien(string TongTien, int MaPX)
        {
            return DAL.DAL_UpdateTongTien(TongTien, MaPX);
        }
        public void BUS_CloseConnect_LoadThuocTinhDP()
        {
            DAL.DAL_CloseConnect_LoadThuocTinhDP();
        }
    }
}
