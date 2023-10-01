
namespace Quản_lý_bán_vé_máy_bay
{
    partial class FrmTinhTrangVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTinhTrangVe));
            this.dtgvTinhTrangVe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTinhTrangVe
            // 
            this.dtgvTinhTrangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTinhTrangVe.Location = new System.Drawing.Point(12, 102);
            this.dtgvTinhTrangVe.Name = "dtgvTinhTrangVe";
            this.dtgvTinhTrangVe.RowHeadersWidth = 51;
            this.dtgvTinhTrangVe.RowTemplate.Height = 24;
            this.dtgvTinhTrangVe.Size = new System.Drawing.Size(641, 469);
            this.dtgvTinhTrangVe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã chuyến bay:";
            // 
            // cboMaChuyenBay
            // 
            this.cboMaChuyenBay.FormattingEnabled = true;
            this.cboMaChuyenBay.Location = new System.Drawing.Point(122, 72);
            this.cboMaChuyenBay.Name = "cboMaChuyenBay";
            this.cboMaChuyenBay.Size = new System.Drawing.Size(150, 24);
            this.cboMaChuyenBay.TabIndex = 5;
            this.cboMaChuyenBay.SelectedValueChanged += new System.EventHandler(this.cboMaChuyenBay_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(226, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "TÌNH TRẠNG VÉ";
            // 
            // FrmTinhTrangVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 580);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboMaChuyenBay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvTinhTrangVe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTinhTrangVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tình trạng vé";
            this.Shown += new System.EventHandler(this.frmTinhTrangVe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTinhTrangVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTinhTrangVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaChuyenBay;
        private System.Windows.Forms.Label label8;
    }
}