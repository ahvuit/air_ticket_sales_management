using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
namespace Quản_lý_bán_vé_máy_bay
{
    public partial class Login : Form
    {
        #region Properties
        BUS_NhanVien busNhanVien;
        #endregion

        #region Initializes
        public Login()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
            KhoiTaoGiaoDien();
        }
        #endregion

        #region Method
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNhanVien = busNhanVien.GetOfUsernameAndPassword(txtUsername.Text, txtPassword.Text);
                if (dtNhanVien.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    DataRow row = dtNhanVien.Rows[0];
                    Form frm = new Main(row);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void KhoiTaoGiaoDien()
        {
            txtUsername.Focus();

            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            buttonLogin.TabIndex = 2;
            labelClear.TabIndex = 3;
            labelExit.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;

            AcceptButton = buttonLogin;
        }
        #endregion
    }
}
