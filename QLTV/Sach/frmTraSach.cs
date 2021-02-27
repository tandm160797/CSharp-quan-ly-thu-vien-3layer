using System;
using System.Windows.Forms;
using BEL;
using BAL;

namespace QLTV.Sach
{
    public partial class frmTraSach : Form
    {
        public frmTraSach()
        {
            InitializeComponent();
        }
        private void frmTraSach_Load(object sender, EventArgs e)
        {
            cboMaHoaDon.DataSource = BAL_HoaDonMuon.Load();
            cboMaHoaDon.DisplayMember = "MaHoaDon";
            cboMaHoaDon.ValueMember = "MaHoaDon";
            //
            cboMaDocGia.DataSource = BAL_DocGia.Load();
            cboMaDocGia.DisplayMember = "TenDocGia";
            cboMaDocGia.ValueMember = "MaDocGia";
        }
        private void frmTraSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTraSach_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnHuy_Click(sender, e);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            string maHoaDon = cboMaHoaDon.SelectedValue.ToString();
            try
            {
                if (BAL_HoaDonMuon.IsPay(maHoaDon))
                {
                    for(int i = 0; i < BAL_HoaDonMuon.GetSachById(maHoaDon).Count; i++)
                    {
                        BAL_Sach.Update(BAL_HoaDonMuon.GetSachById(maHoaDon)[i]);
                    }
                    MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maDocGia = cboMaDocGia.SelectedValue.ToString();
            if (BAL_HoaDonMuon.GetIdByReaderId(maDocGia) != null)
            {
                cboMaHoaDon.DataSource = BAL_HoaDonMuon.GetIdByReaderId(maDocGia);
                cboMaHoaDon.DisplayMember = "MaHoaDon";
                cboMaHoaDon.ValueMember = "MaHoaDon";
            }
        }
    }
}
