using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CSDL_DAL
    {
        static SqlConnection con;
        // Backup
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QLSUA(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QLSUA TO DISK = N'" + sDuongDan +
            sTen + "'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
        public static bool PhucHoiDuLieu(string sDuongDan)
        {
            try
            {
                con = DataProvider.MoKetNoi();
                SqlCommand cmd1 = new SqlCommand("ALTER DATABASE QLSUA SET SINGLE_USER WITH ROLLBACK IMMEDIATE ", con);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("USE MASTER RESTORE DATABASE QLSUA FROM DISK='" + sDuongDan + "' WITH REPLACE", con);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("ALTER DATABASE QLSUA SET MULTI_USER", con);
                cmd3.ExecuteNonQuery();
                con.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
