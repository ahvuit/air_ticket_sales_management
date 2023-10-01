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
    public class DAL_HangVe : DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT * FROM HANGVE ";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT MAHANGVE[Mã hạng vé], TENHANGVE[Tên hạng vé], LEPHIHOAN[Lệ phí hoàn], LEPHIDOI[Lệ phí đổi] FROM HANGVE ";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_HangVe dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO HANGVE(MAHANGVE, TENHANGVE, LEPHIHOAN, LEPHIDOI) VALUES('{0}', N'{1}','{2}','{3}')", dto.MaHangVe, dto.TenHangVe,dto.LephiHoan,dto.LephiDoi);
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
        public bool Update(DTO_HangVe dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE HANGVE SET TENHANGVE=N'{0}' WHERE MAHANGVE='{1}'", dto.TenHangVe, dto.MaHangVe);
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
                string sqlQuery = string.Format("DELETE FROM HANGVE WHERE MAHANGVE='{0}'", str);
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
            string sqlQuery = "SELECT * FROM HANGVE ORDER BY MAHANGVE DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchOfMaHangVe(string str)
        {
            string sqlQuery = string.Format("SELECT MAHANGVE[Mã hạng vé], TENHANGVE[Tên hạng vé],LEPHIHOAN[Lệ phí hoàn], LEPHIDOI[Lệ phí đổi] FROM HANGVE " +
                "WHERE MAHANGVE LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchOfLePhi(string str)
        {
            string sqlQuery = string.Format("SELECT LEPHIHOAN, LEPHIDOI FROM HANGVE WHERE TENHANGVE = N'{0}'",str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
