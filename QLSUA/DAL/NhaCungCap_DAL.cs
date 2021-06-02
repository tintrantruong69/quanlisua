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
   public class NhaCungCap_DAL
    {
        static SqlConnection con;
        public static List<NhaCungCap_DTO> LayNCC()
        {
            string sTruyVan = "select * from NhaCungCap";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhaCungCap_DTO> lstNCC = new List<NhaCungCap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCungCap_DTO ncc = new NhaCungCap_DTO();
                ncc.Id = dt.Rows[i]["id"].ToString();
                ncc.Tennhacungcap1 = dt.Rows[i]["tennhacungcap"].ToString();
                ncc.Sdt1 = dt.Rows[i]["sdt"].ToString();
                ncc.Diachi1 = dt.Rows[i]["diachi"].ToString();

                lstNCC.Add(ncc);
            }
            return lstNCC;
        }

        public static bool ThemNCC(string id, string tenncc, string sdt, string diachi)
        {
            string TruyVan = "insert into nhacungcap values(N'" + id + "',N'" + tenncc + "','" + sdt + "',N'" + diachi + "')";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(TruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool SuaNCC(string id, string tenncc, string sdt, string diachi)
        {
            string TruyVan = "update nhacungcap set tennhacungcap=N'"+tenncc+"',sdt='"+sdt+"',diachi=N'"+diachi+"' where ID=N'"+id+"'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(TruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        //TÌM NCC THEO TÊN
        public static List<NhaCungCap_DTO> TimNCCTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"Select * from NhaCungCap where tennhacungcap like N'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhaCungCap_DTO> lstNCC = new List<NhaCungCap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCungCap_DTO ncc = new NhaCungCap_DTO();
                ncc.Id = dt.Rows[i]["id"].ToString();
                ncc.Tennhacungcap1 = dt.Rows[i]["tennhacungcap"].ToString();
                ncc.Sdt1 = dt.Rows[i]["sdt"].ToString();
                ncc.Diachi1 = dt.Rows[i]["diachi"].ToString();

                lstNCC.Add(ncc);
            }
            return lstNCC;
        }

        //TÌM NCC THEO Mã
        public static List<NhaCungCap_DTO> TimNCCTheoID(string id)
        {
            string sTruyVan = string.Format(@"Select * from NhaCungCap where ID like N'%{0}%'", id);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhaCungCap_DTO> lstNCC = new List<NhaCungCap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCungCap_DTO ncc = new NhaCungCap_DTO();
                ncc.Id = dt.Rows[i]["id"].ToString();
                ncc.Tennhacungcap1 = dt.Rows[i]["tennhacungcap"].ToString();
                ncc.Sdt1 = dt.Rows[i]["sdt"].ToString();
                ncc.Diachi1 = dt.Rows[i]["diachi"].ToString();

                lstNCC.Add(ncc);
            }
            return lstNCC;
        }



        public static bool XoaNCC(string ID)
        {
            string sTruyVan = string.Format(@"delete from nhacungcap where ID=N'{0}'", ID);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
    }
}
