using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_VeChuyenBay
    {
        DAL_VeChuyenBay dal = new DAL_VeChuyenBay();

        public DataTable Get()
        {
            return dal.Get();
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }
        public bool Add(DTO_VeChuyenBay dto)
        {
            return dal.Add(dto);
        }
        public bool Update(DTO_VeChuyenBay dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(string str)
        {
            return dal.Delete(str);
        }

        public DataTable SearchOfVeKhachHang(string maVe, string maKH)
        {
            return dal.SearchOfVeKhachHang(maVe,maKH);
        }

        public DataTable SearchOfVeBan(string str)
        {
            return dal.SearchOfVeBan(str);
        }

        public DataTable SearchOfMaNV(string str)
        {
            return dal.SearchOfMaNV(str);
        }

        public DataTable SearchHangMB(string str)
        {
            return dal.SearchHangMB(str);
        }
    }
}
