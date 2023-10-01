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
    public class DAL_VeChuyenBay : DBConnect
    {
        public DataTable Get()
        {
            string sqlQuery = "SELECT* FROM VECHUYENBAY";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetForDisplay()
        {
            string sqlQuery = "SELECT V.MAVE[Mã vé], K.TENKHACHHANG[Tên khách hàng], " +
                "K.CMND[CMND], V.MACHUYENBAY[Mã chuyến bay], H.TENHANGVE[Tên hạng vé], " +
                "V.GIATIEN[Giá tiền], V.NGAYGIOGD[Ngày giờ giao dịch], " +
                "V.LOAIVE[Loại vé] FROM VECHUYENBAY V INNER JOIN KHACHHANG K " +
                "ON V.MAKHACHHANG=K.MAKHACHHANG INNER JOIN HANGVE H ON V.MAHANGVE=H.MAHANGVE";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Add(DTO_VeChuyenBay dto)
        {
            try
            {
                _con.Open();
                string maVe = TaoMaVe();
                string sqlQuery = string.Format("INSERT INTO VECHUYENBAY(MAVE, MAKHACHHANG, MACHUYENBAY, MAHANGVE, MANHANVIEN, GIATIEN, NGAYGIOGD, LOAIVE) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', N'{7}')"
                    , maVe, dto.MaKhachHang, dto.MaChuyenBay, dto.MaHangVe, dto.MaNhanVien,
                    dto.GiaTien, dto.NgayGioGD, dto.LoaiVe);
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
        public bool Update(DTO_VeChuyenBay dto)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("UPDATE VECHUYENBAY SET MACHUYENBAY='{0}', MAHANGVE='{1}', MANHANVIEN='{2}', GIATIEN='{3}', NGAYGIOGD='{4}' WHERE MAVE='{5}' and MAKHACHHANG='{6}'"
                    , dto.MaChuyenBay, dto.MaHangVe, dto.MaNhanVien
                    ,dto.GiaTien, dto.NgayGioGD, dto.MaVe,dto.MaKhachHang);
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
        public bool Delete(string maVe)
        {
            try
            {
                _con.Open();
                string sqlQuery = string.Format("DELETE FROM VECHUYENBAY WHERE MAVE='{0}'", maVe);
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
            string sqlQuery = "SELECT * FROM VECHUYENBAY ORDER BY MAVE DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private string TaoMaVe()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "VE" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string maTuyenBay = row[0].ToString().Substring(2);
            int count = int.Parse(maTuyenBay) + 1;
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
            return "VE" + strSoKhong + count;
        }

        public DataTable SearchOfVeKhachHang(string maVe, string maKhachHang)
        {
            string sqlQuery = string.Format("SELECT V.MAVE[Mã vé], K.MAKHACHHANG[Mã khách hàng],K.TENKHACHHANG[Tên khách hàng], " +
                "K.CMND[CMND], V.MACHUYENBAY[Mã chuyến bay], H.TENHANGVE[Tên hạng vé], " +
                "V.GIATIEN[Giá tiền], V.NGAYGIOGD[Ngày giờ giao dịch], " +
                "V.LOAIVE[Loại vé] FROM VECHUYENBAY V INNER JOIN KHACHHANG K " +
                "ON V.MAKHACHHANG=K.MAKHACHHANG INNER JOIN HANGVE H ON V.MAHANGVE=H.MAHANGVE WHERE V.MAVE = '{0}' AND K.MAKHACHHANG = '{1}'", maVe, maKhachHang);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchOfVeBan(string str)
        {
            string sqlQuery = string.Format("SELECT V.MAVE[Mã vé], K.TENKHACHHANG[Tên khách hàng], " +
                "K.CMND[CMND], V.MACHUYENBAY[Mã chuyến bay], H.TENHANGVE[Tên hạng vé], " +
                "V.GIATIEN[Giá tiền], V.NGAYGIOGD[Ngày giờ giao dịch], V.NGAYHUY[Ngày hủy], " +
                "V.LOAIVE[Loại vé] FROM VECHUYENBAY V INNER JOIN KHACHHANG K " +
                "ON V.MAKHACHHANG=K.MAKHACHHANG INNER JOIN HANGVE H ON V.MAHANGVE=H.MAHANGVE WHERE V.MAVE LIKE('%{0}%')", str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable SearchOfMaNV(string str)
        {
            string sqlQuery = string.Format("SELECT MANHANVIEN[Mã nhân viên] FROM VECHUYENBAY WHERE MAVE = '{0}'",str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public DataTable SearchHangMB(string str)
        {
            string sqlQuery = string.Format("SELECT M.MAHANGMB FROM CHUYENBAY C INNER JOIN VECHUYENBAY V ON C.MACHUYENBAY = V.MACHUYENBAY" +
                " INNER JOIN MAYBAY M ON C.MAMAYBAY = M.MAMAYBAY WHERE V.MAVE = '{0}'",str);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
