using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace BUS
{
   public class TaiKhoan_BUS
    {
        public static List<TaiKhoan_DTO> LayTaiKhoan()
        {
            return TaiKhoan_DAL.LayTaiKhoan();
        }
        public static TaiKhoan_DTO LayTaiKhoan(string manv, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, matkhau);
            return TaiKhoan_DAL.LayTaiKhoan(manv, matkhau);

        }
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAL.ThemTaiKhoan(tk);
        }
        public static bool SuaTaiKhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAL.SuaTaiKhoan(tk);
        }
        public static bool XoaTaikhoan(TaiKhoan_DTO tk)
        {
            return TaiKhoan_DAL.XoaTaiKhoan(tk);
        }
    }
}
