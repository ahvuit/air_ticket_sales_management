using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon:DBConnect
    {
        public DataTable GetOfHoaDon(string maVe)
        {
            string sqlQuery = string.Format("exec HoaDon '{0}'", maVe);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
