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
    public partial class Main : Form
    {
        private DataRow rowTTNhanVien;
        public Main(DataRow row)
        {
            InitializeComponent();
            rowTTNhanVien = row;
            KhoiTaoGiaoDien();
        }

        private bool CheckExistForm(Form frm)
        {
            foreach (TabPage t in tabCtrlMain.TabPages)
            {
                if (frm.Text == t.Text)
                {
                    return true;
                }
            }
            return false;
        }
        private void ActiveChildForm(Form frm)
        {
            foreach (TabPage t in tabCtrlMain.TabPages)
            {
                if (frm.Text == t.Text)
                {
                    tabCtrlMain.SelectedTab = t;
                    break;
                }
            }
        }
        private TabPage CreateTabPage(Form frm)
        {
            TabPage tabPage = new TabPage { Text = frm.Text };
            tabPage.BorderStyle = BorderStyle.None;
            tabCtrlMain.TabPages.Add(tabPage);
            tabCtrlMain.SelectedTab = tabPage;
            frm.TopLevel = false;
            frm.Parent = tabPage;
            frm.BackColor = Color.White;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            return tabPage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form frm = new Login();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void chuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlyChuyenBay frm = new FrmQlyChuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmQlyTuyenBay frm = new FrmQlyTuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void sânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlySanBay frm = new FrmQlySanBay();
            if(!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void toolStripBtnTraCuuChuyenBay_Click(object sender, EventArgs e)
        {
            FrmTraCuuChuyenBay frm = new FrmTraCuuChuyenBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void máyBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlyMayBay frm = new FrmQlyMayBay();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlyKhachHang frm = new FrmQlyKhachHang();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlyNhanVien frm = new FrmQlyNhanVien();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void đơnGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlyDonGia frm = new FrmQlyDonGia();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void hangVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlyHangVe frm = new FrmQlyHangVe();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void nămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoNam frm = new FrmBaoCaoNam();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void thángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoThang frm = new FrmBaoCaoThang();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword(rowTTNhanVien);
            frm.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { Application.Exit(); }
                else { e.Cancel = true; }
            }
        }

        private void KhoiTaoGiaoDien()
        {
            lbMaNhanVien.Text = "Mã nhân viên: " + rowTTNhanVien[2].ToString();
            lbUsername.Text = "Username: " + rowTTNhanVien[0].ToString();
            string type = rowTTNhanVien[3].ToString();
            string a = "Manager";
            string b = "Staff";
            if (String.Compare(type, a, true) == 0)
            {
                mstrMain.Enabled = true;
                toolStripMain.Enabled = true;
            }
            if (String.Compare(type, b, true) == 0)
            {
                mstrMain.Enabled = true;
                toolStripMain.Enabled = true;
                QuanLyThongTinToolStripMenuItem.Enabled = false;
                baoCaoToolStripMenuItem.Enabled = false;
                
            }
        }

        private void toolStripBtnBanVe_Click(object sender, EventArgs e)
        {
            FrmBanVe frm = new FrmBanVe(rowTTNhanVien);
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void véKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQlyVe frm = new FrmQlyVe(rowTTNhanVien);
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }

        private void thôngTinNahfSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTTNhaSanXuat frm = new FrmTTNhaSanXuat();
            frm.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoanhSoNV frm = new FrmDoanhSoNV();
            if (!CheckExistForm(frm))
            {
                CreateTabPage(frm);
            }
            else
            {
                ActiveChildForm(frm);
            }
        }
    }
}
