using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
   public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LayNhanVien()
        {
            return NhanVien_DAL.LayNhanVien();
        }
        public static bool ThemNhanVien(string ID, string HoTen, string GioiTinh, String NgaySinh, string SoCMND, string DiaChi, string SoDT,string Macv)
        {
            return NhanVien_DAL.ThemNhanVien(ID, HoTen, GioiTinh, NgaySinh, SoCMND, DiaChi, SoDT, Macv);
        }

        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAL.SuaNhanVien(nv);
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string id)
        {
            return NhanVien_DAL.TimNhanVienTheoMa(id);
        }
        public static bool XoaNhanVien(string id)
        {
            return NhanVien_DAL.XoaNhanVien(id);
        }

       
    }
}
