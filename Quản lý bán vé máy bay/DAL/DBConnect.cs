using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=.;Initial Catalog=PLANE_TICKET;Integrated Security=True");

        public void Connect()
        {
            _con.Open();
        }

        public void Disconnect()
        {
            _con.Close();
        }
    }
}
