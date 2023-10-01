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
    public class DAL_TuyenBay : DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT * FROM TUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT MATUYENBAY[Mã tuyến bay], MASANBAYDI[Mã sân bay đi], " +
                "MASANBAYDEN[Mã sân bay đến] FROM TUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetForDSTuyenBay()
        {
            string sqlQuery = "SELECT T.MATUYENBAY[Mã tuyến bay], S1.TENSANBAY[Tên sân bay đi], " +
                "S2.TENSANBAY[Tên sân bay đến] FROM TUYENBAY T " +
                "INNER JOIN SANBAY S1 ON T.MASANBAYDI=S1.MASANBAY " +
                "INNER JOIN SANBAY S2 ON T.MASANBAYDEN = S2.MASANBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool Add(DTO_TuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("INSERT INTO TUYENBAY(MATUYENBAY, MASANBAYDI," +
                    " MASANBAYDEN) VALUES('{0}', '{1}', '{2}')",
                    dto.MaTuyenBay, dto.MaSanBayDi, dto.MaSanBayDen);
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

        public bool Update(DTO_TuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE TUYENBAY SET MASANBAYDI='{0}', " +
                    "MASANBAYDEN='{1}' WHERE MATUYENBAY='{2}'",
                    dto.MaSanBayDi, dto.MaSanBayDen, dto.MaTuyenBay);
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
                string sqlQuery = string.Format("DELETE FROM TUYENBAY WHERE MATUYENBAY='{0}'",
                    str);
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
            string sqlQuery = "SELECT * FROM TUYENBAY ORDER BY MATUYENBAY DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchOfMaTuyenBay(string str)
        {
            string sqlQuery = string.Format("SELECT T.MATUYENBAY[Mã tuyến bay], S1.TENSANBAY[Tên sân bay đi], " +
                "S2.TENSANBAY[Tên sân bay đến] FROM TUYENBAY T " +
                "INNER JOIN SANBAY S1 ON T.MASANBAYDI=S1.MASANBAY " +
                "INNER JOIN SANBAY S2 ON T.MASANBAYDEN = S2.MASANBAY WHERE MATUYENBAY LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetOfMaTuyenBay(string str)
        {
            string sqlQuery = string.Format("SELECT T.MATUYENBAY, S1.MASANBAY[MASANBAYDI], S1.TENSANBAY[TENSANBAYDI], " +
                "S2.MASANBAY[MASANBAYDEN], S2.TENSANBAY[TENSANBAYDEN] FROM TUYENBAY T " +
                "INNER JOIN SANBAY S1 ON T.MASANBAYDI=S1.MASANBAY " +
                "INNER JOIN SANBAY S2 ON T.MASANBAYDEN = S2.MASANBAY WHERE MATUYENBAY ='{0}'", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetOfMaSanBay(string maSBDi, string maSBDen)
        {
            string sqlQuery = string.Format("SELECT * FROM TUYENBAY WHERE MASANBAYDI ='{0}' AND MASANBAYDEN='{1}'", maSBDi, maSBDen);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchTTChuyenBay(string tenSBDi, string tenSBDen, string maHV, string maHangMB, string tgkh)
        {
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT C.MACHUYENBAY, T.MATUYENBAY, S.TENSANBAY,S1.TENSANBAY, C.THOIGIANKHOIHANH,C.THOIGIANDEN,C.THOIGIANBAY, H.TENHANGVE, CAST(ROUND(D.DONGIA/2,2) as decimal (18,0))[Đơn Giá] FROM TUYENBAY T" +
                " INNER JOIN CHUYENBAY C ON T.MATUYENBAY=C.MATUYENBAY INNER JOIN DONGIA D ON T.MATUYENBAY=D.MATUYENBAY INNER JOIN SANBAY S ON S.MASANBAY=T.MASANBAYDI" +
                " INNER JOIN SANBAY S1 ON S1.MASANBAY=T.MASANBAYDEN INNER JOIN HANGVE H ON H.MAHANGVE=D.MAHANGVE INNER JOIN MAYBAY M ON M.MAMAYBAY = C.MAMAYBAY" +
                " WHERE S.TENSANBAY = N'{0}' AND S1.TENSANBAY = N'{1}' AND H.MAHANGVE = N'{2}' AND M.MAHANGMB = '{3}' GROUP BY C.MACHUYENBAY, T.MATUYENBAY, S.TENSANBAY,S1.TENSANBAY, C.THOIGIANKHOIHANH ,C.THOIGIANDEN,C.THOIGIANBAY, H.TENHANGVE,D.DONGIA" +
                " Having CAST(C.THOIGIANKHOIHANH AS DATE) <= (SELECT DATEADD(DAY, 3, CAST('{4}' AS DATE))) AND CAST(C.THOIGIANKHOIHANH AS DATE) > CAST('{4}' AS DATE)", tenSBDi, tenSBDen, maHV, maHangMB, tgkh);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            da.Fill(dt);
            return dt;
        }
    }
}
