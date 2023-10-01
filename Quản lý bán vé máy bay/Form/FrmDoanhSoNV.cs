using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Quản_lý_bán_vé_máy_bay.Report;

namespace Quản_lý_bán_vé_máy_bay
{
    public partial class FrmDoanhSoNV : Form
    {
        public FrmDoanhSoNV()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string month = dtpThangNam.Value.Month.ToString();
            string year = dtpThangNam.Value.Year.ToString();
            BUS_DoanhSoNV bUS_DoanhSoNV = new BUS_DoanhSoNV();
            DataTable dt_DoanhSoNV = bUS_DoanhSoNV.GetOfThangNam(month, year);
            crDoanhSoNV cr = new crDoanhSoNV();
            cr.SetDataSource(dt_DoanhSoNV);
            crpDoanhSoNV.ReportSource = cr;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
