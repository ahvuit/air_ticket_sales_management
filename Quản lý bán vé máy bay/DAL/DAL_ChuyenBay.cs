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
    public class DAL_ChuyenBay : DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM CHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetToDisplay()
        {
            string sqlQuery = "SELECT MACHUYENBAY[Mã chuyến bay], MATUYENBAY[Mã tuyến bay],MAMAYBAY[Mã máy bay], THOIGIANKHOIHANH[Thời gian khởi hành], THOIGIANDEN[Thời gian đến], THOIGIANBAY[Thời gian bay] FROM CHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetAndSortDesc()
        {
            string sqlQuery = "SELECT* FROM CHUYENBAY ORDER BY MACHUYENBAY DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_ChuyenBay dto)
        {
            try
            {
                _con.Open();
                string maCB = TaoMaChuyenBay();
                string sqlQuery = string.Format("INSERT INTO CHUYENBAY(MACHUYENBAY, MATUYENBAY, MAMAYBAY, THOIGIANKHOIHANH,THOIGIANDEN, THOIGIANBAY) VALUES('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", maCB, dto.MaTuyenBay, dto.MaMayBay, dto.ThoiGianKhoiHanh,dto.ThoiGianDen,dto.ThoiGianBay);
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

            }
            finally
            {
                _con.Close();
            }
            return false;
        }
        public bool Update(DTO_ChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE CHUYENBAY SET MATUYENBAY='{0}', MAMAYBAY='{1}', THOIGIANKHOIHANH='{2}',THOIGIANDEN='{3}' ,THOIGIANBAY='{4}' WHERE MACHUYENBAY='{5}'", dto.MaTuyenBay, dto.MaMayBay, dto.ThoiGianKhoiHanh, dto.ThoiGianDen,dto.ThoiGianBay, dto.MaChuyenBay);
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
                string sqlQuery = string.Format("DELETE FROM CHUYENBAY WHERE MACHUYENBAY='{0}'", str);
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

        private string TaoMaChuyenBay()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "CB" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string maChuyenBay = row[0].ToString().Substring(2);
            int count = int.Parse(maChuyenBay) + 1;
            int temp = count;
            string strSoKhong = "";
            int dem = 0;
            while (temp > 0)
            {
                temp /= 10;
                dem++;
            }
            for (int i = 0; i < 1 - dem; i++)
            {
                strSoKhong += "0";
            }
            return "CB" + strSoKhong + count;
        }

        public DataTable GetOfMaChuyenBay(string maChuyenBay)
        {
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT C.MACHUYENBAY[MACHUYENBAY], T.MATUYENBAY[MATUYENBAY], C.MAMAYBAY, " +
                "C.THOIGIANKHOIHANH, C.THOIGIANDEN,C.THOIGIANBAY, S1.TENSANBAY[TENSANBAYDI], S2.TENSANBAY[TENSANBAYDEN] " +
                "FROM CHUYENBAY C INNER JOIN TUYENBAY T ON C.MATUYENBAY=T.MATUYENBAY INNER JOIN SANBAY S1 ON T.MASANBAYDI=S1.MASANBAY INNER JOIN SANBAY S2 ON T.MASANBAYDEN = S2.MASANBAY WHERE MACHUYENBAY='{0}'", maChuyenBay);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            da.Fill(dt);
            return dt;
        }
        public DateTime GetDateTimeOfMaChuyenBay(string str)
        {
            string sqlQuery = string.Format("SELECT THOIGIANKHOIHANH FROM CHUYENBAY WHERE MACHUYENBAY='{0}'", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return Convert.ToDateTime(dt.Rows[0].ToString());
        }
        public DataTable SearchOfMaChuyenBay(string str)
        {
            string sqlQuery = string.Format("SELECT MACHUYENBAY[Mã chuyến bay], MATUYENBAY[Mã tuyến bay], MAMAYBAY[Mã máy bay],THOIGIANKHOIHANH[Thời gian khởi hành],THOIGIANDEN[Thời gian đến] ,THOIGIANBAY[Thời gian bay] FROM CHUYENBAY WHERE MACHUYENBAY LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Search(string maSanBayDi, string maSanBayDen, DateTime thoiGianKHTu, DateTime thoiGianKHDen)
        {
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT C.MACHUYENBAY[Mã chuyến bay], C.THOIGIANKHOIHANH[Thời gian KH], C.THOIGIANBAY[Thời gian bay], THOIGIANDEN[Thời gian đến] " +
                "FROM CHUYENBAY C INNER JOIN TUYENBAY T " +
                "ON C.MATUYENBAY=T.MATUYENBAY WHERE T.MASANBAYDI = '{0}' " +
                "AND T.MASANBAYDEN ='{1}' AND C.THOIGIANKHOIHANH BETWEEN('{2}') AND ('{3}') "
                , maSanBayDi, maSanBayDen, thoiGianKHTu, thoiGianKHDen);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            da.Fill(dt);
            return dt;
        }
    }
}
