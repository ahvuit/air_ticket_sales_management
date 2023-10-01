using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string maVe;

        public DTO_HoaDon()
        {
        }
        public DTO_HoaDon(string maVe)
        {
            this.MaVe = maVe;
        }

        public string MaVe { get => maVe; set => maVe = value; }
    }
}
