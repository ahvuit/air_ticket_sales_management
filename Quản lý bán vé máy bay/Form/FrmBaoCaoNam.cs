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
    public partial class FrmBaoCaoNam : Form
    {
        public FrmBaoCaoNam()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string year = dtpNam.Value.Year.ToString();
            BUS_DoanhThuThang busDoanhThuThang = new BUS_DoanhThuThang();
            DataTable dtDoanhThuThang = busDoanhThuThang.GetOfNam(year);
            crDoanhThuNam cr = new crDoanhThuNam();
            cr.SetDataSource(dtDoanhThuThang);
            crvBaoCaoNam.ReportSource = cr;
        }
    }
}
