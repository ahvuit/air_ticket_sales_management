using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dal = new DAL_HoaDon();
        public DataTable GetOfHoaDon(string maVe)
        {
            return dal.GetOfHoaDon(maVe);
        }
    }
}
