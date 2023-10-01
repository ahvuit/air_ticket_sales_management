using BUS;
using DTO;
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
    public partial class FrmBanVe : Form
    {
        #region Properties
        string maNhanVien;
        DTO_VeChuyenBay dtoVeChuyenBay;
        DTO_KhachHang dtoKhachHang;
        BUS_VeChuyenBay busVeChuyenBay;
        BUS_KhachHang busKhachHang;
        string sbden;
        string sbdi;
        string CMND;
        string tenHV;
        string maVe;
        string maHangMB;
        string tgkh;
        bool keyClick;
        #endregion

        #region Initializes
        public FrmBanVe(DataRow row)
        {
            InitializeComponent();
            busVeChuyenBay = new BUS_VeChuyenBay();
            busKhachHang = new BUS_KhachHang();
            CMND = "";
            sbdi = "";
            sbden = "";
            tenHV = "";
            maVe = "";
            maHangMB = "";
            tgkh = "";
            keyClick = false;
            this.maNhanVien = row["MANHANVIEN"].ToString();
        }
        #endregion

        #region Methods
        private void TaoLai()
        {
            TaoBangDSVeChuyenBay();
            txtCMND.Clear();
            txtSDT.Clear();
            txtTenKhachHang.Clear();
            LoadDaTatxtSoGheTrong();
        }
        private void btnMuaVe_Click(object sender, EventArgs e)
        {  
            if (cboMaChuyenBay.Text.Trim() != "" && txtCMND.Text.Trim() != "" && txtTenKhachHang.Text.Trim() != "" && txtSDT.Text.Trim() != "" && cboHangVe.Text.Trim() != "")
            {
                if (txtSoGheTrong.Text == "0" || txtSoGheTrong.Text == "")
                {
                    MessageBox.Show("Không còn vé cho hạng vé này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToDateTime(txtThoiGianKhoiHanh.Text) < DateTime.Now)
                {
                    MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtLoaiVe.Text.Trim() == "Vé Mua Khứ Hồi" || txtLoaiVe.Text.Trim() == "Vé Đặt Khứ Hồi")
                {
                    MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    string maKhachHang;
                    string loaiVe = "Vé mua";
                    DataTable dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);

                    if (dtKhachHang.Rows.Count > 0)
                    {
                        DataRow row = dtKhachHang.Rows[0];
                        maKhachHang = row["MAKHACHHANG"].ToString();
                    }
                    else
                    {
                        dtoKhachHang = new DTO_KhachHang(null, txtTenKhachHang.Text, txtCMND.Text, txtSDT.Text);
                        if (!busKhachHang.Add(dtoKhachHang))
                        {
                            MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TaoLai();
                            return;
                        }
                        dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);
                        DataRow row = dtKhachHang.Rows[0];
                        maKhachHang = row["MAKHACHHANG"].ToString();
                    }

                    dtoVeChuyenBay = new DTO_VeChuyenBay(null, maKhachHang, cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString(), maNhanVien, Convert.ToDecimal(txtGiaTien.Text), DateTime.Now, Convert.ToDateTime(null), loaiVe);
                    if (busVeChuyenBay.Add(dtoVeChuyenBay))
                        MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("a Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }
        private void KhoiTaoGiaoDien()
        {
            BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
            DataTable dtChuyenBay = new DataTable();

            dtChuyenBay = busChuyenBay.Get();
            cboMaChuyenBay.DataSource = dtChuyenBay;
            cboMaChuyenBay.DisplayMember = "MACHUYENBAY";
            cboMaChuyenBay.ValueMember = "MACHUYENBAY";

            BUS_HangVe busHangVe = new BUS_HangVe();
            DataTable dtHangVe = new DataTable();

            dtHangVe = busHangVe.Get();
            cboHangVe.DataSource = dtHangVe;
            cboHangVe.DisplayMember = "TENHANGVE";
            cboHangVe.ValueMember = "MAHANGVE";

            TaoBangDSVeChuyenBay();
        }
        private void cboMaChuyenBay_SelectedValueChanged(object sender, EventArgs e)
        {
            BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
            DataTable dtChuyenBay = busChuyenBay.GetOfMaChuyenBay(cboMaChuyenBay.Text);
            if (dtChuyenBay.Rows.Count == 0)
            {
                txtMaTuyenBay.Clear();
                txtSanBayDi.Clear();
                txtSanBayDen.Clear();
                txtThoiGianKhoiHanh.Clear();
                txtThoiGianDen.Clear();
                txtThoiGIanBay.Clear();
                txtGiaTien.Clear();
                txtLoaiVe.Clear();
            }
            else
            {
                DataRow row = dtChuyenBay.Rows[0];
                txtMaTuyenBay.Text = row["MATUYENBAY"].ToString();
                txtSanBayDi.Text = row["TENSANBAYDI"].ToString();
                txtSanBayDen.Text = row["TENSANBAYDEN"].ToString();
                txtThoiGianKhoiHanh.Text = row["THOIGIANKHOIHANH"].ToString();
                txtThoiGianDen.Text = row["THOIGIANDEN"].ToString();
                txtThoiGIanBay.Text = row["THOIGIANBAY"].ToString();
                cboHangVe.Text = "Hạng vé thương gia";
                txtLoaiVe.Clear();
                LoadGiaTien();
                LoadDaTatxtSoGheTrong();
            }
        }
        private void LoadGiaTien()
        {
            if (cboHangVe.SelectedValue != null)
            {
                BUS_DonGia busDonGia = new BUS_DonGia();
                DataTable dtDonGia = busDonGia.SearchOfMaTuyenBayAndMaHangVe(txtMaTuyenBay.Text, cboHangVe.SelectedValue.ToString());

                foreach (DataRow row1 in dtDonGia.Rows)
                {
                    txtGiaTien.Text = row1["DONGIA"].ToString();
                }
            }
        }
        private void cboHangVe_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboHangVe.SelectedValue != null)
            {
                BUS_DonGia busDonGia = new BUS_DonGia();
                DataTable dtDonGia = busDonGia.SearchOfMaTuyenBayAndMaHangVe(txtMaTuyenBay.Text, cboHangVe.SelectedValue.ToString());

                foreach (DataRow row in dtDonGia.Rows)
                {
                    txtGiaTien.Text = row["DONGIA"].ToString();
                }
            }
            LoadDaTatxtSoGheTrong();
        }
        private void LoadDaTatxtSoGheTrong()
        {
            if (cboHangVe.SelectedValue != null)
            {
                BUS_TinhTrangVe busTinhTrangVe = new BUS_TinhTrangVe();
                txtSoGheTrong.Text = busTinhTrangVe.GetSoGheTrongOfMaChuyenBayAndMaHangVe(cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString());
            }
        }
        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            BUS_KhachHang busKhachHang = new BUS_KhachHang();
            DataTable dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);
            if (dtKhachHang.Rows.Count == 0)
            {
                txtTenKhachHang.Clear();
                txtSDT.Clear();
            }
            else
            {
                DataRow row = dtKhachHang.Rows[0];
                txtTenKhachHang.Text = row["TENKHACHHANG"].ToString();
                txtSDT.Text = row["SDT"].ToString();
            }
        }
        private void TaoBangDSVeChuyenBay()
        {
            DataTable dtVeChuyenBay = busVeChuyenBay.GetForDisplay();
            dtgvVe.DataSource = dtVeChuyenBay;
            dtgvVe.Sort(dtgvVe.Columns[0], ListSortDirection.Descending);
            dtgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (cboMaChuyenBay.Text.Trim() != "" && txtCMND.Text.Trim() != "" && txtTenKhachHang.Text.Trim() != "" && txtSDT.Text.Trim() != "" && cboHangVe.Text.Trim() != "")
            {
                if (txtSoGheTrong.Text == "0" || txtSoGheTrong.Text == "")
                {
                    MessageBox.Show("Không còn vé cho hạng vé này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (Convert.ToDateTime(txtThoiGianKhoiHanh.Text) < DateTime.Now)
                {
                    MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtLoaiVe.Text.Trim() == "Vé Mua Khứ Hồi" || txtLoaiVe.Text.Trim() == "Vé Đặt Khứ Hồi")
                {
                    MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    string maKhachHang;
                    string loaiVe = "Vé đặt";
                    DataTable dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);
                    if (dtKhachHang.Rows.Count > 0)
                    {
                        DataRow row = dtKhachHang.Rows[0];
                        maKhachHang = row["MAKHACHHANG"].ToString();
                    }
                    else
                    {
                        dtoKhachHang = new DTO_KhachHang(null, txtTenKhachHang.Text, txtCMND.Text, txtSDT.Text);
                        if (!busKhachHang.Add(dtoKhachHang))
                        {
                            MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TaoLai();
                            return;
                        }
                        dtKhachHang = busKhachHang.GetOfCMND(txtCMND.Text);
                        DataRow row = dtKhachHang.Rows[0];
                        maKhachHang = row["MAKHACHHANG"].ToString();
                    }
                    dtoVeChuyenBay = new DTO_VeChuyenBay(null, maKhachHang, cboMaChuyenBay.Text, cboHangVe.SelectedValue.ToString(), maNhanVien, Convert.ToDecimal(txtGiaTien.Text), DateTime.Now, Convert.ToDateTime(null), loaiVe);
                    if (busVeChuyenBay.Add(dtoVeChuyenBay))
                        MessageBox.Show("Đặt vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaTien.Text == "")
                return;
            string text = txtGiaTien.Text.Replace(",", "");
            decimal value = Convert.ToDecimal(text);
            txtGiaTien.Text = string.Format("{0:0,0}", value);

        }
        private void dtgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvVe.Rows[e.RowIndex];
            txtCMND.Text = row.Cells[2].Value.ToString();
            cboMaChuyenBay.SelectedValue = row.Cells[3].Value.ToString();
            cboHangVe.Text = row.Cells[4].Value.ToString();
            txtGiaTien.Text = row.Cells[5].Value.ToString();
            txtLoaiVe.Text = row.Cells[7].Value.ToString();
            maVe = row.Cells[0].Value.ToString();
            if (txtCMND.Text == "")
            {
                keyClick = false;
            }
            else keyClick = true;
            LoadDaTatxtSoGheTrong();

        }
        private void frmBanVe_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }
        private void btnChiTietGheTrong_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTinhTrangVe(cboMaChuyenBay.Text);
            frm.Show();
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTraCuuChuyenBay(cboMaChuyenBay);
            frm.Show();
        }
        private void btnKhuHoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCMND.Text.Trim() == "")
                    throw new Exception("Thao tác không thành công!");
                if (txtLoaiVe.Text.Trim() == "Vé Mua Khứ Hồi" || txtLoaiVe.Text.Trim() == "Vé Đặt Khứ Hồi")
                    throw new Exception("Thao tác không thành công!");
                CMND = txtCMND.Text;
                sbdi = txtSanBayDen.Text;
                sbden = txtSanBayDi.Text;
                tgkh = txtThoiGianKhoiHanh.Text;
                tenHV = cboHangVe.SelectedValue.ToString();
                DataTable dtHangMB = busVeChuyenBay.SearchHangMB(maVe);
                DataRow row = dtHangMB.Rows[0];
                maHangMB = row[0].ToString();
                FrmBanVeKhuHoi frm = new FrmBanVeKhuHoi(maNhanVien, CMND, sbdi, sbden, tenHV, maHangMB, tgkh);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvVe.Rows == null || dtgvVe.Rows.Count == 0||keyClick==false)
                    throw new Exception("Thao tác không thành công!");
                FrmHoaDon f = new FrmHoaDon(maVe);
                f.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
