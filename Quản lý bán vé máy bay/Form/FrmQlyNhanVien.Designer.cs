
namespace Quản_lý_bán_vé_máy_bay
{
    partial class FrmQlyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQlyNhanVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDSNhanVien = new System.Windows.Forms.GroupBox();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.gbxTTNhanVien = new System.Windows.Forms.GroupBox();
            this.radioNV = new System.Windows.Forms.RadioButton();
            this.radioQLy = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.gbxDSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.gbxThaoTac.SuspendLayout();
            this.gbxTTNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label1);
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
            this.btnThoat.TabIndex = 16;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // gbxDSNhanVien
            // 
            this.gbxDSNhanVien.Controls.Add(this.dtgvNhanVien);
            this.gbxDSNhanVien.Controls.Add(this.label2);
            this.gbxDSNhanVien.Controls.Add(this.txtTimKiem);
            this.gbxDSNhanVien.Controls.Add(this.btnTimKiem);
            this.gbxDSNhanVien.Location = new System.Drawing.Point(398, 61);
            this.gbxDSNhanVien.Name = "gbxDSNhanVien";
            this.gbxDSNhanVien.Size = new System.Drawing.Size(897, 602);
            this.gbxDSNhanVien.TabIndex = 4;
            this.gbxDSNhanVien.TabStop = false;
            this.gbxDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(6, 63);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowHeadersWidth = 51;
            this.dtgvNhanVien.RowTemplate.Height = 24;
            this.dtgvNhanVien.Size = new System.Drawing.Size(885, 533);
            this.dtgvNhanVien.TabIndex = 10;
            this.dtgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tìm kiếm ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(684, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(165, 22);
            this.txtTimKiem.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(857, 26);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(33, 30);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnThem);
            this.gbxThaoTac.Controls.Add(this.label5);
            this.gbxThaoTac.Controls.Add(this.label4);
            this.gbxThaoTac.Controls.Add(this.label3);
            this.gbxThaoTac.Controls.Add(this.btnSua);
            this.gbxThaoTac.Controls.Add(this.btnXoa);
            this.gbxThaoTac.Location = new System.Drawing.Point(12, 562);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Size = new System.Drawing.Size(380, 101);
            this.gbxThaoTac.TabIndex = 6;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(37, 22);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(55, 50);
            this.btnThem.TabIndex = 6;
            this.btnThem.UseCompatibleTextRendering = true;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Xóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sửa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(167, 22);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 50);
            this.btnSua.TabIndex = 7;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(290, 22);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 50);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(173, 28);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(200, 22);
            this.txtMaNhanVien.TabIndex = 17;
            this.txtMaNhanVien.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tên nhân viên";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 33);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Username";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(174, 67);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(200, 22);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(174, 106);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(174, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // gbxTTNhanVien
            // 
            this.gbxTTNhanVien.Controls.Add(this.radioNV);
            this.gbxTTNhanVien.Controls.Add(this.radioQLy);
            this.gbxTTNhanVien.Controls.Add(this.txtPassword);
            this.gbxTTNhanVien.Controls.Add(this.txtUsername);
            this.gbxTTNhanVien.Controls.Add(this.label7);
            this.gbxTTNhanVien.Controls.Add(this.txtTenNhanVien);
            this.gbxTTNhanVien.Controls.Add(this.label6);
            this.gbxTTNhanVien.Controls.Add(this.label20);
            this.gbxTTNhanVien.Controls.Add(this.label9);
            this.gbxTTNhanVien.Controls.Add(this.txtMaNhanVien);
            this.gbxTTNhanVien.Location = new System.Drawing.Point(12, 61);
            this.gbxTTNhanVien.Name = "gbxTTNhanVien";
            this.gbxTTNhanVien.Size = new System.Drawing.Size(380, 495);
            this.gbxTTNhanVien.TabIndex = 5;
            this.gbxTTNhanVien.TabStop = false;
            this.gbxTTNhanVien.Text = "Thông tin nhân viên";
            // 
            // radioNV
            // 
            this.radioNV.AutoSize = true;
            this.radioNV.Location = new System.Drawing.Point(224, 228);
            this.radioNV.Name = "radioNV";
            this.radioNV.Size = new System.Drawing.Size(58, 21);
            this.radioNV.TabIndex = 19;
            this.radioNV.TabStop = true;
            this.radioNV.Text = "Staff";
            this.radioNV.UseVisualStyleBackColor = true;
            this.radioNV.CheckedChanged += new System.EventHandler(this.radioNV_CheckedChanged);
            // 
            // radioQLy
            // 
            this.radioQLy.AutoSize = true;
            this.radioQLy.Location = new System.Drawing.Point(224, 192);
            this.radioQLy.Name = "radioQLy";
            this.radioQLy.Size = new System.Drawing.Size(85, 21);
            this.radioQLy.TabIndex = 18;
            this.radioQLy.TabStop = true;
            this.radioQLy.Text = "Manager";
            this.radioQLy.UseVisualStyleBackColor = true;
            this.radioQLy.CheckedChanged += new System.EventHandler(this.radioQLy_CheckedChanged);
            // 
            // FrmQlyNhanVien
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 668);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.gbxTTNhanVien);
            this.Controls.Add(this.gbxDSNhanVien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQlyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Shown += new System.EventHandler(this.FrmQlyNhanVien_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSNhanVien.ResumeLayout(false);
            this.gbxDSNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.gbxTTNhanVien.ResumeLayout(false);
            this.gbxTTNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDSNhanVien;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox gbxTTNhanVien;
        private System.Windows.Forms.RadioButton radioNV;
        private System.Windows.Forms.RadioButton radioQLy;
    }
}