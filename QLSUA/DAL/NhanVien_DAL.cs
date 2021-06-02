using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;

namespace DAL
{
    public class NhanVien_DAL

    {
        static SqlConnection con;
        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = "select *from nhanvien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Id = dt.Rows[i]["id"].ToString();
                nv.Hoten = dt.Rows[i]["hoten"].ToString();
                nv.Gioitinh = dt.Rows[i]["gioitinh"].ToString();
                nv.Dtngaysinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.Cmnd = dt.Rows[i]["cmnd"].ToString();
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Tencv = dt.Rows[i]["tencv"].ToString();
               


                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }



        public static bool ThemNhanVien(string ID, string HoTen, string GioiTinh,String NgaySinh,string SoCMND, string DiaChi, string SoDT,string tencv)

        {
            SqlConnection con;
            string sTruyVan =" INSERT INTO nhanvien VALUES(N'"+ID+"', N'"+HoTen+"', N'"+GioiTinh+"', N'"+NgaySinh+"', '"+SoCMND+"', N'"+DiaChi+"', '"+SoDT+"', N'"+ tencv + "')";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNhanVien(string ID)
        {
            string sTruyVan = string.Format(@"delete FROM nhanvien WHERE ID=N'{0}'", ID);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        //sửa
        public static bool SuaNhanVien(NhanVien_DTO nv)

        {
            SqlConnection con;
            string sTruyVan = string.Format(@"UPDATE nhanvien SET hoten = N'{1}', gioitinh = N'{2}', ngaysinh = '{3}', cmnd = '{4}', diachi = N'{5}', sdt = N'{6}'WHERE ID = N'{0}'",nv.Id,nv.Hoten,nv.Gioitinh,nv.Dtngaysinh,nv.Cmnd,nv.Diachi,nv.Sdt);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
           
            return kq;
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string id)
        {
            SqlConnection con;
            string sTruyVan = string.Format(@"select * from nhanvien where id=N'{0}'", id);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
                return null;

            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Id = dt.Rows[0]["id"].ToString();
            nv.Hoten = dt.Rows[0]["hoten"].ToString();
            nv.Gioitinh = dt.Rows[0]["gioitinh"].ToString();
            nv.Dtngaysinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.Cmnd = dt.Rows[0]["cmnd"].ToString();
            nv.Sdt = dt.Rows[0]["sdt"].ToString();
            nv.Diachi = dt.Rows[0]["diachi"].ToString();

            DataProvider.DongKetNoi(con);
            return nv;
        }
        
    }
    
}
