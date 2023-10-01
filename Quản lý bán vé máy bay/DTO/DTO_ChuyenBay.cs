using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuyenBay
    {
        private string maChuyenBay;
        private string maTuyenBay;
        private string maMayBay;
        private DateTime thoiGianKhoiHanh;
        private DateTime thoiGianDen;
        private float thoiGianBay;
        public DTO_ChuyenBay()
        {
        }

        public DTO_ChuyenBay(string maChuyenBay, string maTuyenBay, string maMayBay, DateTime thoiGianKhoiHanh, DateTime thoiGianDen, float thoiGianBay)
        {
            this.MaChuyenBay = maChuyenBay;
            this.MaTuyenBay = maTuyenBay;
            this.MaMayBay = maMayBay;
            this.ThoiGianKhoiHanh = thoiGianKhoiHanh;
            this.ThoiGianDen = thoiGianDen;
            this.ThoiGianBay = thoiGianBay;
        }

        public string MaChuyenBay { get => maChuyenBay; set => maChuyenBay = value; }
        public string MaTuyenBay { get => maTuyenBay; set => maTuyenBay = value; }
        public string MaMayBay { get => maMayBay; set => maMayBay = value; }
        public DateTime ThoiGianKhoiHanh { get => thoiGianKhoiHanh; set => thoiGianKhoiHanh = value; }
        public float ThoiGianBay { get => thoiGianBay; set => thoiGianBay = value; }
        public DateTime ThoiGianDen { get => thoiGianDen; set => thoiGianDen = value; }
    }
}
