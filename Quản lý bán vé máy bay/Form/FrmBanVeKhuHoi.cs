using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Quản_lý_bán_vé_máy_bay
{
    public partial class FrmBanVeKhuHoi : Form
    {
        #region Properties
        string maHangMB;
        string maNhanVien;
        string maVe;
        string tgkh;
        bool checkedVe;
        bool keyClick;
        DTO_VeChuyenBay dtoVeChuyenBay;
        DTO_KhachHang dtoKhachHang;
        BUS_VeChuyenBay busVeChuyenBay;
        BUS_KhachHang busKhachHang;
        BUS_TuyenBay busTuyenBay;
        string tenHV;
        string CMND;
        string sbden;
        string sbdi;
        #endregion
        #region Initializes
        public FrmBanVeKhuHoi()
        {
            InitializeComponent();
            busVeChuyenBay = new BUS_VeChuyenBay();
            busKhachHang = new BUS_KhachHang();
            busTuyenBay = new BUS_TuyenBay();
            CMND = "";
            maNhanVien = "";
            tenHV = "";
            sbdi = "";
            sbden = "";
            keyClick = false;
            checkedVe = false;
            maHangMB = "";
        }
        public FrmBanVeKhuHoi(string maNhanVien, string CMND, string sbdi, string sbden, string tenHV, string maHangMB, string tgkh)
        {
            InitializeComponent();
            busVeChuyenBay = new BUS_VeChuyenBay();
            busKhachHang = new BUS_KhachHang();
            busTuyenBay = new BUS_TuyenBay();
            this.maNhanVien = maNhanVien;
            this.CMND = CMND;
            this.sbdi = sbdi;
            this.sbden = sbden;
            this.tenHV = tenHV;
            this.tgkh = tgkh;
            maVe = "";
            this.maHangMB = maHangMB;
            keyClick = false;
            checkedVe = false;
        }
        #endregion
        #region Method
        private void TaoLai()
        {
            TaoBangDSVeChuyenBay();
            txtCMND.Clear();
            txtSDT.Clear();
            txtTenKhachHang.Clear();
            LoadDaTatxtSoGheTrong();
        }
        private void TaoBangDSVeChuyenBay()
        {
            DataTable dtVeChuyenBay = busVeChuyenBay.GetForDisplay();
            dtgvVe.DataSource = dtVeChuyenBay;
            dtgvVe.Sort(dtgvVe.Columns[0], ListSortDirection.Descending);
            dtgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvVe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void LoadDaTatxtSoGheTrong()
        {
            if (txtHangVe.Text != "")
            {
                BUS_TinhTrangVe busTinhTrangVe = new BUS_TinhTrangVe();
                txtSoGheTrong.Text = busTinhTrangVe.GetSoGheTrongOfMaChuyenBayAndHangVe(txtMaChuyenBay.Text, txtHangVe.Text);
            }
            else txtSoGheTrong.Text = "0";
        }
        private void KhoiTaoGiaoDien()
        {
            txtCMND.Text = CMND;
            txtSBDi1.Text = sbdi;
            txtSBDen1.Text = sbden;

            BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
            DataTable dtChuyenBay = new DataTable();


            BUS_HangVe busHangVe = new BUS_HangVe();
            DataTable dtHangVe = new DataTable();

            BUS_KhachHang busKhachHang = new BUS_KhachHang();

            TaoBangDSVeChuyenBay();

            DataTable dtKH = busKhachHang.SearchOfCMNDKhachHang(txtCMND.Text);
            DataRow row1 = dtKH.Rows[0];
            txtSDT.Text = row1["Số điện thoại"].ToString();
            txtTenKhachHang.Text = row1["Tên khách hàng"].ToString();
        }
        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaTien.Text == "")
                return;
            string text = txtGiaTien.Text.Replace(",", "");
            decimal value = Convert.ToDecimal(text);
            txtGiaTien.Text = string.Format("{0:0,0}", value);

        }
        private void btnChiTietGheTrong_Click(object sender, EventArgs e)
        {
            Form frm = new FrmTinhTrangVe(txtMaChuyenBay.Text);
            frm.Show();
        }
        private void FrmBanVeKhuHoi_Load(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }
        private void btnSearchTTCB_Click(object sender, EventArgs e)
        {
            dtgvChuyenBay.DataSource = busTuyenBay.SearchTTChuyenBay(txtSBDi1.Text, txtSBDen1.Text, tenHV, maHangMB, tgkh);
            dtgvChuyenBay.Sort(dtgvChuyenBay.Columns[0], ListSortDirection.Descending);
            dtgvChuyenBay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvChuyenBay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void dtgvChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvChuyenBay.Rows[e.RowIndex];
            txtMaChuyenBay.Text = row.Cells[0].Value.ToString();
            txtGiaTien.Text = row.Cells[8].Value.ToString();
            txtHangVe.Text = row.Cells[7].Value.ToString();
            txtCMND.Text = CMND;
            txtLoaiVe.Clear();
            keyClick = false;
            LoadDaTatxtSoGheTrong();
        }       
        private void checkve()
        {
            DataTable dtVeChuyenBay = busVeChuyenBay.GetForDisplay();
            foreach (DataRow Row in dtVeChuyenBay.Rows)
            {
                string loaive = Row["Loại vé"].ToString();
                string maCB = Row["Mã chuyến bay"].ToString();
                string hangVe = Row["Tên hạng vé"].ToString();
                string cmnd = Row["CMND"].ToString();
                BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
                DataTable dtChuyenBay = busChuyenBay.GetOfMaChuyenBay(maCB);
                DataRow row = dtChuyenBay.Rows[0];
                string maTB = row["MATUYENBAY"].ToString();
                DateTime ngaydi = Convert.ToDateTime(row["THOIGIANKHOIHANH"]);

                TimeSpan Time = Convert.ToDateTime(txtThoiGianKhoiHanh.Text) - ngaydi;
                int TongSoNgay = Time.Days;
                if (loaive == "Vé Mua Khứ Hồi" || loaive == "Vé Đặt Khứ Hồi")
                {
                    if(TongSoNgay <= 3 && txtMaTuyenBay.Text == maTB && txtHangVe.Text == hangVe && cmnd == txtCMND.Text)
                    checkedVe = true;
                }
            }
        }
        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Text.Trim() != "" && txtCMND.Text.Trim() != "" && txtTenKhachHang.Text.Trim() != "" && txtSDT.Text.Trim() != "" && txtHangVe.Text.Trim() != "")
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
                if (txtLoaiVe.Text.Trim() !="")
                {
                    MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                checkve();
                if(checkedVe == true)
                {
                    MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    string maKhachHang;
                    string loaiVe = "Vé Mua Khứ Hồi";
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

                    dtoVeChuyenBay = new DTO_VeChuyenBay(null, maKhachHang, txtMaChuyenBay.Text, tenHV, maNhanVien, Convert.ToDecimal(txtGiaTien.Text), DateTime.Now, Convert.ToDateTime(null), loaiVe);
                    if (busVeChuyenBay.Add(dtoVeChuyenBay))
                        MessageBox.Show("Mua vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Mua vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (txtMaChuyenBay.Text.Trim() != "" && txtCMND.Text.Trim() != "" && txtTenKhachHang.Text.Trim() != "" && txtSDT.Text.Trim() != "" && txtHangVe.Text.Trim() != "")
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
                if (txtLoaiVe.Text.Trim() != "")
                {
                    MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                checkve();
                if (checkedVe == true)
                {
                    MessageBox.Show("Đặt vé không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    string maKhachHang;
                    string loaiVe = "Vé Đặt Khứ Hồi";
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
                    dtoVeChuyenBay = new DTO_VeChuyenBay(null, maKhachHang, txtMaChuyenBay.Text, tenHV, maNhanVien, Convert.ToDecimal(txtGiaTien.Text), DateTime.Now, Convert.ToDateTime(null), loaiVe);
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
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvVe.Rows == null || dtgvVe.Rows.Count == 0 || keyClick == false)
                    throw new Exception("Thao tác không thành công!");
                FrmHoaDon f = new FrmHoaDon(maVe);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dtgvVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvVe.Rows[e.RowIndex];
            txtCMND.Text = row.Cells[2].Value.ToString();
            txtMaChuyenBay.Text = row.Cells[3].Value.ToString();
            txtHangVe.Text = row.Cells[4].Value.ToString();
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
        private void txtMaChuyenBay_TextChanged(object sender, EventArgs e)
        {
            BUS_ChuyenBay busChuyenBay = new BUS_ChuyenBay();
            DataTable dtChuyenBay = busChuyenBay.GetOfMaChuyenBay(txtMaChuyenBay.Text);
            if (dtChuyenBay.Rows.Count == 0)
            {
                txtMaTuyenBay.Clear();
                txtSanBayDi.Clear();
                txtSanBayDen.Clear();
                txtThoiGianKhoiHanh.Clear();
                txtThoiGianDen.Clear();
                txtThoiGIanBay.Clear();
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
        #endregion
    }
}