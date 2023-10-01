using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DoanhSoNV:DBConnect
    {
        public DataTable GetOfThangNam(string strThang, string strNam)
        {
            string sqlQuery = string.Format("exec DoanhsoNV '{0}','{1}'", strThang, strNam);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
