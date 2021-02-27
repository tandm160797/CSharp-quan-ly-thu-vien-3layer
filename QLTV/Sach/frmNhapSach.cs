using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using QLTV.TacGia;
using QLTV.NhaXuatBan;
using QLTV.NgonNgu;
using QLTV.LoaiSach;
using BEL;
using BAL;


namespace QLTV.Sach
{
    public partial class frmNhapSach : Form
    {
        public frmNhapSach()
        {
            InitializeComponent();
        }
        private List<BEL_Sach> danhSachSach = new List<BEL_Sach>();
        public string maNhanVienDangNhap { get; set; }
        private void frmThemSach_Load(object sender, EventArgs e)
        {
            cboMaSach.DataSource = BAL_Sach.LoadId();
            cboMaSach.ValueMember = "MaSach";
            cboMaSach.DisplayMember = "MaSach";
            //
            cboLoaiSach.DataSource = BAL_LoaiSach.Load();
            cboLoaiSach.ValueMember = "MaLoai";
            cboLoaiSach.DisplayMember = "TenLoai";
            //
            cboTacGia.DataSource = BAL_TacGia.Load();
            cboTacGia.ValueMember = "MaTacGia";
            cboTacGia.DisplayMember = "TenTacGia";
            //
            cboNgonNgu.DataSource = BAL_NgonNgu.Load();
            cboNgonNgu.ValueMember = "MaNgonNgu";
            cboNgonNgu.DisplayMember = "TenNgonNgu";
            //
            cboNhaXuatBan.DataSource = BAL_NhaXuatBan.Load();
            cboNhaXuatBan.ValueMember = "MaNhaXuatBan";
            cboNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            //
            blockButton(true);
        }
        private void frmThemSach_KeyDown(object sender, KeyEventArgs e)
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
        //
        private void txtTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenSach.Text.Length > 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtNamXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtNamXuatBan.Text.Length > 3)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtSoLuong.Text.Length > 6)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtGiaNhap.Text.Length > 9)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void rtfMoTaSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rtfMoTaSach.Text.Length > 200)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        //
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            string maSach = cboMaSach.Text;
            string tenSach = txtTenSach.Text;
            string maLoai = BAL_LoaiSach.GetIdByName(cboLoaiSach.Text);
            string maTacGia = BAL_TacGia.GetIdByName(cboTacGia.Text);
            string maNgonNgu = BAL_NgonNgu.GetIdByName(cboNgonNgu.Text);
            string maNhaXuatBan = BAL_NhaXuatBan.GetIdByName(cboNhaXuatBan.Text);
            string namXuatBan = txtNamXuatBan.Text;
            string soLuong = txtSoLuong.Text;
            string giaNhap = txtGiaNhap.Text;
            string moTa = rtfMoTaSach.Text;
            string hinhAnh = txtHinhAnhSach.Text;
            string trangThai = "Tồn tại";
            BEL_Sach sach = new BEL_Sach(maSach, tenSach, maLoai, maTacGia, maNgonNgu, maNhaXuatBan, namXuatBan, soLuong, giaNhap, moTa, hinhAnh, trangThai);
            bool error = false;
            //
            if (sach.MaSach == "")
            {
                MessageBox.Show("Mã sách không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.TenSach == "")
            {
                MessageBox.Show("Tên sách không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.MaLoai == "")
            {
                MessageBox.Show("Mã loại không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.MaTacGia == null)
            {
                MessageBox.Show("Mã tác giả không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.MaNgonNgu == "")
            {
                MessageBox.Show("Mã ngôn ngữ không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.MaNhaXuatBan == "")
            {
                MessageBox.Show("Mã nhà xuất bản không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.StringNamXuatBan == "")
            {
                MessageBox.Show("Năm xuất bản không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.StringSoLuong == "")
            {
                MessageBox.Show("Số lượng không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (int.Parse(sach.StringSoLuong) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.StringGiaNhap == "")
            {
                MessageBox.Show("Giá nhập không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.MoTa == "")
            {
                MessageBox.Show("Mô tả không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.HinhAnh == "")
            {
                MessageBox.Show("Hình ảnh không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else if (sach.TrangThai == "")
            {
                MessageBox.Show("Trạng thái không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            if (!error)
            {
                danhSachSach.Add(sach);
                cboMaSach.Text = "S" + (BAL_Sach.Count() + danhSachSach.Count + 1);
                txtTenSach.Text = "";
                txtNamXuatBan.Text = "";
                txtSoLuong.Text = "";
                txtGiaNhap.Text = "";
                rtfMoTaSach.Text = "";
                txtHinhAnhSach.Text = "";
                picSach.ImageLocation = "";
                txtTenSach.Focus();
                MessageBox.Show("Đã thêm sách tạm thời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSachSach.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập sách vào danh sách tạm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < danhSachSach.Count; i++)
                    {
                        if(BAL_Sach.IsExist(danhSachSach[i].TenSach, danhSachSach[i].MaTacGia))
                        {
                            BAL_Sach.Update(danhSachSach[i]);
                        }
                        else
                        {
                            if (BAL_Sach.Add(danhSachSach[i]))
                            {
                                cboMaSach.Text = "S" + (BAL_Sach.Count() + danhSachSach.Count + 1);
                                txtTenSach.Text = "";
                                txtNamXuatBan.Text = "";
                                txtSoLuong.Text = "";
                                txtGiaNhap.Text = "";
                                rtfMoTaSach.Text = "";
                                txtHinhAnhSach.Text = "";
                                picSach.ImageLocation = "";
                                txtTenSach.Focus();
                            }
                        }
                    }
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //
                string maHoaDon = "HD" + BAL_HoaDonNhap.Count();
                string maNhanVien = this.maNhanVienDangNhap;
                DateTime ngayLap = DateTime.Now;
                int tongTien = 0;
                for (int i = 0; i < danhSachSach.Count; i++)
                {
                   tongTien += (int.Parse(danhSachSach[i].StringGiaNhap) * int.Parse(danhSachSach[i].StringSoLuong));
                }
                string trangThai = "Tồn tại";
                BEL_HoaDonNhap hoaDonNhap = new BEL_HoaDonNhap(maHoaDon, maNhanVien, ngayLap, tongTien, trangThai);
                BAL_HoaDonNhap.Add(hoaDonNhap);
                //
                for (int i = 0; i < danhSachSach.Count; i++)
                {
                    BEL_ChiTietHoaDonNhap chiTietHoaDonNhap = new BEL_ChiTietHoaDonNhap(maHoaDon, danhSachSach[i].MaSach, int.Parse(danhSachSach[i].StringSoLuong));
                    BAL_ChiTietHoaDonNhap.Add(chiTietHoaDonNhap);
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
        private void btnHinhAnhSach_Click(object sender, EventArgs e)
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
                if (!File.Exists(@"..\..\..\IMAGE\SACH\" + name))
                {
                    File.Copy(fileName, (@"..\..\..\IMAGE\SACH\" + name));
                }
                picSach.ImageLocation = fileName;
                txtHinhAnhSach.Text = name;
            }
        }
        private void btnThemMaSach_Click(object sender, EventArgs e)
        {
            cboMaSach.DropDownStyle = ComboBoxStyle.DropDown;
            cboMaSach.Text = "S" + (BAL_Sach.Count() + 1);
            blockButton(false);
        }
        private void btnThemLoaiSach_Click(object sender, EventArgs e)
        {
            frmThemLoaiSach frmThemLoaiSach = new frmThemLoaiSach();
            frmThemLoaiSach.ShowDialog();
            //
            cboLoaiSach.DataSource = BAL_LoaiSach.Load();
            //
            this.Show();
        }
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            frmThemTacGia frmThemTacGia = new frmThemTacGia();
            frmThemTacGia.ShowDialog();
            //
            cboTacGia.DataSource = BAL_TacGia.Load();
            this.Show();
        }
        private void btnThemNgonNgu_Click(object sender, EventArgs e)
        {
            frmThemNgonNgu frmThemNgonNgu = new frmThemNgonNgu();
            frmThemNgonNgu.ShowDialog();
            //
            cboNgonNgu.DataSource = BAL_NgonNgu.Load();
            //
            this.Show();
        }
        private void btnThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmThemNhaXuatBan frmThemNhaXuatBan = new frmThemNhaXuatBan();
            frmThemNhaXuatBan.ShowDialog();
            //
            cboNhaXuatBan.DataSource = BAL_NhaXuatBan.Load();
            //
            this.Show();
        }
        //
        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSach = cboMaSach.SelectedValue.ToString();
            BEL_Sach sach = BAL_Sach.GetObjectById(maSach);
            if (sach != null)
            {
                string imagePath = string.Format(@"..\..\..\IMAGE\SACH\{0}", sach.HinhAnh);
                cboMaSach.SelectedValue = sach.MaSach;
                txtTenSach.Text = sach.TenSach;
                cboLoaiSach.SelectedValue = sach.MaLoai;
                cboTacGia.SelectedValue = sach.MaTacGia;
                cboNgonNgu.SelectedValue = sach.MaNgonNgu;
                cboNhaXuatBan.SelectedValue = sach.MaNhaXuatBan;
                txtNamXuatBan.Text = sach.NamXuatBan.ToString();
                txtSoLuong.Text = sach.SoLuong.ToString();
                txtGiaNhap.Text = sach.GiaNhap.ToString();
                rtfMoTaSach.Text = sach.MoTa;
                txtHinhAnhSach.Text = sach.HinhAnh;
                picSach.ImageLocation = imagePath;
            }
            blockButton(true);
            txtSoLuong.Enabled = true;
            txtGiaNhap.Enabled = true;
        }
        private void cboTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenSach = txtTenSach.Text;
            string tacGia = cboTacGia.SelectedValue.ToString();
            //
            if (BAL_Sach.IsExist(tenSach, tacGia))
            {
                string maSach = BAL_Sach.GetIdByName(tenSach);
                BEL_Sach sach = BAL_Sach.GetObjectById(maSach);
                cboMaSach.Text = sach.MaSach;
            }
            else
            {
                cboMaSach.Text = "S" + (BAL_Sach.Count() + danhSachSach.Count + 1);
            }
        }
        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            string tenSach = txtTenSach.Text;
            string tacGia = cboTacGia.SelectedValue.ToString();
            //
            if (BAL_Sach.IsExist(tenSach, tacGia))
            {
                string maSach = BAL_Sach.GetIdByName(tenSach);
                BEL_Sach sach = BAL_Sach.GetObjectById(maSach);
                cboMaSach.Text = sach.MaSach;
            }
            else
            {
                cboMaSach.Text = "S" + (BAL_Sach.Count() + danhSachSach.Count + 1);
            }
        }
        //
        private void blockButton(bool value)
        {
            txtTenSach.Enabled = !value;
            txtNamXuatBan.Enabled = !value;
            txtSoLuong.Enabled = !value;
            txtGiaNhap.Enabled = !value;
            rtfMoTaSach.Enabled = !value;
        }
    }
}
