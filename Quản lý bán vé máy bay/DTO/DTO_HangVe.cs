using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HangVe
    {
        private string maHangVe;
        private string tenHangVe;
        private long lephiHoan;
        private long lephiDoi;
        public DTO_HangVe()
        {
        }
        public DTO_HangVe(string maHangVe, string tenHangVe, long lephiHoan, long lephiDoi)
        {
            this.maHangVe = maHangVe;
            this.tenHangVe = tenHangVe;
            this.lephiDoi = lephiDoi;
            this.lephiHoan = lephiHoan;
        }

        public string MaHangVe { get => maHangVe; set => maHangVe = value; }
        public string TenHangVe { get => tenHangVe; set => tenHangVe = value; }
        public long LephiHoan { get => lephiHoan; set => lephiHoan = value; }
        public long LephiDoi { get => lephiDoi; set => lephiDoi = value; }
    }
}
