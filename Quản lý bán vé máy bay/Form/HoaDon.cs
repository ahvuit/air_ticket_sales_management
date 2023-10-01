using BUS;
using Quản_lý_bán_vé_máy_bay.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_vé_máy_bay
{
    public partial class FrmHoaDon : Form
    {
        string maVe;
        public FrmHoaDon()
        {
            InitializeComponent();
            maVe = "";
        }
        public FrmHoaDon(string maVe)
        {
            InitializeComponent();
            this.maVe = maVe;
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            BUS_HoaDon bus_HoaDon = new BUS_HoaDon();
            DataTable dtHoaDon = bus_HoaDon.GetOfHoaDon(maVe);
            crHoaDon cr = new crHoaDon();
            cr.SetDataSource(dtHoaDon);
            crvHoaDon.ReportSource = cr;
        }
    }
}
