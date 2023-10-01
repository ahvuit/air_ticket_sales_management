using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_vé_máy_bay
{
    public partial class FrmQlyNhanVien : Form
    {
        #region Properties
        DTO_NhanVien dtoNhanVien;
        BUS_NhanVien busNhanVien;
        string type;
        
        #endregion

        #region Initializes
        public FrmQlyNhanVien()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }
        #endregion

        #region methods
        
        private void TaoBangDSNhanVien()
        {
            DataTable dtNhanVien = busNhanVien.GetForDisplay();
            dtgvNhanVien.DataSource = dtNhanVien;
            dtgvNhanVien.Sort(dtgvNhanVien.Columns[0], ListSortDirection.Ascending);
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void KhoiTaoGiaoDien()
        {
            TaoBangDSNhanVien();
            txtTenNhanVien.Focus();
        }

        private void TaoLai()
        {
            TaoBangDSNhanVien();
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Parent.Dispose();
        }

        private void FrmQlyNhanVien_Shown(object sender, EventArgs e)
        {
            KhoiTaoGiaoDien();
        }


        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dtgvNhanVien.Rows[e.RowIndex];
            txtMaNhanVien.Text = row.Cells[0].Value.ToString();
            txtTenNhanVien.Text = row.Cells[1].Value.ToString();
            txtUsername.Text = row.Cells[2].Value.ToString();
            txtPassword.Text = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value.ToString() == "Manager")
            {
                radioQLy.Checked = true;
                radioNV.Checked = false;
            }
            if (row.Cells[4].Value.ToString() == "Staff")
            {
                radioQLy.Checked = false;
                radioNV.Checked = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvNhanVien.DataSource = busNhanVien.SearchOfMaNhanVien(txtTimKiem.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Console.OutputEncoding = Encoding.Unicode;
            if (txtTenNhanVien.Text.Trim() != "" && txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                try
                {
                    dtoNhanVien = new DTO_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtUsername.Text, txtPassword.Text, type);
                    if (busNhanVien.Add(dtoNhanVien))
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            Console.OutputEncoding = Encoding.Unicode;
            if (txtMaNhanVien.Text.Trim() != "")
            {
                if (txtTenNhanVien.Text.Trim() != "" && txtUsername.Text.Trim() != "" && txtPassword.Text.Trim() != "")
                {
                    try
                    {
                        dtoNhanVien = new DTO_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtUsername.Text, txtPassword.Text, type);
                        if (busNhanVien.Update(dtoNhanVien))
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text.Trim() != "")
            {
                if(radioQLy.Text == "Manager")
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    if (busNhanVien.Delete(txtMaNhanVien.Text))
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception)
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    TaoLai();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void radioQLy_CheckedChanged(object sender, EventArgs e)
        {
            type = "Manager";
        }

        private void radioNV_CheckedChanged(object sender, EventArgs e)
        {
            type = "Staff";
        }
        #endregion
    }
}
