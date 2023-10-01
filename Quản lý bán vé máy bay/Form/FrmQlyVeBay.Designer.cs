
namespace Quản_lý_bán_vé_máy_bay
{
    partial class FrmQlyVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQlyVe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnHoanVe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDoiVe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxDSMayBay = new System.Windows.Forms.GroupBox();
            this.dtgvVeKhach = new System.Windows.Forms.DataGridView();
            this.tabCtrQlyVe = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxThaoTac.SuspendLayout();
            this.gbxDSMayBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVeKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 55);
            this.panel1.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ VÉ KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaVe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbTimKiem);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vé";
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(123, 47);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(209, 22);
            this.txtMaVe.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã khách hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(123, 99);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(209, 22);
            this.txtMaKhachHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vé:";
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(274, 208);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(60, 17);
            this.lbTimKiem.TabIndex = 92;
            this.lbTimKiem.Text = "Kiểm tra";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(277, 154);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(55, 50);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnHoanVe);
            this.gbxThaoTac.Controls.Add(this.label6);
            this.gbxThaoTac.Controls.Add(this.btnDoiVe);
            this.gbxThaoTac.Controls.Add(this.label5);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 523);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Size = new System.Drawing.Size(349, 136);
            this.gbxThaoTac.TabIndex = 69;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // btnHoanVe
            // 
            this.btnHoanVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoanVe.BackgroundImage")));
            this.btnHoanVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoanVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanVe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHoanVe.Location = new System.Drawing.Point(212, 21);
            this.btnHoanVe.Name = "btnHoanVe";
            this.btnHoanVe.Size = new System.Drawing.Size(86, 81);
            this.btnHoanVe.TabIndex = 4;
            this.btnHoanVe.UseVisualStyleBackColor = true;
            this.btnHoanVe.Click += new System.EventHandler(this.btnHoanVe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 97;
            this.label6.Text = "Hoàn vé";
            // 
            // btnDoiVe
            // 
            this.btnDoiVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoiVe.BackgroundImage")));
            this.btnDoiVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiVe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDoiVe.Location = new System.Drawing.Point(44, 40);
            this.btnDoiVe.Name = "btnDoiVe";
            this.btnDoiVe.Size = new System.Drawing.Size(82, 62);
            this.btnDoiVe.TabIndex = 3;
            this.btnDoiVe.UseVisualStyleBackColor = true;
            this.btnDoiVe.Click += new System.EventHandler(this.btnDoiVe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đổi vé";
            // 
            // gbxDSMayBay
            // 
            this.gbxDSMayBay.Controls.Add(this.dtgvVeKhach);
            this.gbxDSMayBay.Location = new System.Drawing.Point(369, 61);
            this.gbxDSMayBay.Name = "gbxDSMayBay";
            this.gbxDSMayBay.Size = new System.Drawing.Size(928, 127);
            this.gbxDSMayBay.TabIndex = 70;
            this.gbxDSMayBay.TabStop = false;
            this.gbxDSMayBay.Text = "Thông tin vé";
            // 
            // dtgvVeKhach
            // 
            this.dtgvVeKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVeKhach.Location = new System.Drawing.Point(6, 21);
            this.dtgvVeKhach.Name = "dtgvVeKhach";
            this.dtgvVeKhach.RowHeadersWidth = 51;
            this.dtgvVeKhach.RowTemplate.Height = 24;
            this.dtgvVeKhach.Size = new System.Drawing.Size(916, 100);
            this.dtgvVeKhach.TabIndex = 7;
            this.dtgvVeKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVeKhach_CellClick);
            // 
            // tabCtrQlyVe
            // 
            this.tabCtrQlyVe.Location = new System.Drawing.Point(369, 188);
            this.tabCtrQlyVe.Name = "tabCtrQlyVe";
            this.tabCtrQlyVe.SelectedIndex = 0;
            this.tabCtrQlyVe.Size = new System.Drawing.Size(926, 471);
            this.tabCtrQlyVe.TabIndex = 71;
            // 
            // FrmQlyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 668);
            this.Controls.Add(this.tabCtrQlyVe);
            this.Controls.Add(this.gbxDSMayBay);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQlyVe";
            this.Text = "Quản lý vé";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.gbxDSMayBay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVeKhach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.GroupBox gbxDSMayBay;
        private System.Windows.Forms.DataGridView dtgvVeKhach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDoiVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TabControl tabCtrQlyVe;
        private System.Windows.Forms.Button btnHoanVe;
        private System.Windows.Forms.Button btnThoat;
    }
}