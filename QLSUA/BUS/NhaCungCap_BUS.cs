using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class NhaCungCap_BUS
    {
        public static List<NhaCungCap_DTO> LayNCC()
        {
            return NhaCungCap_DAL.LayNCC();
        }
        public static bool ThemNCC(string id, string hoten, string sdt, string diachi)
        {
            return NhaCungCap_DAL.ThemNCC(id, hoten, sdt, diachi);
        }

        public static bool SuaNCC(string id, string hoten, string sdt, string diachi)
        {
            return NhaCungCap_DAL.SuaNCC(id, hoten, sdt, diachi);
        }
        public static bool XoaNCC(string ID)
        {
            return NhaCungCap_DAL.XoaNCC(ID);
        }

        //TÌM NCC THEO TÊN
        public static List<NhaCungCap_DTO> TimNCCTheoTen(string ten)
        {
            return NhaCungCap_DAL.TimNCCTheoTen(ten);
        }
        //TÌM NCC THEO MÃ ID
        public static List<NhaCungCap_DTO> TimNCCTheoID(string id)
        {
            return NhaCungCap_DAL.TimNCCTheoID(id);
        }
    }
}
