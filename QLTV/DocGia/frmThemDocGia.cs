using System;
using System.Windows.Forms;
using System.IO;
using BEL;
using BAL;

namespace QLTV.DocGia
{
    public partial class frmThemDocGia : Form
    {
        public frmThemDocGia()
        {
            InitializeComponent();
        }
        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            txtMaDocGia.Text = "DG" + (BAL_DocGia.Count() + 1);
            radDocGiaNam.Checked = true;
            cboLoaiDocGia.DataSource = BAL_LoaiDocGia.Load();
            cboLoaiDocGia.ValueMember = "MaLoai";
            cboLoaiDocGia.DisplayMember = "TenLoai";
        }
        private void frmThemDocGia_KeyDown(object sender, KeyEventArgs e)
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
            string maDocGia = txtMaDocGia.Text;
            string tenDocGia = txtTenDocGia.Text;
            string gioiTinh = radDocGiaNam.Checked == true ? "Nam" : "Nữ";
            DateTime ngaySinh = dtpNgaySinhDocGia.Value;
            string diaChi = txtDiaChiDocGia.Text;
            string dienThoai = txtDienThoaiDocGia.Text;
            string maLoai = BAL_LoaiDocGia.GetIdByName(cboLoaiDocGia.Text);
            string hinhAnh = txtHinhAnhDocGia.Text;
            string trangThai = "Tồn tại";
            BEL_DocGia docGia = new BEL_DocGia(maDocGia, tenDocGia, gioiTinh, ngaySinh, diaChi, dienThoai, maLoai, hinhAnh, trangThai);
            //
            try
            {
                if (BAL_DocGia.Add(docGia))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    txtMaDocGia.Text = "DG" + (BAL_DocGia.Count() + 1);
                    txtTenDocGia.Text = "";
                    txtDiaChiDocGia.Text = "";
                    txtDienThoaiDocGia.Text = "";
                    txtHinhAnhDocGia.Text = "";
                    picDocGia.ImageLocation = "";
                    txtTenDocGia.Focus();
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
        private void btnHinhAnhDocGia_Click(object sender, EventArgs e)
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
                if (!File.Exists(@"..\..\..\IMAGE\DOCGIA\" + name))
                {
                    File.Copy(fileName, (@"..\..\..\IMAGE\DOCGIA\" + name));
                }
                picDocGia.ImageLocation = fileName;
                txtHinhAnhDocGia.Text = name;
            }
        }
        //
        private void txtTenDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenDocGia.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtDiaChiDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDiaChiDocGia.Text.Length > 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtDienThoaiDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtDienThoaiDocGia.Text.Length > 9)
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
