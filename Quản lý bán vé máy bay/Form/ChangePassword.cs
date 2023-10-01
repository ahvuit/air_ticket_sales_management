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
    public partial class FrmChangePassword : Form
    {
        #region Properties
        BUS_NhanVien busNhanVien;
        DTO_NhanVien dtoNhanVien;
        private string maNhanVien;
        private string userName;
        private string pass;
        #endregion

        #region Initializes
        public FrmChangePassword(DataRow row)
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
            this.userName = row["USERNAME"].ToString();
            this.maNhanVien = row["MANHANVIEN"].ToString();
            this.pass = row["PASSWORD"].ToString();
        }
        #endregion

        #region methods
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadForm()
        {
            txtUsername.Text = userName;
            txtPassParent.Focus();
            txtPassParent.TabIndex = 0;
            txtPassNew.TabIndex = 1;
            txtPassNew2.TabIndex = 2;
            btnLuu.TabIndex = 4;
            btnThoat.TabIndex = 5;
        }

        private void FrmChangePassword_Shown(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void ClearForm()
        {
            LoadForm();
            txtPassParent.Clear(); ;
            txtPassNew.Clear();
            txtPassNew2.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassParent.Text.Trim() == "" && txtPassNew2.Text.Trim() == "" && txtPassNew.Text.Trim() == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                if(txtPassNew.Text.Trim() != txtPassNew2.Text.Trim())
                    throw new Exception("Mật khẩu nhập không khớp!");
                if(txtPassParent.Text != pass)
                    throw new Exception("Sai mật khẩu!");
                dtoNhanVien = new DTO_NhanVien(maNhanVien, null, null, txtPassNew.Text, null);
                if (busNhanVien.Update1(dtoNhanVien))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }  
                else
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
