
namespace Quản_lý_bán_vé_máy_bay
{
    partial class FrmBanVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanVe));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxDSVe = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtgvVe = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbxTTVe = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLoaiVe = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtThoiGianDen = new System.Windows.Forms.TextBox();
            this.btnChiTietGheTrong = new System.Windows.Forms.Button();
            this.txtThoiGIanBay = new System.Windows.Forms.TextBox();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoGheTrong = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtSanBayDen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThoiGianKhoiHanh = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboHangVe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaTuyenBay = new System.Windows.Forms.TextBox();
            this.txtSanBayDi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnKhuHoi = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnMuaVe = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxDSVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVe)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxTTVe.SuspendLayout();
            this.gbxThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDSVe
            // 
            this.gbxDSVe.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDSVe.Controls.Add(this.btnTimKiem);
            this.gbxDSVe.Controls.Add(this.dtgvVe);
            this.gbxDSVe.Controls.Add(this.label18);
            this.gbxDSVe.Controls.Add(this.txtTimKiem);
            this.gbxDSVe.Location = new System.Drawing.Point(398, 59);
            this.gbxDSVe.Name = "gbxDSVe";
            this.gbxDSVe.Size = new System.Drawing.Size(897, 602);
            this.gbxDSVe.TabIndex = 29;
            this.gbxDSVe.TabStop = false;
            this.gbxDSVe.Text = "Danh sách vé";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTimKiem.Location = new System.Drawing.Point(855, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(33, 31);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtgvVe
            // 
            this.dtgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVe.Location = new System.Drawing.Point(9, 62);
            this.dtgvVe.Name = "dtgvVe";
            this.dtgvVe.RowHeadersWidth = 51;
            this.dtgvVe.RowTemplate.Height = 24;
            this.dtgvVe.Size = new System.Drawing.Size(879, 533);
            this.dtgvVe.TabIndex = 9;
            this.dtgvVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVe_CellClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(607, 39);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Tìm kiếm ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(683, 33);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(165, 22);
            this.txtTimKiem.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 55);
            this.panel1.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(550, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(223, 29);
            this.label17.TabIndex = 39;
            this.label17.Text = "BÁN VÉ MÁY BAY";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1240, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 55);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbxTTVe
            // 
            this.gbxTTVe.Controls.Add(this.label22);
            this.gbxTTVe.Controls.Add(this.txtLoaiVe);
            this.gbxTTVe.Controls.Add(this.label19);
            this.gbxTTVe.Controls.Add(this.txtThoiGianDen);
            this.gbxTTVe.Controls.Add(this.btnChiTietGheTrong);
            this.gbxTTVe.Controls.Add(this.txtThoiGIanBay);
            this.gbxTTVe.Controls.Add(this.cboMaChuyenBay);
            this.gbxTTVe.Controls.Add(this.label1);
            this.gbxTTVe.Controls.Add(this.label13);
            this.gbxTTVe.Controls.Add(this.label6);
            this.gbxTTVe.Controls.Add(this.txtGiaTien);
            this.gbxTTVe.Controls.Add(this.txtTenKhachHang);
            this.gbxTTVe.Controls.Add(this.txtSoGheTrong);
            this.gbxTTVe.Controls.Add(this.txtSDT);
            this.gbxTTVe.Controls.Add(this.txtSanBayDen);
            this.gbxTTVe.Controls.Add(this.label14);
            this.gbxTTVe.Controls.Add(this.label11);
            this.gbxTTVe.Controls.Add(this.label3);
            this.gbxTTVe.Controls.Add(this.label4);
            this.gbxTTVe.Controls.Add(this.txtCMND);
            this.gbxTTVe.Controls.Add(this.label10);
            this.gbxTTVe.Controls.Add(this.txtThoiGianKhoiHanh);
            this.gbxTTVe.Controls.Add(this.label15);
            this.gbxTTVe.Controls.Add(this.cboHangVe);
            this.gbxTTVe.Controls.Add(this.label9);
            this.gbxTTVe.Controls.Add(this.label12);
            this.gbxTTVe.Controls.Add(this.txtMaTuyenBay);
            this.gbxTTVe.Controls.Add(this.txtSanBayDi);
            this.gbxTTVe.Controls.Add(this.label8);
            this.gbxTTVe.Controls.Add(this.label7);
            this.gbxTTVe.Location = new System.Drawing.Point(12, 59);
            this.gbxTTVe.Name = "gbxTTVe";
            this.gbxTTVe.Size = new System.Drawing.Size(380, 495);
            this.gbxTTVe.TabIndex = 77;
            this.gbxTTVe.TabStop = false;
            this.gbxTTVe.Text = "Thông tin vé";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 471);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 17);
            this.label22.TabIndex = 74;
            this.label22.Text = "Loại vé";
            // 
            // txtLoaiVe
            // 
            this.txtLoaiVe.Location = new System.Drawing.Point(151, 466);
            this.txtLoaiVe.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiVe.Name = "txtLoaiVe";
            this.txtLoaiVe.ReadOnly = true;
            this.txtLoaiVe.Size = new System.Drawing.Size(179, 22);
            this.txtLoaiVe.TabIndex = 73;
            this.txtLoaiVe.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 169);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 17);
            this.label19.TabIndex = 72;
            this.label19.Text = "Thời gian đến";
            // 
            // txtThoiGianDen
            // 
            this.txtThoiGianDen.Location = new System.Drawing.Point(153, 169);
            this.txtThoiGianDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianDen.Name = "txtThoiGianDen";
            this.txtThoiGianDen.ReadOnly = true;
            this.txtThoiGianDen.Size = new System.Drawing.Size(221, 22);
            this.txtThoiGianDen.TabIndex = 69;
            this.txtThoiGianDen.TabStop = false;
            // 
            // btnChiTietGheTrong
            // 
            this.btnChiTietGheTrong.Location = new System.Drawing.Point(286, 393);
            this.btnChiTietGheTrong.Name = "btnChiTietGheTrong";
            this.btnChiTietGheTrong.Size = new System.Drawing.Size(88, 23);
            this.btnChiTietGheTrong.TabIndex = 70;
            this.btnChiTietGheTrong.Text = "Chi tiết";
            this.btnChiTietGheTrong.UseVisualStyleBackColor = true;
            this.btnChiTietGheTrong.Click += new System.EventHandler(this.btnChiTietGheTrong_Click);
            // 
            // txtThoiGIanBay
            // 
            this.txtThoiGIanBay.Location = new System.Drawing.Point(153, 199);
            this.txtThoiGIanBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGIanBay.Name = "txtThoiGIanBay";
            this.txtThoiGIanBay.ReadOnly = true;
            this.txtThoiGIanBay.Size = new System.Drawing.Size(221, 22);
            this.txtThoiGIanBay.TabIndex = 69;
            this.txtThoiGIanBay.TabStop = false;
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(153, 17);
            this.cboMaChuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(221, 24);
            this.cboMaChuyenBay.TabIndex = 0;
            this.cboMaChuyenBay.TextUpdate += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
            this.cboMaChuyenBay.SelectedValueChanged += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sân Bay Đi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 54;
            this.label13.Text = "Mã tuyến bay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Mã chuyến bay";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(151, 436);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.ReadOnly = true;
            this.txtGiaTien.Size = new System.Drawing.Size(179, 22);
            this.txtGiaTien.TabIndex = 68;
            this.txtGiaTien.TabStop = false;
            this.txtGiaTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(152, 270);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(221, 22);
            this.txtTenKhachHang.TabIndex = 2;
            // 
            // txtSoGheTrong
            // 
            this.txtSoGheTrong.Location = new System.Drawing.Point(153, 394);
            this.txtSoGheTrong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoGheTrong.Name = "txtSoGheTrong";
            this.txtSoGheTrong.ReadOnly = true;
            this.txtSoGheTrong.Size = new System.Drawing.Size(127, 22);
            this.txtSoGheTrong.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(152, 310);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(221, 22);
            this.txtSDT.TabIndex = 3;
            // 
            // txtSanBayDen
            // 
            this.txtSanBayDen.Location = new System.Drawing.Point(153, 109);
            this.txtSanBayDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSanBayDen.Name = "txtSanBayDen";
            this.txtSanBayDen.ReadOnly = true;
            this.txtSanBayDen.Size = new System.Drawing.Size(221, 22);
            this.txtSanBayDen.TabIndex = 69;
            this.txtSanBayDen.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 439);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 63;
            this.label14.Text = "VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 441);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 63;
            this.label11.Text = "Giá tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Sân Bay Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Thời gian khởi hành";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(153, 229);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(221, 22);
            this.txtCMND.TabIndex = 1;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 358);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "Tên hạng vé";
            // 
            // txtThoiGianKhoiHanh
            // 
            this.txtThoiGianKhoiHanh.Location = new System.Drawing.Point(153, 139);
            this.txtThoiGianKhoiHanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianKhoiHanh.Name = "txtThoiGianKhoiHanh";
            this.txtThoiGianKhoiHanh.ReadOnly = true;
            this.txtThoiGianKhoiHanh.Size = new System.Drawing.Size(221, 22);
            this.txtThoiGianKhoiHanh.TabIndex = 69;
            this.txtThoiGianKhoiHanh.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 399);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 63;
            this.label15.Text = "Số ghế trống";
            // 
            // cboHangVe
            // 
            this.cboHangVe.FormattingEnabled = true;
            this.cboHangVe.Location = new System.Drawing.Point(153, 351);
            this.cboHangVe.Margin = new System.Windows.Forms.Padding(4);
            this.cboHangVe.Name = "cboHangVe";
            this.cboHangVe.Size = new System.Drawing.Size(221, 24);
            this.cboHangVe.TabIndex = 4;
            this.cboHangVe.TextUpdate += new System.EventHandler(this.cboHangVe_SelectedValueChanged);
            this.cboHangVe.SelectedValueChanged += new System.EventHandler(this.cboHangVe_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 315);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Điện Thoại";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 199);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "Thời gian bay";
            // 
            // txtMaTuyenBay
            // 
            this.txtMaTuyenBay.Location = new System.Drawing.Point(153, 49);
            this.txtMaTuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTuyenBay.Name = "txtMaTuyenBay";
            this.txtMaTuyenBay.ReadOnly = true;
            this.txtMaTuyenBay.Size = new System.Drawing.Size(221, 22);
            this.txtMaTuyenBay.TabIndex = 69;
            this.txtMaTuyenBay.TabStop = false;
            // 
            // txtSanBayDi
            // 
            this.txtSanBayDi.Location = new System.Drawing.Point(153, 79);
            this.txtSanBayDi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSanBayDi.Name = "txtSanBayDi";
            this.txtSanBayDi.ReadOnly = true;
            this.txtSanBayDi.Size = new System.Drawing.Size(221, 22);
            this.txtSanBayDi.TabIndex = 69;
            this.txtSanBayDi.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Tên Khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "CMND";
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.label21);
            this.gbxThaoTac.Controls.Add(this.label20);
            this.gbxThaoTac.Controls.Add(this.btnInHoaDon);
            this.gbxThaoTac.Controls.Add(this.btnKhuHoi);
            this.gbxThaoTac.Controls.Add(this.btnTraCuu);
            this.gbxThaoTac.Controls.Add(this.btnMuaVe);
            this.gbxThaoTac.Controls.Add(this.btnDatVe);
            this.gbxThaoTac.Controls.Add(this.label16);
            this.gbxThaoTac.Controls.Add(this.label5);
            this.gbxThaoTac.Controls.Add(this.label2);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 560);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 101);
            this.gbxThaoTac.TabIndex = 78;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(223, 74);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 17);
            this.label21.TabIndex = 68;
            this.label21.Text = "In Hóa Đơn";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(159, 74);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 17);
            this.label20.TabIndex = 67;
            this.label20.Text = "Khứ hồi";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.BackgroundImage")));
            this.btnInHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInHoaDon.FlatAppearance.BorderSize = 0;
            this.btnInHoaDon.Location = new System.Drawing.Point(238, 22);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(55, 50);
            this.btnInHoaDon.TabIndex = 66;
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnKhuHoi
            // 
            this.btnKhuHoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKhuHoi.BackgroundImage")));
            this.btnKhuHoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhuHoi.FlatAppearance.BorderSize = 0;
            this.btnKhuHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhuHoi.Location = new System.Drawing.Point(153, 20);
            this.btnKhuHoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhuHoi.Name = "btnKhuHoi";
            this.btnKhuHoi.Size = new System.Drawing.Size(70, 50);
            this.btnKhuHoi.TabIndex = 65;
            this.btnKhuHoi.UseVisualStyleBackColor = true;
            this.btnKhuHoi.Click += new System.EventHandler(this.btnKhuHoi_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.BackgroundImage")));
            this.btnTraCuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraCuu.FlatAppearance.BorderSize = 0;
            this.btnTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraCuu.Location = new System.Drawing.Point(317, 21);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(55, 50);
            this.btnTraCuu.TabIndex = 64;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnMuaVe
            // 
            this.btnMuaVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMuaVe.BackgroundImage")));
            this.btnMuaVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuaVe.FlatAppearance.BorderSize = 0;
            this.btnMuaVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaVe.Location = new System.Drawing.Point(7, 22);
            this.btnMuaVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuaVe.Name = "btnMuaVe";
            this.btnMuaVe.Size = new System.Drawing.Size(55, 50);
            this.btnMuaVe.TabIndex = 5;
            this.btnMuaVe.UseVisualStyleBackColor = true;
            this.btnMuaVe.Click += new System.EventHandler(this.btnMuaVe_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDatVe.BackgroundImage")));
            this.btnDatVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatVe.FlatAppearance.BorderSize = 0;
            this.btnDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatVe.Location = new System.Drawing.Point(79, 22);
            this.btnDatVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(55, 50);
            this.btnDatVe.TabIndex = 6;
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(299, 74);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 63;
            this.label16.Text = "Tra cứu CB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Đặt vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Mua vé";
            // 
            // FrmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 668);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.gbxTTVe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDSVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBanVe";
            this.Text = "Bán vé chuyến bay";
            this.Shown += new System.EventHandler(this.frmBanVe_Shown);
            this.gbxDSVe.ResumeLayout(false);
            this.gbxDSVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxTTVe.ResumeLayout(false);
            this.gbxTTVe.PerformLayout();
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxDSVe;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dtgvVe;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxTTVe;
        private System.Windows.Forms.Button btnChiTietGheTrong;
        private System.Windows.Forms.TextBox txtThoiGIanBay;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSoGheTrong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSanBayDen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThoiGianKhoiHanh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboHangVe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaTuyenBay;
        private System.Windows.Forms.TextBox txtSanBayDi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnMuaVe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtThoiGianDen;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnKhuHoi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtLoaiVe;
    }
}