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
    public class DAL_MayBay : DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT * FROM MAYBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT MAMAYBAY[Mã máy bay], MAHANGMB[Mã hãng máy bay], " +
                "SOLUONGGHE[Số lượng ghế] FROM MAYBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_MayBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO MAYBAY(MAMAYBAY,MAHNAGMB, SOLUONGGHE) VALUES('{0}', '{1}', '{2}')", dto.MaMayBay, dto.MaHangMB, dto.SoLuongGhe);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public bool Update(DTO_MayBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE MAYBAY SET SOLUONGGHE='{0}' WHERE MAMAYBAY='{1}'",dto.SoLuongGhe, dto.MaMayBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public bool Delete(string str)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM MAYBAY WHERE MAMAYBAY='{0}'", str);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception a)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public DataTable GetAndSortDesc()
        {
            string sqlQuery = "SELECT * FROM MAYBAY ORDER BY MAMAYBAY DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchOfMaMayBay(string str)
        {
            string sqlQuery = string.Format("SELECT MAMAYBAY[Mã máy bay], MAHANGMB[Mã hãng máy bay], " +
                "SOLUONGGHE[Số lượng ghế] FROM MAYBAY WHERE MAMAYBAY LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
