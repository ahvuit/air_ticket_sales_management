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
namespace Quản_lý_bán_vé_máy_bay
{
    public partial class FrmQlyVe : Form
    {
        string maNhanVien;
        string maVe="";
        string maKH="";
        BUS_VeChuyenBay bus_VeChuyenBay;

        public FrmQlyVe(DataRow row)
        {
            InitializeComponent();
            bus_VeChuyenBay = new BUS_VeChuyenBay();
            this.maNhanVien = row["MANHANVIEN"].ToString();
        }

        private bool CheckExistForm(Form frm)
        {
            foreach (TabPage t in tabCtrQlyVe.TabPages)
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
            foreach (TabPage t in tabCtrQlyVe.TabPages)
            {
                if (frm.Text == t.Text)
                {
                    tabCtrQlyVe.SelectedTab = t;
                    break;
                }
            }
        }

        private TabPage CreateTabPage(Form frm)
        {
            TabPage tabPage = new TabPage { Text = frm.Text };
            tabPage.BorderStyle = BorderStyle.None;
            tabCtrQlyVe.TabPages.Add(tabPage);
            tabCtrQlyVe.SelectedTab = tabPage;
            frm.TopLevel = false;
            frm.Parent = tabPage;
            frm.BackColor = Color.White;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            return tabPage;
        }

        private void btnDoiVe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaVe.Text.Trim() == "" || txtMaKhachHang.Text.Trim() == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                if (dtgvVeKhach.Rows == null || dtgvVeKhach.Rows.Count == 0)
                    throw new Exception("Thao tác không thành công!");
                maVe = dtgvVeKhach.Rows[0].Cells[0].Value.ToString();
                maKH = dtgvVeKhach.Rows[0].Cells[1].Value.ToString();
                FrmChangeticket frm = new FrmChangeticket(maNhanVien,maVe, maKH);
                if (!CheckExistForm(frm))
                {
                    CreateTabPage(frm);
                }
                else
                {
                    ActiveChildForm(frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHoanVe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaVe.Text.Trim() == "" || txtMaKhachHang.Text.Trim() == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                if (dtgvVeKhach.Rows == null || dtgvVeKhach.Rows.Count == 0)
                    throw new Exception("Thao tác không thành công!");
                maVe = dtgvVeKhach.Rows[0].Cells[0].Value.ToString();
                maKH = dtgvVeKhach.Rows[0].Cells[1].Value.ToString();
                FrmRefund frm = new FrmRefund(maVe, maKH);
                if (!CheckExistForm(frm))
                {
                    CreateTabPage(frm);
                }
                else
                {
                    ActiveChildForm(frm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaVe.Text == "" || txtMaKhachHang.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                DataTable dt = bus_VeChuyenBay.Get();
                DataRow rw = dt.AsEnumerable().FirstOrDefault(p => p.Field<string>("MAVE") == txtMaVe.Text && p.Field<string>("MAKHACHHANG") == txtMaKhachHang.Text);
                if (rw == null)
                    throw new Exception("Vé không tồn tại!");
                dtgvVeKhach.DataSource = bus_VeChuyenBay.SearchOfVeKhachHang(txtMaVe.Text, txtMaKhachHang.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvVeKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvVeKhach.Rows[e.RowIndex];
            txtMaVe.Text = row.Cells[0].Value.ToString();
            txtMaKhachHang.Text = row.Cells[1].Value.ToString();
        }

    }
}
