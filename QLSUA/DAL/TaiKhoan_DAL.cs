using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class TaiKhoan_DAL
    {
        static SqlConnection con;
        public static List<TaiKhoan_DTO> LayTaiKhoan()
        {
            string sTruyVan = "select n.*, c.tencv from nguoidung n, nhanvien c where n.IDnhanvien=c.ID";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiKhoan_DTO> lsttk = new List<TaiKhoan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
                tk.Manv = dt.Rows[i]["IDnhanvien"].ToString();
                tk.Matkhau = dt.Rows[i]["matkhau"].ToString();
                
                tk.Quyen = Int16.Parse(dt.Rows[i]["quyen"].ToString());
                lsttk.Add(tk);
            }
            return lsttk;
        }
        public static TaiKhoan_DTO LayTaiKhoan(string manv, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from nguoidung where IDnhanvien=N'{0}' and matkhau=N'{1}'", manv, matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.Manv = dt.Rows[0]["IDnhanvien"].ToString();
            tk.Matkhau = dt.Rows[0]["matkhau"].ToString();

            tk.Quyen = Int16.Parse(dt.Rows[0]["quyen"].ToString());
            DataProvider.DongKetNoi(con);
            return tk;
        }
        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"insert into nguoidung values(N'{0}',N'{1}','{2}')", tk.Manv, tk.Matkhau, tk.Quyen);
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool SuaTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"update nguoidung set matkhau=N'{1}',quyen='{2}' where IDnhanvien=N'{0}'", tk.Manv, tk.Matkhau, tk.Quyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool XoaTaiKhoan(TaiKhoan_DTO tk)
        {
            string sTruyVan = string.Format(@"delete from nguoidung where IDnhanvien=N'{0}'", tk.Manv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
    }
}
