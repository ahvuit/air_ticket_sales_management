﻿
namespace Quản_lý_bán_vé_máy_bay
{
    partial class FrmTraCuuChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTraCuuChuyenBay));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxTTChuyenBay = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cboSanBayDen = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpNgayKHDen = new System.Windows.Forms.DateTimePicker();
            this.cboSanBayDi = new System.Windows.Forms.ComboBox();
            this.dtpNgayKHTu = new System.Windows.Forms.DateTimePicker();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.lbBanVe = new System.Windows.Forms.Label();
            this.btnChonChuyenBay = new System.Windows.Forms.Button();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxDSChyenBay = new System.Windows.Forms.GroupBox();
            this.dtgvChuyenBay = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbxTTChuyenBay.SuspendLayout();
            this.gbxThaoTac.SuspendLayout();
            this.gbxDSChyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 55);
            this.panel1.TabIndex = 121;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1240, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "TRA CỨU CHUYẾN BAY";
            // 
            // gbxTTChuyenBay
            // 
            this.gbxTTChuyenBay.BackColor = System.Drawing.SystemColors.Control;
            this.gbxTTChuyenBay.Controls.Add(this.label20);
            this.gbxTTChuyenBay.Controls.Add(this.label18);
            this.gbxTTChuyenBay.Controls.Add(this.cboSanBayDen);
            this.gbxTTChuyenBay.Controls.Add(this.label19);
            this.gbxTTChuyenBay.Controls.Add(this.dtpNgayKHDen);
            this.gbxTTChuyenBay.Controls.Add(this.cboSanBayDi);
            this.gbxTTChuyenBay.Controls.Add(this.dtpNgayKHTu);
            this.gbxTTChuyenBay.Controls.Add(this.txtMaChuyenBay);
            this.gbxTTChuyenBay.Controls.Add(this.label15);
            this.gbxTTChuyenBay.Controls.Add(this.label3);
            this.gbxTTChuyenBay.Location = new System.Drawing.Point(12, 61);
            this.gbxTTChuyenBay.Name = "gbxTTChuyenBay";
            this.gbxTTChuyenBay.Size = new System.Drawing.Size(380, 495);
            this.gbxTTChuyenBay.TabIndex = 122;
            this.gbxTTChuyenBay.TabStop = false;
            this.gbxTTChuyenBay.Text = "Thông tin chuyến bay";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 33);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "Mã chuyến bay ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 102);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 17);
            this.label18.TabIndex = 13;
            this.label18.Text = "Sân bay đến";
            // 
            // cboSanBayDen
            // 
            this.cboSanBayDen.FormattingEnabled = true;
            this.cboSanBayDen.Location = new System.Drawing.Point(174, 95);
            this.cboSanBayDen.Name = "cboSanBayDen";
            this.cboSanBayDen.Size = new System.Drawing.Size(200, 24);
            this.cboSanBayDen.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 70);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 17);
            this.label19.TabIndex = 16;
            this.label19.Text = "Sân bay đi";
            // 
            // dtpNgayKHDen
            // 
            this.dtpNgayKHDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKHDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKHDen.Location = new System.Drawing.Point(174, 169);
            this.dtpNgayKHDen.Name = "dtpNgayKHDen";
            this.dtpNgayKHDen.Size = new System.Drawing.Size(199, 22);
            this.dtpNgayKHDen.TabIndex = 4;
            // 
            // cboSanBayDi
            // 
            this.cboSanBayDi.FormattingEnabled = true;
            this.cboSanBayDi.Location = new System.Drawing.Point(174, 63);
            this.cboSanBayDi.Name = "cboSanBayDi";
            this.cboSanBayDi.Size = new System.Drawing.Size(200, 24);
            this.cboSanBayDi.TabIndex = 1;
            // 
            // dtpNgayKHTu
            // 
            this.dtpNgayKHTu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKHTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKHTu.Location = new System.Drawing.Point(174, 134);
            this.dtpNgayKHTu.Name = "dtpNgayKHTu";
            this.dtpNgayKHTu.Size = new System.Drawing.Size(199, 22);
            this.dtpNgayKHTu.TabIndex = 3;
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.Location = new System.Drawing.Point(173, 28);
            this.txtMaChuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.ReadOnly = true;
            this.txtMaChuyenBay.Size = new System.Drawing.Size(200, 22);
            this.txtMaChuyenBay.TabIndex = 17;
            this.txtMaChuyenBay.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 139);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 17);
            this.label15.TabIndex = 87;
            this.label15.Text = "Ngày khởi hành từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "đến";
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.BackColor = System.Drawing.SystemColors.Control;
            this.gbxThaoTac.Controls.Add(this.lbBanVe);
            this.gbxThaoTac.Controls.Add(this.btnChonChuyenBay);
            this.gbxThaoTac.Controls.Add(this.lbTimKiem);
            this.gbxThaoTac.Controls.Add(this.btnTimKiem);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 562);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 101);
            this.gbxThaoTac.TabIndex = 123;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // lbBanVe
            // 
            this.lbBanVe.AutoSize = true;
            this.lbBanVe.Location = new System.Drawing.Point(206, 78);
            this.lbBanVe.Name = "lbBanVe";
            this.lbBanVe.Size = new System.Drawing.Size(118, 17);
            this.lbBanVe.TabIndex = 93;
            this.lbBanVe.Text = "Chọn chuyến bay";
            // 
            // btnChonChuyenBay
            // 
            this.btnChonChuyenBay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChonChuyenBay.BackgroundImage")));
            this.btnChonChuyenBay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonChuyenBay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonChuyenBay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChonChuyenBay.Location = new System.Drawing.Point(229, 22);
            this.btnChonChuyenBay.Name = "btnChonChuyenBay";
            this.btnChonChuyenBay.Size = new System.Drawing.Size(55, 50);
            this.btnChonChuyenBay.TabIndex = 6;
            this.btnChonChuyenBay.UseVisualStyleBackColor = true;
            this.btnChonChuyenBay.Click += new System.EventHandler(this.btnBanVe_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(90, 78);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(64, 17);
            this.lbTimKiem.TabIndex = 91;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(95, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(55, 50);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxDSChyenBay
            // 
            this.gbxDSChyenBay.BackColor = System.Drawing.SystemColors.Control;
            this.gbxDSChyenBay.Controls.Add(this.dtgvChuyenBay);
            this.gbxDSChyenBay.Location = new System.Drawing.Point(398, 62);
            this.gbxDSChyenBay.Name = "gbxDSChyenBay";
            this.gbxDSChyenBay.Size = new System.Drawing.Size(897, 602);
            this.gbxDSChyenBay.TabIndex = 124;
            this.gbxDSChyenBay.TabStop = false;
            this.gbxDSChyenBay.Text = "Danh sách chuyến bay";
            // 
            // dtgvChuyenBay
            // 
            this.dtgvChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenBay.Location = new System.Drawing.Point(6, 21);
            this.dtgvChuyenBay.Name = "dtgvChuyenBay";
            this.dtgvChuyenBay.RowHeadersWidth = 51;
            this.dtgvChuyenBay.RowTemplate.Height = 24;
            this.dtgvChuyenBay.Size = new System.Drawing.Size(885, 575);
            this.dtgvChuyenBay.TabIndex = 7;
            this.dtgvChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChuyenBay_CellClick);
            // 
            // FrmTraCuuChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 668);
            this.Controls.Add(this.gbxDSChyenBay);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.gbxTTChuyenBay);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTraCuuChuyenBay";
            this.Text = "Tra cứu chuyến bay";
            this.Shown += new System.EventHandler(this.frmTraCuuChuyenBay_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxTTChuyenBay.ResumeLayout(false);
            this.gbxTTChuyenBay.PerformLayout();
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.gbxDSChyenBay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxTTChuyenBay;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpNgayKHDen;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayKHTu;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Label lbBanVe;
        private System.Windows.Forms.Button btnChonChuyenBay;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxDSChyenBay;
        private System.Windows.Forms.DataGridView dtgvChuyenBay;
        private System.Windows.Forms.Button button1;
    }
}