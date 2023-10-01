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
    public class DAL_SanBay : DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT * FROM SANBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT MASANBAY[Mã sân bay], TENSANBAY[Tên sân bay], " +
                "TENTHANHPHO[Tên Thành Phố] FROM SANBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_SanBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO SANBAY(MASANBAY, TENSANBAY, TENTHANHPHO) VALUES('{0}', N'{1}', N'{2}')", dto.MaSanBay, dto.TenSanBay, dto.TenThanhPho);
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

        public DataTable SearchOfMaSanBay(string maSanBay)
        {
            string sqlQuery = string.Format("SELECT MASANBAY[Mã sân bay], TENSANBAY[Tên sân bay], " +
                "TENTHANHPHO[Tên Thành Phố] FROM SANBAY WHERE MASANBAY LIKE('%{0}%')", maSanBay);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Update(DTO_SanBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE SANBAY SET TENSANBAY=N'{0}', TENTHANHPHO=N'{1}' WHERE MASANBAY='{2}'", dto.TenSanBay, dto.TenThanhPho, dto.MaSanBay);
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
        public bool Delete(string maSanBay)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM SANBAY WHERE MASANBAY='{0}'", maSanBay);
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
            string sqlQuery = "SELECT MASANBAY[Mã sân bay], TENSANBAY[Tên sân bay], " +
                "TENTHANHPHO[Tên Thành Phố] FROM SANBAY ORDER BY MASANBAY DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool CheckSanBay(string tenSanBay, string tenThanhPho)
        {
            string sqlQuery = string.Format("SELECT * FROM SANBAY WHERE TENSANBAY =N'{0}' AND TENTHANHPHO=N'{1}'", tenSanBay, tenThanhPho);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
    }
}
