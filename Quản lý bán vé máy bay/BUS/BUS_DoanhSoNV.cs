using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_DoanhSoNV
    {
        DAL_DoanhSoNV dal = new DAL_DoanhSoNV();
        public DataTable GetOfThangNam(string strThang, string strNam)
        {
            return dal.GetOfThangNam(strThang, strNam);
        }
    }
}
