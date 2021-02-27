using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLTV.DocGia;
using BEL;
using BAL;

namespace QLTV.Sach
{
    public partial class frmChoMuonSach : Form
    {
        public string maNhanVienDangNhap { get; set; }
        private List<BEL_Sach> danhSachSach = new List<BEL_Sach>();
        public frmChoMuonSach()
        {
            InitializeComponent();
        }
        //
        private void frmChoMuonSach_Load(object sender, EventArgs e)
        {
            cboMaDocGia.DataSource = BAL_DocGia.Load();
            cboMaDocGia.DisplayMember = "TenDocGia";
            cboMaDocGia.ValueMember = "MaDocGia";
            //
            cboMaSach.DataSource = BAL_Sach.Load();
            cboMaSach.DisplayMember = "TenSach";
            cboMaSach.ValueMember = "MaSach";
            //
            int? temp = BAL_Sach.GetNumberById(cboMaSach.SelectedValue.ToString());
            for (int i = 1; i <= temp; i++)
            {
                cboSoLuong.Items.Add(i);
            }
        }
        //
        private void cboMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSach = cboMaSach.SelectedValue.ToString();
            if (BAL_Sach.GetNumberById(maSach) != null)
            {
                cboSoLuong.Items.Clear();
                for (int i = 1; i <= BAL_Sach.GetNumberById(maSach); i++)
                {
                    cboSoLuong.Items.Add(i);
                }
            }
        }
        //
        private void btnThemDocGia_Click(object sender, EventArgs e)
        {
            frmThemDocGia frmThemDocGia = new frmThemDocGia();
            frmThemDocGia.ShowDialog();
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmNhapSach frmNhapSach = new frmNhapSach();
            frmNhapSach.ShowDialog();
        }
        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (cboSoLuong.Text != "")
            {
                if (BAL_Sach.GetObjectById(cboMaSach.SelectedValue.ToString()) != null)
                {
                    BEL_Sach sach = BAL_Sach.GetObjectById(cboMaSach.SelectedValue.ToString());
                    sach.SoLuong = int.Parse(cboSoLuong.Text);
                    danhSachSach.Add(sach);
                    MessageBox.Show("Đã thêm sách tạm thời!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaDocGia.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn số lượng sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string maHoaDon = "HD" + BAL_HoaDonMuon.Count();
                    string maNhanVien = this.maNhanVienDangNhap;
                    string maDocGia = cboMaDocGia.SelectedValue.ToString();
                    DateTime ngayLap = DateTime.Now;
                    DateTime ngayTra = ngayLap.AddDays(7);
                    bool daTra = false;
                    string trangThai = "Tồn tại";
                    BEL_HoaDonMuon hoaDonMuon = new BEL_HoaDonMuon(maHoaDon, maNhanVien, maDocGia, ngayLap, ngayTra, daTra, trangThai);
                    BAL_HoaDonMuon.Add(hoaDonMuon);
                    //
                    //for (int i = 0; i < danhSachSach.Count; i++)
                    //{
                    //    BEL_ChiTietHoaDonMuon chiTietHoaDonMuon = new BEL_ChiTietHoaDonMuon(maHoaDon, danhSachSach[i].MaSach, danhSachSach[i].SoLuong);
                    //    BAL_ChiTietHoaDonMuon.Add(chiTietHoaDonMuon);
                    //    BAL_Sach.Update2(danhSachSach[i]);
                    //}
                    MessageBox.Show("Cho mượn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
