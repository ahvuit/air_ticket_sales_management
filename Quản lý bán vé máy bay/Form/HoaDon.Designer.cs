
namespace Quản_lý_bán_vé_máy_bay
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            this.crvHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvHoaDon
            // 
            this.crvHoaDon.ActiveViewIndex = -1;
            this.crvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crvHoaDon.Name = "crvHoaDon";
            this.crvHoaDon.Size = new System.Drawing.Size(1346, 642);
            this.crvHoaDon.TabIndex = 0;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 642);
            this.Controls.Add(this.crvHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHoaDon;
    }
}