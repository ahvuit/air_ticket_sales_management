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
    public partial class FrmRefund : Form
    {
        BUS_VeChuyenBay bus_VeChuyenBay;
        BUS_KhachHang busKH;
        BUS_ChuyenBay busCB;
        BUS_HangVe busHV;
        string maVe;
        string maKH;

        public FrmRefund()
        {
            InitializeComponent();
            bus_VeChuyenBay = new BUS_VeChuyenBay();
            busKH = new BUS_KhachHang();
            busCB = new BUS_ChuyenBay();
            busHV = new BUS_HangVe();
            maVe = "";
            maKH = "";
        }

        public FrmRefund(string maVe, string maKH)
        {
            InitializeComponent();
            bus_VeChuyenBay = new BUS_VeChuyenBay();
            busKH = new BUS_KhachHang();
            busCB = new BUS_ChuyenBay();
            busHV = new BUS_HangVe();
            this.maVe = maVe;
            this.maKH = maKH;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void FrmRefund_Load(object sender, EventArgs e)
        {
            txtMaVe.Text = maVe;
            txtMaKhachHang.Text = maKH;
            DataTable dtVeCB = bus_VeChuyenBay.SearchOfVeKhachHang(txtMaVe.Text, txtMaKhachHang.Text);
            DataRow row = dtVeCB.Rows[0];
            txtMaCB.Text = row["Mã chuyến bay"].ToString();
            txtCMND.Text = row["CMND"].ToString();
            txtHangVe.Text = row["Tên hạng vé"].ToString();
            txtGiaTien.Text = row["Giá tiền"].ToString();
            txtNgayGD.Text = row["Ngày giờ giao dịch"].ToString();

            DataTable dtKH = busKH.SearchOfMaKhachHang(txtMaKhachHang.Text);
            DataRow row1 = dtKH.Rows[0];
            txtSDT.Text = row1["Số điện thoại"].ToString();
            txtTenKhachHang.Text = row1["Tên khách hàng"].ToString();

            DataTable dtCB = busCB.GetOfMaChuyenBay(txtMaCB.Text);
            DataRow row2 = dtCB.Rows[0];
            txtMaTuyenBay.Text = row2["MATUYENBAY"].ToString();
            txtSanBayDi.Text = row2["TENSANBAYDI"].ToString();
            txtSanBayDen.Text = row2["TENSANBAYDEN"].ToString();
            txtThoiGianKhoiHanh.Text = row2["THOIGIANKHOIHANH"].ToString();
            txtThoiGIanBay.Text = row2["THOIGIANBAY"].ToString();

            DataTable dtHV = busHV.SearchOfLePhi(txtHangVe.Text);
            DataRow row3 = dtHV.Rows[0];
            txtLePhi.Text = row3["LEPHIHOAN"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan Time = Convert.ToDateTime(txtThoiGianKhoiHanh.Text) - DateTime.Now;
                int TongSoNgay = Time.Days;
                if (TongSoNgay <= 2)
                {
                    MessageBox.Show("Thao tác thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (bus_VeChuyenBay.Delete(txtMaVe.Text))
                {
                    MessageBox.Show("Hoàn vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanForm();
                }
                else
                    MessageBox.Show("Thao tác thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Thao tác thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
    }
}
