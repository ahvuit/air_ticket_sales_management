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
using DTO;
namespace Quản_lý_bán_vé_máy_bay
{
    public partial class FrmChangeticket : Form
    {
        BUS_VeChuyenBay bus_VeChuyenBay;
        BUS_KhachHang busKH;
        BUS_ChuyenBay busCB;
        BUS_HangVe busHangVe;
        DTO_VeChuyenBay dto_VeChuyenBay;
        string maVe;
        string maKH;
        string maNhanVien;
        public FrmChangeticket()
        {
            InitializeComponent();
            bus_VeChuyenBay = new BUS_VeChuyenBay();
            busKH = new BUS_KhachHang();
            busCB = new BUS_ChuyenBay();
            busHangVe = new BUS_HangVe();
            maVe = "";
            maKH = "";
            maNhanVien = "";
        }

        public FrmChangeticket(string maNhanVien, string maVe, string maKH)
        {
            InitializeComponent();
            bus_VeChuyenBay = new BUS_VeChuyenBay();
            busKH = new BUS_KhachHang();
            busCB = new BUS_ChuyenBay();
            busHangVe = new BUS_HangVe();
            this.maVe = maVe;
            this.maKH = maKH;
            this.maNhanVien = maNhanVien;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void FrmChangeticket_Load(object sender, EventArgs e)
        {
            txtMaVe.Text = maVe;
            txtMaKhachHang.Text = maKH;

            DataTable dtChuyenBay = new DataTable();
            dtChuyenBay = busCB.Get();
            cmbMaChuyenBay.DataSource = dtChuyenBay;
            cmbMaChuyenBay.DisplayMember = "MACHUYENBAY";
            cmbMaChuyenBay.ValueMember = "MACHUYENBAY";

            DataTable dtHangVe = new DataTable();
            dtHangVe = busHangVe.Get();
            cmbHangVe.DataSource = dtHangVe;
            cmbHangVe.DisplayMember = "TENHANGVE";
            cmbHangVe.ValueMember = "MAHANGVE";

            DataTable dtVeCB = bus_VeChuyenBay.SearchOfVeKhachHang(txtMaVe.Text, txtMaKhachHang.Text);
            DataRow row1 = dtVeCB.Rows[0];
            cmbMaChuyenBay.Text = row1["Mã chuyến bay"].ToString();
            cmbHangVe.Text = row1["Tên hạng vé"].ToString();
            txtGiaTien.Text = row1["Giá tiền"].ToString();
            DataTable dtKH = busKH.SearchOfMaKhachHang(txtMaKhachHang.Text);
            DataRow row = dtKH.Rows[0];
            txtSDT.Text = row["Số điện thoại"].ToString();
            txtTenKhachHang.Text = row["Tên khách hàng"].ToString();
            txtCMND.Text = row["CMND"].ToString();

            DataTable dtCB = busCB.GetOfMaChuyenBay(cmbMaChuyenBay.Text);
            DataRow row2 = dtCB.Rows[0];
            txtMaTuyenBay.Text = row2["MATUYENBAY"].ToString();
            txtSanBayDi.Text = row2["TENSANBAYDI"].ToString();
            txtSanBayDen.Text = row2["TENSANBAYDEN"].ToString();
            txtThoiGianKhoiHanh.Text = row2["THOIGIANKHOIHANH"].ToString();
            txtThoiGIanBay.Text = row2["THOIGIANBAY"].ToString();

            DataTable dtHV = busHangVe.SearchOfLePhi(cmbHangVe.Text);
            DataRow row3 = dtHV.Rows[0];
            txtLePhi.Text = row3["LEPHIDOI"].ToString();
        }

        private void cmbMaChuyenBay_SelectedValueChanged(object sender, EventArgs e)
        {
            BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
            DataTable dtChuyenBay = busChuyenBay.GetOfMaChuyenBay(cmbMaChuyenBay.Text);
            if (dtChuyenBay.Rows.Count == 0)
            {
                txtMaTuyenBay.Clear();
                txtSanBayDi.Clear();
                txtSanBayDen.Clear();
                txtThoiGianKhoiHanh.Clear();
                txtThoiGIanBay.Clear();
            }
            else
            {
                DataRow row = dtChuyenBay.Rows[0];
                txtMaTuyenBay.Text = row["MATUYENBAY"].ToString();
                txtSanBayDi.Text = row["TENSANBAYDI"].ToString();
                txtSanBayDen.Text = row["TENSANBAYDEN"].ToString();
                txtThoiGianKhoiHanh.Text = row["THOIGIANKHOIHANH"].ToString();
                txtThoiGIanBay.Text = row["THOIGIANBAY"].ToString();
                LoadDaTatxtSoGheTrong();
            }
        }

        private void cmbHangVe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbHangVe.SelectedValue != null)
            {
                BUS_DonGia busDonGia = new BUS_DonGia();
                DataTable dtDonGia = busDonGia.SearchOfMaTuyenBayAndMaHangVe(txtMaTuyenBay.Text, cmbHangVe.SelectedValue.ToString());
                DataTable dtHV = busHangVe.SearchOfLePhi(cmbHangVe.Text);

                foreach (DataRow row in dtDonGia.Rows)
                {
                    txtGiaTien.Text = row["DONGIA"].ToString();
                }
                foreach (DataRow row in dtHV.Rows)
                {
                    txtLePhi.Text = row["LEPHIDOI"].ToString();
                }
            }
            LoadDaTatxtSoGheTrong();
        }
        private void LoadDaTatxtSoGheTrong()
        {
            if (cmbHangVe.SelectedValue != null)
            {
                BUS_TinhTrangVe busTinhTrangVe = new BUS_TinhTrangVe();
                txtSoGheTrong.Text = busTinhTrangVe.GetSoGheTrongOfMaChuyenBayAndMaHangVe(cmbMaChuyenBay.Text, cmbHangVe.SelectedValue.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtVeCB = bus_VeChuyenBay.SearchOfVeKhachHang(txtMaVe.Text, txtMaKhachHang.Text);
                DataRow row = dtVeCB.Rows[0];
                string maCB = row["Mã chuyến bay"].ToString();
                string tenHV = row["Tên hạng vé"].ToString();
                string LoaiVe = row["Loại vé"].ToString();
                
                if(maCB == cmbMaChuyenBay.Text && tenHV == cmbHangVe.Text)
                {
                    MessageBox.Show("Thao tác thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }           

                DataTable dtCB = busCB.SearchOfMaChuyenBay(maCB);
                DataRow row1 = dtCB.Rows[0];
                string maTB = row1["Mã tuyến bay"].ToString();

                if(LoaiVe == "Vé Mua Khứ Hồi" || LoaiVe == "Vé Đặt Khứ Hồi")
                {
                    if (maTB != txtMaTuyenBay.Text)
                    {
                        MessageBox.Show("Thao tác thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DateTime tgkh = Convert.ToDateTime(row1["Thời gian khởi hành"]);
                TimeSpan Time = tgkh - DateTime.Now;
                int TongSoNgay = Time.Days;
                if(TongSoNgay <= 2)
                {
                    MessageBox.Show("Thao tác thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
    
                dto_VeChuyenBay = new DTO_VeChuyenBay(txtMaVe.Text,txtMaKhachHang.Text, cmbMaChuyenBay.Text, cmbHangVe.SelectedValue.ToString(),maNhanVien, Convert.ToDecimal(txtGiaTien.Text), DateTime.Now, Convert.ToDateTime(null), LoaiVe);
                if (bus_VeChuyenBay.Update(dto_VeChuyenBay))
                {
                    MessageBox.Show("Đổi vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
