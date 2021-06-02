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
    public class SanPham_DAL
    {
        static SqlConnection con;

        public static List<SanPham_DTO> LaySanPham()
        {
            string sTruyVan = "select n.*, c.tenloai   from sanpham n, loaisp c   where n.idLoaisp=c.maloai ";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaPn = int.Parse(dt.Rows[i]["ID"].ToString());
                sp.Masp = dt.Rows[i]["masp"].ToString();
                sp.Tensp = dt.Rows[i]["tensp"].ToString();
                sp.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                sp.Dongiaban = int.Parse(dt.Rows[i]["dongiaban"].ToString());
                sp.Idloaisp = dt.Rows[i]["idloaisp"].ToString();
                sp.Tenloai = dt.Rows[i]["tenloai"].ToString();



                lstSanPham.Add(sp);
            }
            return lstSanPham;
        }

        public static List<SanPham_DTO> LaySanPhamTrongPhieuNhap(int maPhieuNhap)
        {
            string sTruyVan = $"select n.*, c.tenloai from sanpham n, loaisp c   where n.idLoaisp=c.maloai and n.ID = {maPhieuNhap}";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaPn = int.Parse(dt.Rows[i]["ID"].ToString());
                sp.Masp = dt.Rows[i]["masp"].ToString();
                sp.Tensp = dt.Rows[i]["tensp"].ToString();
                sp.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                sp.Dongiaban = int.Parse(dt.Rows[i]["dongiaban"].ToString());
                sp.Idloaisp = dt.Rows[i]["idloaisp"].ToString();
                sp.Tenloai = dt.Rows[i]["tenloai"].ToString();



                lstSanPham.Add(sp);
            }
            return lstSanPham;
        }

        public static bool ThemSP(int id, string masp, string tensp, int soluong, int dongiaban, string idloaisp)
        {

            string sTruyVan = " insert into sanpham values(" + id + ", '" + masp + "', N'" + tensp + "', " + soluong + ", " + dongiaban + ", '" + idloaisp + "')";

            SqlConnection con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            return kq;
        }
        //public static bool SuaSP(string ID, string tensp, string soluong, string dongiaban, string IDloaisp)

        //{
        //    SqlConnection con;
        //    string sTruyVan = string.Format("UPDATE sanpham SET tensp=N'" + tensp + "',soluong='" + soluong + "',dongiaban='" + dongiaban + "',IDloaisp='" + IDloaisp + "',WHERE ID='" + ID + "'");
        //    con = DataProvider.MoKetNoi();
        //    bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
        //    DataProvider.DongKetNoi(con);
        //    return kq;
        //}


        public static bool SuaSanPham(SanPham_DTO sp)

        {
            SqlConnection con;
            string sTruyVan = string.Format(@"UPDATE sanpham SET   ID = '{1}', tensp = N'{2} ', soluong = '{3}', dongiaban = '{4}'WHERE masp = '{0}'", sp.Masp, sp.MaPn, sp.Tensp, sp.Soluong, sp.Dongiaban);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            return kq;
        }
        public static bool XoaSanPham(SanPham_DTO sp)
        {
            string sTruyVan = string.Format(@"delete from sanpham where masp=N'{0}'", sp.Masp);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<SanPham_DTO> TimSPTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from sanpham where tensp like '%{0}'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SanPham_DTO sp = new SanPham_DTO();
                sp.MaPn = int.Parse(dt.Rows[i]["ID"].ToString());
                sp.Masp = dt.Rows[i]["masp"].ToString();
                sp.Tensp = dt.Rows[i]["tensp"].ToString();
                sp.Soluong = int.Parse(dt.Rows[i]["soluong"].ToString());
                sp.Dongiaban = int.Parse(dt.Rows[i]["dongiaban"].ToString());
                sp.Idloaisp = dt.Rows[i]["idloaisp"].ToString();
                /*sp.Tenloai = dt.Rows[i]["idLoaisp"].ToString();*/



                lstSanPham.Add(sp);
            }
            return lstSanPham;

        }
    }
}