using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HangMayBay
    {
        private string maHangMB;
        private string tenHangMB;

        public DTO_HangMayBay()
        {
        }

        public DTO_HangMayBay(string maHangMB, string tenHangMB)
        {
            this.MaHangMB = maHangMB;
            this.TenHangMB = tenHangMB;
        }

        public string MaHangMB { get => maHangMB; set => maHangMB = value; }
        public string TenHangMB { get => tenHangMB; set => tenHangMB = value; }
    }
}
