using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MayBay
    {
        private string maMayBay;
        private string maHangMB;
        private int soLuongGhe;
        public DTO_MayBay()
        {
        }

        public DTO_MayBay(string maMayBay, string maHangMB, int soLuongGhe)
        {
            this.MaMayBay = maMayBay;
            this.MaHangMB = maHangMB;
            this.SoLuongGhe = soLuongGhe;
        }

        public string MaMayBay { get => maMayBay; set => maMayBay = value; }
        public string MaHangMB { get => maHangMB; set => maHangMB = value; }
        public int SoLuongGhe { get => soLuongGhe; set => soLuongGhe = value; }
    }
}
