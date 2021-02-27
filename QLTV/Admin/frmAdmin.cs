using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using BEL;
using BAL;
using QLTV.NhanVien;
using QLTV.DocGia;
using QLTV.TacGia;
using QLTV.NhaXuatBan;
using QLTV.NgonNgu;
using QLTV.LoaiSach;
using QLTV.Sach;

namespace QLTV.Admin
{
    public partial class frmAdmin : Form
    {
        public string tenNhanVienDangNhap { get; set; }
        public string maNhanVienDangNhap { get; set; }
        public frmAdmin()
        {
            InitializeComponent();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            tmrTime.Start();
            DateTime dateTime = DateTime.Now;
            lblNgayGio.Text = dateTime.ToString("  HH:mm:ss \ndd/MM/yyyy");
            lblNhanVienDangNhap.Text = "Xin chào,    " + tenNhanVienDangNhap;
            //
            khoaTextBoxThongTinTimKiem(true);
            //
            loadDanhSachNhanVien(dgvDanhSachNhanVien, BAL_NhanVien.Load());
            //
            loadDanhSachDocGia(dgvDanhSachDocGia, BAL_DocGia.Load());
            //
            loadDanhSachSach(dgvDanhSachSach, BAL_Sach.Load());
            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
            //
            actionNhanVien();
            actionDocGia();
            actionSach();
            //
        }
        private void tabQuanLyThuVien_Click(object sender, EventArgs e)
        {
            actionNhanVien();
            actionDocGia();
            actionSach();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblNgayGio.Text = dateTime.ToString("  HH:mm:ss \ndd/MM/yyyy");
        }
        //
        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNhanVien = dgvDanhSachNhanVien.CurrentRow.Cells["MaNhanVien"].Value.ToString().Trim();
            BEL_NhanVien nhanVien = BAL_NhanVien.GetObjectById(maNhanVien);
            string imagePath = string.Format(@"..\..\..\IMAGE\NHANVIEN\{0}", nhanVien.HinhAnh);
            txtMaNhanVien.Text = nhanVien.Ma;
            txtTenNhanVien.Text = nhanVien.Ten;
            if (nhanVien.GioiTinh == "Nam")
            {
                radNhanVienNam.Checked = true;
            }
            else
            {
                radNhanVienNu.Checked = true;
            }
            dtpNgaySinhNhanVien.Value = nhanVien.NgaySinh;
            txtDiaChiNhanVien.Text = nhanVien.DiaChi;
            txtDienThoaiNhanVien.Text = nhanVien.DienThoai;
            cboLoaiNhanVien.SelectedValue = nhanVien.MaLoai;
            txtHinhAnhNhanVien.Text = nhanVien.HinhAnh;
            picNhanVien.ImageLocation = imagePath;
        }
        private void dgvDanhSachDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maDocGia = dgvDanhSachDocGia.CurrentRow.Cells["MaDocGia"].Value.ToString().Trim();
            BEL_DocGia docGia = BAL_DocGia.GetObjectById(maDocGia);
            string imagePath = string.Format(@"..\..\..\IMAGE\DOCGIA\{0}", docGia.HinhAnh);
            txtMaDocGia.Text = docGia.Ma;
            txtTenDocGia.Text = docGia.Ten;
            if (docGia.GioiTinh == "Nam")
            {
                radDocGiaNam.Checked = true;
            }
            else
            {
                radDocGiaNu.Checked = true;
            }
            dtpNgaySinhDocGia.Value = docGia.NgaySinh;
            txtDiaChiDocGia.Text = docGia.DiaChi;
            txtDienThoaiDocGia.Text = docGia.DienThoai;
            cboLoaiDocGia.SelectedValue = docGia.MaLoai;
            txtHinhAnhDocGia.Text = docGia.HinhAnh;
            picDocGia.ImageLocation = imagePath;
        }
        private void dgvDanhSachSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSach = dgvDanhSachSach.CurrentRow.Cells["MaSach"].Value.ToString().Trim();
            BEL_Sach sach = BAL_Sach.GetObjectById(maSach);
            string imagePath = string.Format(@"..\..\..\IMAGE\SACH\{0}", sach.HinhAnh);
            txtMaSach.Text = sach.MaSach;
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
        private void dgvDanhSachTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maTacGia = dgvDanhSachTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString().Trim();
            BEL_TacGia tacGia = BAL_TacGia.GetObjectById(maTacGia);
            txtMaTacGia.Text = tacGia.Ma;
            txtTenTacGia.Text = tacGia.Ten;
            txtDienThoaiTacGia.Text = tacGia.DienThoai;
        }
        private void dgvDanhSachNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNhaXuatBan = dgvDanhSachNhaXuatBan.CurrentRow.Cells["MaNhaXuatBan"].Value.ToString().Trim();
            BEL_NhaXuatBan nhaXuatBan = BAL_NhaXuatBan.GetObjectById(maNhaXuatBan);
            txtMaNhaXuatBan.Text = nhaXuatBan.Ma;
            txtTenNhaXuatBan.Text = nhaXuatBan.Ten;
            txtEmailNhaXuatBan.Text = nhaXuatBan.Email;
        }
        private void dgvDanhSachNgonNgu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNgonNgu = dgvDanhSachNgonNgu.CurrentRow.Cells["MaNgonNgu"].Value.ToString().Trim();
            BEL_NgonNgu ngonNgu = BAL_NgonNgu.GetObjectById(maNgonNgu);
            txtMaNgonNgu.Text = ngonNgu.Ma;
            txtTenNgonNgu.Text = ngonNgu.Ten;
        }
        private void dgvDanhSachLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maLoaiSach = dgvDanhSachLoaiSach.CurrentRow.Cells["MaLoai"].Value.ToString().Trim();
            BEL_LoaiSach loaiSach = BAL_LoaiSach.GetObjectById(maLoaiSach);
            txtMaLoaiSach.Text = loaiSach.Ma;
            txtTenLoaiSach.Text = loaiSach.Ten;
        }
        //
        private void khoaTextBoxThongTinTimKiem(bool value)
        {
            txtThongTinTimKiemNhanVien.Enabled = !value;
            txtThongTinTimKiemDocGia.Enabled = !value;
            txtThongTinTimKiemSach.Enabled = !value;
            txtThongTinTiemKiemTacGia.Enabled = !value;
            txtThongTinTimKiemNhaXuatBan.Enabled = !value;
            txtThongTinTimKiemNgonNgu.Enabled = !value;
            txtThongTinTimKiemLoaiSach.Enabled = !value;
        }
        //
        private void loadDanhSachNhanVien(DataGridView dgv, DataTable dtb)
        {
            if (dtb != null)
            {
                dgv.DataSource = dtb;
                dgv.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
                dgv.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                dgv.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgv.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgv.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgv.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgv.Columns["TenLoai"].HeaderText = "Loại nhân viên";
                //
                dgv.Columns["MaNhanVien"].Width = (int)dgvDanhSachNhanVien.Width / 7;
                dgv.Columns["TenNhanVien"].Width = (int)dgvDanhSachNhanVien.Width / 7;
                dgv.Columns["GioiTinh"].Width = (int)dgvDanhSachNhanVien.Width / 7;
                dgv.Columns["NgaySinh"].Width = (int)dgvDanhSachNhanVien.Width / 7;
                dgv.Columns["DiaChi"].Width = (int)dgvDanhSachNhanVien.Width / 7;
                dgv.Columns["DienThoai"].Width = (int)dgvDanhSachNhanVien.Width / 7;
                dgv.Columns["TenLoai"].Width = (int)dgvDanhSachNhanVien.Width / 7;
            }
        }
        private void loadDanhSachDocGia(DataGridView dgv, DataTable dtb)
        {
            if (dtb != null)
            {
                dgv.DataSource = dtb;
                //
                dgv.Columns["MaDocGia"].HeaderText = "Mã độc giả";
                dgv.Columns["TenDocGia"].HeaderText = "Tên độc giả";
                dgv.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgv.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgv.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgv.Columns["DienThoai"].HeaderText = "Điện thoại";
                dgv.Columns["TenLoai"].HeaderText = "Tên loại";
                //
                dgv.Columns["MaDocGia"].Width = (int)dgvDanhSachDocGia.Width / 7;
                dgv.Columns["TenDocGia"].Width = (int)dgvDanhSachDocGia.Width / 7;
                dgv.Columns["GioiTinh"].Width = (int)dgvDanhSachDocGia.Width / 7;
                dgv.Columns["NgaySinh"].Width = (int)dgvDanhSachDocGia.Width / 7;
                dgv.Columns["DiaChi"].Width = (int)dgvDanhSachDocGia.Width / 7;
                dgv.Columns["DienThoai"].Width = (int)dgvDanhSachDocGia.Width / 7;
                dgv.Columns["TenLoai"].Width = (int)dgvDanhSachDocGia.Width / 7;
            }
        }
        private void loadDanhSachSach(DataGridView dgv, DataTable dtb)
        {
            if (dtb != null)
            {
                dgv.DataSource = dtb;
                dgv.Columns["MaSach"].HeaderText = "Mã sách";
                dgv.Columns["TenSach"].HeaderText = "Tên sách";
                dgv.Columns["TenLoai"].HeaderText = "Loại sách";
                dgv.Columns["TenTacGia"].HeaderText = "Tác giả";
                dgv.Columns["TenNgonNgu"].HeaderText = "Ngôn ngữ";
                dgv.Columns["TenNhaXuatBan"].HeaderText = "Nhà xuất bản";
                dgv.Columns["NamXuatBan"].HeaderText = "Năm xuất bản";
                dgv.Columns["SoLuong"].HeaderText = "Số lượng";
                dgv.Columns["GiaNhap"].HeaderText = "Giá nhập";
                dgv.Columns["MoTa"].HeaderText = "Mô tả";
                //
                dgv.Columns["MaSach"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["TenSach"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["TenLoai"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["TenTacGia"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["TenNgonNgu"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["TenNhaXuatBan"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["NamXuatBan"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["SoLuong"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["GiaNhap"].Width = (int)dgvDanhSachSach.Width / 10;
                dgv.Columns["MoTa"].Width = (int)dgvDanhSachSach.Width / 10 + 8;
            }
        }
        private void loadDanhSachTacGia(DataGridView dgv, DataTable dtb)
        {
            if (dtb != null)
            {
                dgv.DataSource = dtb;
                dgv.Columns["MaTacGia"].HeaderText = "Mã tác giả";
                dgv.Columns["TenTacGia"].HeaderText = "Tên tác giả";
                dgv.Columns["DienThoai"].HeaderText = "Điện thoại";
                //
                dgv.Columns["MaTacGia"].Width = (int)dgvDanhSachTacGia.Width / 3;
                dgv.Columns["TenTacGia"].Width = (int)dgvDanhSachTacGia.Width / 3;
                dgv.Columns["DienThoai"].Width = (int)dgvDanhSachTacGia.Width / 3;
            }
        }
        private void loadDanhSachNhaXuatBan(DataGridView dgv, DataTable dtb)
        {
            if (dtb != null)
            {
                dgv.DataSource = dtb;
                dgv.Columns["MaNhaXuatBan"].HeaderText = "Mã nhà xuất bản";
                dgv.Columns["TenNhaXuatBan"].HeaderText = "Tên nhà xuất bản";
                dgv.Columns["Email"].HeaderText = "Email";
                //
                dgv.Columns["MaNhaXuatBan"].Width = (int)dgvDanhSachTacGia.Width / 3;
                dgv.Columns["TenNhaXuatBan"].Width = (int)dgvDanhSachTacGia.Width / 3;
                dgv.Columns["Email"].Width = (int)dgvDanhSachTacGia.Width / 3;
            }
        }
        private void loadDanhSachNgonNgu(DataGridView dgv, DataTable dtb)
        {
            if (dtb != null)
            {
                dgv.DataSource = dtb;
                dgv.Columns["MaNgonNgu"].HeaderText = "Mã ngôn ngữ";
                dgv.Columns["TenNgonNgu"].HeaderText = "Tên ngôn ngữ";
                //
                dgv.Columns["MaNgonNgu"].Width = (int)dgvDanhSachTacGia.Width / 2;
                dgv.Columns["TenNgonNgu"].Width = (int)dgvDanhSachTacGia.Width / 2;
            }
        }
        private void loadDanhSachLoaiSach(DataGridView dgv, DataTable dtb)
        {
            if (dtb != null)
            {
                dgv.DataSource = dtb;
                dgv.Columns["MaLoai"].HeaderText = "Mã loại sách";
                dgv.Columns["TenLoai"].HeaderText = "Tên loại sách";
                //
                dgv.Columns["MaLoai"].Width = (int)dgvDanhSachTacGia.Width / 2;
                dgv.Columns["TenLoai"].Width = (int)dgvDanhSachTacGia.Width / 2;
            }
        }
        //
        private void cboPhuongThucTimKiemNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemNhanVien.Enabled = true;
            txtThongTinTimKiemNhanVien.Focus();
        }
        private void cboPhuongThucTimKiemDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemDocGia.Enabled = true;
            txtThongTinTimKiemDocGia.Focus();
        }
        private void cboPhuongThucTimKiemSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemSach.Enabled = true;
            txtThongTinTimKiemLoaiSach.Focus();
        }
        private void cboPhuongThucTimKiemTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTiemKiemTacGia.Enabled = true;
            txtThongTinTiemKiemTacGia.Focus();
        }
        private void cboPhuongThucTimKiemNhaXuatBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemNhaXuatBan.Enabled = true;
            txtThongTinTimKiemNhaXuatBan.Focus();
        }
        private void cboPhuongThucTimKiemNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemNgonNgu.Enabled = true;
            txtThongTinTimKiemNgonNgu.Focus();
        }
        private void cboPhuongThucTimKiemLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtThongTinTimKiemLoaiSach.Enabled = true;
            txtThongTinTimKiemLoaiSach.Focus();
        }
        //
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNhanVien = new frmThemNhanVien();
            frmThemNhanVien.ShowDialog();
            //
            loadDanhSachNhanVien(dgvDanhSachNhanVien, BAL_NhanVien.Load());
            for (int i = 0; i < dgvDanhSachNhanVien.RowCount; i++)
            {
                if (dgvDanhSachNhanVien["MaNhanVien", i].Value.ToString() == ("NV" + BAL_NhanVien.Count()))
                {
                    dgvDanhSachNhanVien["MaNhanVien", i].Selected = true;
                }
            }
        }
        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            frmThemDocGia frmThemDocGia = new frmThemDocGia();
            frmThemDocGia.ShowDialog();
            //
            loadDanhSachDocGia(dgvDanhSachDocGia, BAL_DocGia.Load());
            for (int i = 0; i < dgvDanhSachDocGia.RowCount; i++)
            {
                if (dgvDanhSachDocGia["MaDocGia", i].Value.ToString() == ("DG" + BAL_DocGia.Count()))
                {
                    dgvDanhSachDocGia["TenDocGia", i].Selected = true;
                }
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmNhapSach frmNhapSach = new frmNhapSach();
            frmNhapSach.maNhanVienDangNhap = this.maNhanVienDangNhap;
            frmNhapSach.ShowDialog();
            //
            loadDanhSachSach(dgvDanhSachSach, BAL_Sach.Load());
            for (int i = 0; i < dgvDanhSachSach.RowCount; i++)
            {
                if (dgvDanhSachSach["MaSach", i].Value.ToString() == ("S" + BAL_Sach.Count()))
                {
                    dgvDanhSachSach["TenSach", i].Selected = true;
                }
            }
        }
        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            frmThemTacGia frmThemTacGia = new frmThemTacGia();
            frmThemTacGia.ShowDialog();
            //
            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
            for (int i = 0; i < dgvDanhSachTacGia.RowCount; i++)
            {
                if (dgvDanhSachTacGia["MaTacGia", i].Value.ToString() == ("TG" + BAL_TacGia.Count()))
                {
                    dgvDanhSachTacGia["TenTacGia", i].Selected = true;
                }
            }
        }
        private void btnThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            frmThemNhaXuatBan frmThemNhaXuatBan = new frmThemNhaXuatBan();
            frmThemNhaXuatBan.ShowDialog();
            //
            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
            for (int i = 0; i < dgvDanhSachNhaXuatBan.RowCount; i++)
            {
                if (dgvDanhSachNhaXuatBan["MaNhaXuatBan", i].Value.ToString() == ("NXB" + BAL_NhaXuatBan.Count()))
                {
                    dgvDanhSachNhaXuatBan["MaNhaXuatBan", i].Selected = true;
                }
            }
        }
        private void btnThemNgonNgu_Click(object sender, EventArgs e)
        {
            frmThemNgonNgu frmThemNgonNgu = new frmThemNgonNgu();
            frmThemNgonNgu.ShowDialog();
            //
            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
            for (int i = 0; i < dgvDanhSachNgonNgu.RowCount; i++)
            {
                if (dgvDanhSachNgonNgu["MaNgonNgu", i].Value.ToString() == ("NN" + BAL_NgonNgu.Count()))
                {
                    dgvDanhSachNgonNgu["MaNgonNgu", i].Selected = true;
                }
            }
        }
        private void btnThemLoaiSach_Click(object sender, EventArgs e)
        {
            frmThemLoaiSach frmThemLoaiSach = new frmThemLoaiSach();
            frmThemLoaiSach.ShowDialog();
            //
            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
            for (int i = 0; i < dgvDanhSachLoaiSach.RowCount; i++)
            {
                if (dgvDanhSachLoaiSach["MaLoai", i].Value.ToString() == ("LS" + BAL_LoaiSach.Count()))
                {
                    dgvDanhSachLoaiSach["MaLoai", i].Selected = true;
                }
            }
        }
        //
        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text;
            string tenNhanVien = txtTenNhanVien.Text;
            string gioiTinh = radNhanVienNam.Checked == true ? "Nam" : "Nữ";
            DateTime ngaySinh = dtpNgaySinhNhanVien.Value;
            string diaChi = txtDiaChiNhanVien.Text;
            string dienThoai = txtDienThoaiNhanVien.Text;
            string maLoai = BAL_LoaiNhanVien.GetIdByName(cboLoaiNhanVien.Text);
            string hinhAnh = txtHinhAnhNhanVien.Text;
            string trangThai = "Tồn tại";
            BEL_NhanVien nhanVien = new BEL_NhanVien(maNhanVien, tenNhanVien, gioiTinh, ngaySinh, diaChi, dienThoai, maLoai, hinhAnh, trangThai); try
            {
                if (BAL_NhanVien.Update(nhanVien))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachNhanVien(dgvDanhSachNhanVien, BAL_NhanVien.Load());
                    //
                    for (int i = 0; i < dgvDanhSachDocGia.RowCount; i++)
                    {
                        if (dgvDanhSachNhanVien["MaNhanVien", i].Value.ToString() == maNhanVien)
                        {
                            dgvDanhSachNhanVien["MaNhanVien", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaDocGia_Click(object sender, EventArgs e)
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
            try
            {
                if (BAL_DocGia.Update(docGia))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachDocGia(dgvDanhSachDocGia, BAL_DocGia.Load());
                    //
                    for (int i = 0; i < dgvDanhSachDocGia.RowCount; i++)
                    {
                        if (dgvDanhSachDocGia["MaDocGia", i].Value.ToString() == maDocGia)
                        {
                            dgvDanhSachDocGia["MaDocGia", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
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
            try
            {
                if (BAL_Sach.Update(sach))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachSach(dgvDanhSachSach, BAL_Sach.Load());
                    //
                    for (int i = 0; i < dgvDanhSachSach.RowCount; i++)
                    {
                        if (dgvDanhSachSach["MaSach", i].Value.ToString() == maSach)
                        {
                            dgvDanhSachSach["MaSach", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {
            string maTacGia = txtMaTacGia.Text;
            string tenTacGia = txtTenTacGia.Text;
            string dienThoai = txtDienThoaiTacGia.Text;
            string trangThai = "Tồn tại";
            BEL_TacGia tacGia = new BEL_TacGia(maTacGia, tenTacGia, dienThoai, trangThai);
            try
            {
                if (BAL_TacGia.Update(tacGia))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
                    //
                    for (int i = 0; i < dgvDanhSachTacGia.RowCount; i++)
                    {
                        if (dgvDanhSachTacGia["MaTacGia", i].Value.ToString() == maTacGia)
                        {
                            dgvDanhSachTacGia["MaTacGia", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaNhaXuatBan_Click(object sender, EventArgs e)
        {
            string maNhaXuatBan = txtMaNhaXuatBan.Text;
            string tenNhaXuatBan = txtTenNhaXuatBan.Text;
            string email = txtEmailNhaXuatBan.Text;
            string trangThai = "Tồn tại";
            BEL_NhaXuatBan nhaXuatBan = new BEL_NhaXuatBan(maNhaXuatBan, tenNhaXuatBan, email, trangThai);
            try
            {
                if (BAL_NhaXuatBan.Update(nhaXuatBan))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
                    //
                    for (int i = 0; i < dgvDanhSachNhaXuatBan.RowCount; i++)
                    {
                        if (dgvDanhSachNhaXuatBan["MaNhaXuatBan", i].Value.ToString() == maNhaXuatBan)
                        {
                            dgvDanhSachNhaXuatBan["MaNhaXuatBan", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaNgonNgu_Click(object sender, EventArgs e)
        {
            string maNgonNgu = txtMaNgonNgu.Text;
            string tenNgonNgu = txtTenNgonNgu.Text;
            string trangThai = "Tồn tại";
            BEL_NgonNgu ngonNgu = new BEL_NgonNgu(maNgonNgu, tenNgonNgu, trangThai);
            try
            {
                if (BAL_NgonNgu.Update(ngonNgu))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
                    //
                    for (int i = 0; i < dgvDanhSachNgonNgu.RowCount; i++)
                    {
                        if (dgvDanhSachNgonNgu["MaNgonNgu", i].Value.ToString() == maNgonNgu)
                        {
                            dgvDanhSachNgonNgu["TenNgonNgu", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuaLoaiSach_Click(object sender, EventArgs e)
        {
            string maLoaiSach = txtMaLoaiSach.Text;
            string tenLoaiSach = txtTenLoaiSach.Text;
            string trangThai = "Tồn tại";
            BEL_LoaiSach loaiSach = new BEL_LoaiSach(maLoaiSach, tenLoaiSach, trangThai);
            try
            {
                if (BAL_LoaiSach.Update(loaiSach))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
                    //
                    for (int i = 0; i < dgvDanhSachLoaiSach.RowCount; i++)
                    {
                        if (dgvDanhSachLoaiSach["MaLoai", i].Value.ToString() == maLoaiSach)
                        {
                            dgvDanhSachLoaiSach["TenLoai", i].Selected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            string maNhanVien = txtMaNhanVien.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_NhanVien.Delete(maNhanVien))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachNhanVien(dgvDanhSachNhanVien, BAL_NhanVien.Load());
                        //
                        txtMaNhanVien.Text = "NV" + (BAL_NhanVien.Count() + 1);
                        txtTenNhanVien.Text = "";
                        txtDiaChiNhanVien.Text = "";
                        txtDienThoaiNhanVien.Text = "";
                        txtHinhAnhNhanVien.Text = "";
                        picNhanVien.ImageLocation = "";
                        txtTenNhanVien.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            string maDocGia = txtMaDocGia.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_DocGia.Delete(maDocGia))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachDocGia(dgvDanhSachDocGia, BAL_DocGia.Load());
                        //
                        txtMaDocGia.Text = "DG" + (BAL_DocGia.Count() + 1);
                        txtTenDocGia.Text = "";
                        txtDiaChiDocGia.Text = "";
                        txtDienThoaiDocGia.Text = "";
                        txtHinhAnhDocGia.Text = "";
                        picDocGia.ImageLocation = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_Sach.Delete(maSach))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachSach(dgvDanhSachSach, BAL_Sach.Load());
                        //
                        txtMaSach.Text = "";
                        txtTenSach.Text = "";
                        txtNamXuatBan.Text = "";
                        txtSoLuong.Text = "";
                        txtGiaNhap.Text = "";
                        rtfMoTaSach.Text = "";
                        txtHinhAnhSach.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            string maTacGia = txtMaTacGia.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_TacGia.Delete(maTacGia))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
                        //
                        txtMaTacGia.Text = "";
                        txtTenTacGia.Text = "";
                        txtDienThoaiTacGia.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaNhaXuatBan_Click(object sender, EventArgs e)
        {
            string maNhaXuatBan = txtMaNhaXuatBan.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_NhaXuatBan.Delete(maNhaXuatBan))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
                        //
                        txtMaNhaXuatBan.Text = "";
                        txtTenNhaXuatBan.Text = "";
                        txtEmailNhaXuatBan.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaNgonNgu_Click(object sender, EventArgs e)
        {
            string maNgonNgu = txtMaNgonNgu.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_NgonNgu.Delete(maNgonNgu))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
                        //
                        txtMaNgonNgu.Text = "";
                        txtTenNgonNgu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoaLoaiSach_Click(object sender, EventArgs e)
        {
            string maLoaiSach = txtMaLoaiSach.Text;
            //
            DialogResult xoa = MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if (BAL_LoaiSach.Delete(maLoaiSach))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
                        //
                        txtMaLoaiSach.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            frmChoMuonSach frmChoMuonSach = new frmChoMuonSach();
            frmChoMuonSach.maNhanVienDangNhap = this.maNhanVienDangNhap;
            frmChoMuonSach.ShowDialog();
        }
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            frmTraSach frmTraSach = new frmTraSach();
            frmTraSach.ShowDialog();
        }
        //
        private void actionNhanVien()
        {
            radNhanVienNam.Checked = true;
            //
            cboLoaiNhanVien.DataSource = BAL_LoaiNhanVien.Load();
            cboLoaiNhanVien.ValueMember = "MaLoai";
            cboLoaiNhanVien.DisplayMember = "TenLoai";
            //
            
        }
        private void actionDocGia()
        {
            radDocGiaNam.Checked = true;
            //
            cboLoaiDocGia.DataSource = BAL_LoaiDocGia.Load();
            cboLoaiDocGia.ValueMember = "MaLoai";
            cboLoaiDocGia.DisplayMember = "TenLoai";
            //
            
        }
        private void actionSach()
        {
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
        private void txtThongTinTimKiemNhanVien_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemNhanVien.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemNhanVien.SelectedItem.ToString() == "Tìm kiếm theo mã nhân viên")
                    {
                        if (BAL_NhanVien.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachNhanVien(dgvDanhSachNhanVien, BAL_NhanVien.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachNhanVien.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemNhanVien.SelectedItem.ToString() == "Tìm kiếm theo tên nhân viên")
                    {
                        if (BAL_NhanVien.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachNhanVien(dgvDanhSachNhanVien, BAL_NhanVien.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachNhanVien.DataSource = null;
                        }
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachNhanVien(dgvDanhSachNhanVien, BAL_NhanVien.Load());
            }
        }
        private void txtThongTinTimKiemDocGia_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemDocGia.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemDocGia.SelectedItem.ToString() == "Tìm kiếm theo mã độc giả")
                    {
                        if (BAL_DocGia.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachDocGia(dgvDanhSachDocGia, BAL_DocGia.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachDocGia.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemDocGia.SelectedItem.ToString() == "Tìm kiếm theo tên độc giả")
                    {
                        if (BAL_DocGia.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachDocGia(dgvDanhSachDocGia, BAL_DocGia.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachDocGia.DataSource = null;
                        }
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachDocGia(dgvDanhSachDocGia, BAL_DocGia.Load());
            }
        }
        private void txtThongTinTimKiemSach_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemSach.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemSach.SelectedItem.ToString() == "Tìm kiếm theo mã sách")
                    {
                        if (BAL_Sach.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachSach(dgvDanhSachSach, BAL_Sach.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachSach.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemSach.SelectedItem.ToString() == "Tìm kiếm theo tên sách")
                    {
                        if (BAL_Sach.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachSach(dgvDanhSachSach, BAL_Sach.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachSach.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemSach.SelectedItem.ToString() == "Tìm kiếm theo tác giả")
                    {
                        if (BAL_Sach.SearchByAuthor(thongTinTimKiem) != null)
                        {
                            loadDanhSachSach(dgvDanhSachSach, BAL_Sach.SearchByAuthor(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachSach.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemSach.SelectedItem.ToString() == "Tìm kiếm theo ngôn ngữ")
                    {
                        if (BAL_Sach.SearchByLanguage(thongTinTimKiem) != null)
                        {
                            loadDanhSachSach(dgvDanhSachSach, BAL_Sach.SearchByLanguage(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachSach.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemSach.SelectedItem.ToString() == "Tìm kiếm theo năm xuất bản")
                    {
                        if (BAL_Sach.SearchByYear(int.Parse(thongTinTimKiem)) != null)
                        {
                            loadDanhSachSach(dgvDanhSachSach, BAL_Sach.SearchByYear(int.Parse(thongTinTimKiem)));
                        }
                        else
                        {
                            dgvDanhSachSach.DataSource = null;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachSach(dgvDanhSachSach, BAL_Sach.Load());
            }
        }
        private void txtThongTinTiemKiemTacGia_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTiemKiemTacGia.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemTacGia.SelectedItem.ToString() == "Tìm kiếm theo mã tác giả")
                    {
                        if (BAL_TacGia.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachTacGia.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemTacGia.SelectedItem.ToString() == "Tìm kiếm theo tên tác giả")
                    {
                        if (BAL_TacGia.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachTacGia.DataSource = null;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachTacGia(dgvDanhSachTacGia, BAL_TacGia.Load());
            }
        }
        private void txtThongTinTimKiemNhaXuatBan_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemNhaXuatBan.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemNhaXuatBan.SelectedItem.ToString() == "Tìm kiếm theo mã nhà xuất bản")
                    {
                        if (BAL_NhaXuatBan.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachNhaXuatBan.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemNhaXuatBan.SelectedItem.ToString() == "Tìm kiếm theo tên nhà xuất bản")
                    {
                        if (BAL_NhaXuatBan.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachNhaXuatBan.DataSource = null;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachNhaXuatBan(dgvDanhSachNhaXuatBan, BAL_NhaXuatBan.Load());
            }
        }
        private void txtThongTinTimKiemNgonNgu_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemNgonNgu.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemNgonNgu.SelectedItem.ToString() == "Tìm kiếm theo mã ngôn ngữ")
                    {
                        if (BAL_NgonNgu.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachNgonNgu.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemNgonNgu.SelectedItem.ToString() == "Tìm kiếm theo tên ngôn ngữ")
                    {
                        if (BAL_NgonNgu.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachNgonNgu.DataSource = null;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachNgonNgu(dgvDanhSachNgonNgu, BAL_NgonNgu.Load());
            }
        }
        private void txtThongTinTimKiemLoaiSach_TextChanged(object sender, EventArgs e)
        {
            string thongTinTimKiem = txtThongTinTimKiemLoaiSach.Text;
            if (thongTinTimKiem != "")
            {
                try
                {
                    if (cboPhuongThucTimKiemLoaiSach.SelectedItem.ToString() == "Tìm kiếm theo mã loại sách")
                    {
                        if (BAL_LoaiSach.SearchById(thongTinTimKiem) != null)
                        {
                            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.SearchById(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachLoaiSach.DataSource = null;
                        }
                    }
                    else if (cboPhuongThucTimKiemLoaiSach.SelectedItem.ToString() == "Tìm kiếm theo tên loại sách")
                    {
                        if (BAL_LoaiSach.SearchByName(thongTinTimKiem) != null)
                        {
                            loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.SearchByName(thongTinTimKiem));
                        }
                        else
                        {
                            dgvDanhSachLoaiSach.DataSource = null;
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                loadDanhSachLoaiSach(dgvDanhSachLoaiSach, BAL_LoaiSach.Load());
            }
        }
        //
        private void txtThongTinTimKiemNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemNhanVien.Text.Length > 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemDocGia.Text.Length > 49)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemSach.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTiemKiemTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTiemKiemTacGia.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemNhaXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemNhaXuatBan.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemNgonNgu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemNgonNgu.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtThongTinTimKiemLoaiSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtThongTinTimKiemLoaiSach.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
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
        private void txtTenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenTacGia.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtDienThoaiTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtDienThoaiTacGia.Text.Length > 9)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtTenNhaXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenNhaXuatBan.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtEmailNhaXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEmailNhaXuatBan.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtTenNgonNgu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenNgonNgu.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        private void txtTenLoaiSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTenLoaiSach.Text.Length > 29)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void frmAdmin_Activated(object sender, EventArgs e)
        {
            dgvDanhSachSach.DataSource = BAL_Sach.Load();
            dgvDanhSachDocGia.DataSource = BAL_DocGia.Load();
            dgvDanhSachNhanVien.DataSource = BAL_NhanVien.Load();
        }
    }
}
