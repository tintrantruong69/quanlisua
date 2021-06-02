using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
   public class SanPham_BUS
    {
        public static List<SanPham_DTO> LaySanPham()
        {
            return SanPham_DAL.LaySanPham();
        }

        public static List<SanPham_DTO> LaySanPhamTrongPhieuNhap(int maPhieuNhap)
        {
            return SanPham_DAL.LaySanPhamTrongPhieuNhap(maPhieuNhap);
        }

        public static bool ThemSP(int id, string masp, string tensp, int soluong, int dongiaban, string idloaisp)
        {
            return SanPham_DAL.ThemSP(id,masp,tensp,soluong,dongiaban,idloaisp);
        }
        //public static bool SuaSP(string ID, string masp, string tensp, string soluong, string dongiaban, string IDloaisp)
        //{
        //    return SanPham_DAL.SuaSP(ID, masp,tensp, soluong, dongiaban, IDloaisp);
        //}
        public static bool SuaSanPham(SanPham_DTO sp)
        {
            return SanPham_DAL.SuaSanPham(sp);
        }
        public static bool XoaSanPham(SanPham_DTO sp)
        {
            return SanPham_DAL.XoaSanPham(sp);
        }
        public static List<SanPham_DTO> TimSPTheoTen(string ten)
        {
            return SanPham_DAL.TimSPTheoTen(ten);
        }
    }
}
