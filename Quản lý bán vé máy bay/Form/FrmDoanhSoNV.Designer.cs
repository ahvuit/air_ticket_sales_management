
namespace Quản_lý_bán_vé_máy_bay
{
    partial class FrmDoanhSoNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoanhSoNV));
            this.crpDoanhSoNV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crpDoanhSoNV
            // 
            this.crpDoanhSoNV.ActiveViewIndex = -1;
            this.crpDoanhSoNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpDoanhSoNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpDoanhSoNV.Location = new System.Drawing.Point(0, 99);
            this.crpDoanhSoNV.Name = "crpDoanhSoNV";
            this.crpDoanhSoNV.Size = new System.Drawing.Size(1295, 570);
            this.crpDoanhSoNV.TabIndex = 0;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.AutoSize = true;
            this.btnXemBaoCao.Location = new System.Drawing.Point(668, 62);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(105, 35);
            this.btnXemBaoCao.TabIndex = 129;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(551, 71);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(110, 22);
            this.dtpThangNam.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 127;
            this.label1.Text = "Tháng năm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 55);
            this.panel1.TabIndex = 130;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "BÁO CÁO DOANH SỐ NHÂN VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1243, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 55);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmDoanhSoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crpDoanhSoNV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoanhSoNV";
            this.Text = "Doanh số nhân viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpDoanhSoNV;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
    }
}