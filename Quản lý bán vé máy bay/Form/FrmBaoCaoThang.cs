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
    public partial class FrmBaoCaoThang : Form
    {
        public FrmBaoCaoThang()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string month = dtpThangNam.Value.Month.ToString();
            string year = dtpThangNam.Value.Year.ToString();
            BUS_CTDoanhThuThang busCTDoanhThuThang = new BUS_CTDoanhThuThang();
            DataTable dtCTDoanhThuThang = busCTDoanhThuThang.GetOfThangNam(month, year);
            crDoanhThuThang cr = new crDoanhThuThang();
            cr.SetDataSource(dtCTDoanhThuThang);
            crvBaoCaoThang.ReportSource = cr;
        }
    }
}
