using System;
using System.Windows.Forms;
using System.IO;
using BAL;
using BEL;

namespace QLTV.NhanVien
{
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }
        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "NV" + (BAL_NhanVien.Count() + 1);
            radNhanVienNam.Checked = true;
            cboLoaiNhanVien.DataSource = BAL_LoaiNhanVien.Load();
            cboLoaiNhanVien.ValueMember = "MaLoai";
            cboLoaiNhanVien.DisplayMember = "TenLoai";
        }
        private void frmThemNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnThem_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnHuy_Click(sender, e);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text;
            string tenNhanVien = txtTenNhanVien.Text;
            string gioiTinh = radNhanVienNam.Checked == true ? "Nam" : "Nữ";
            DateTime ngaySinh = dtpNgaySinhNhanVien.Value;
            string diaChi = txtDiaChiNhanVien.Text;
            string dienThoai = txtDienThoaiNhanVien.Text;
            string maLoai = BAL_LoaiNhanVien.GetIdByName(cboLoaiNhanVien.Text);
            string matKhau = txtMatKhau.Text;
            string hinhAnh = txtHinhAnhNhanVien.Text;
            string trangThai = "Tồn tại";
            BEL_NhanVien nhanVien = new BEL_NhanVien(maNhanVien, tenNhanVien, gioiTinh, ngaySinh, diaChi, dienThoai, matKhau, maLoai, hinhAnh, trangThai);
            //
            try
            {
                if (BAL_NhanVien.Add(nhanVien))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    txtMaNhanVien.Text = "NV" + (BAL_NhanVien.Count() + 1);
                    txtTenNhanVien.Text = "";
                    txtDiaChiNhanVien.Text = "";
                    txtDienThoaiNhanVien.Text = "";
                    txtMatKhau.Text = "";
                    txtHinhAnhNhanVien.Text = "";
                    picNhanVien.ImageLocation = "";
                    txtTenNhanVien.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnHinhAnhNhanVien_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string fileName = "";
            openFileDialog.Filter = "Image files | *.jpg";
            openFileDialog.InitialDirectory = @"D:";
            openFileDialog.Title = "Open File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                int index = fileName.LastIndexOf(@"\");
                string name = fileName.Substring(index + 1, fileName.Length - index - 1);
                if (!File.Exists(@"..\..\..\IMAGE\NHANVIEN\" + name))
                {
                    File.Copy(fileName, (@"..\..\..\IMAGE\NHANVIEN\" + name));
                }
                picNhanVien.ImageLocation = fileName;
                txtHinhAnhNhanVien.Text = name;
            }
        }
        //
        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenNhanVien.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtDiaChiNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDiaChiNhanVien.Text.Length > 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtDienThoaiNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtDienThoaiNhanVien.Text.Length > 9)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMatKhau.Text.Length > 31)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        //
    }
}
