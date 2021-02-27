namespace QLTV.NhanVien
{
    partial class frmThemNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhanVien));
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblThemNhanVien = new System.Windows.Forms.Label();
            this.cboLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.txtDienThoaiNhanVien = new System.Windows.Forms.TextBox();
            this.txtDiaChiNhanVien = new System.Windows.Forms.TextBox();
            this.dtpNgaySinhNhanVien = new System.Windows.Forms.DateTimePicker();
            this.radNhanVienNu = new System.Windows.Forms.RadioButton();
            this.radNhanVienNam = new System.Windows.Forms.RadioButton();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.btnHinhAnhNhanVien = new System.Windows.Forms.Button();
            this.txtHinhAnhNhanVien = new System.Windows.Forms.TextBox();
            this.lblHinhAnhNhanVien = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblMaLoaiNhanVien = new System.Windows.Forms.Label();
            this.lblDienThoaiNhanVien = new System.Windows.Forms.Label();
            this.lblDiaChiNhanVien = new System.Windows.Forms.Label();
            this.lblNgaySinhNhanVien = new System.Windows.Forms.Label();
            this.lblGioiTinhNhanVien = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(12, 282);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(52, 13);
            this.lblMatKhau.TabIndex = 99;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.ilsIcon;
            this.btnThem.Location = new System.Drawing.Point(336, 331);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 97;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ilsIcon
            // 
            this.ilsIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsIcon.ImageStream")));
            this.ilsIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsIcon.Images.SetKeyName(0, "check.png");
            this.ilsIcon.Images.SetKeyName(1, "cancel32.png");
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(85, 275);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(121, 20);
            this.txtMatKhau.TabIndex = 100;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 1;
            this.btnHuy.ImageList = this.ilsIcon;
            this.btnHuy.Location = new System.Drawing.Point(382, 331);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(40, 40);
            this.btnHuy.TabIndex = 98;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblThemNhanVien
            // 
            this.lblThemNhanVien.AutoSize = true;
            this.lblThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblThemNhanVien.Location = new System.Drawing.Point(92, 9);
            this.lblThemNhanVien.Name = "lblThemNhanVien";
            this.lblThemNhanVien.Size = new System.Drawing.Size(247, 31);
            this.lblThemNhanVien.TabIndex = 96;
            this.lblThemNhanVien.Text = "THÊM NHÂN VIÊN";
            // 
            // cboLoaiNhanVien
            // 
            this.cboLoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNhanVien.FormattingEnabled = true;
            this.cboLoaiNhanVien.Location = new System.Drawing.Point(85, 244);
            this.cboLoaiNhanVien.Name = "cboLoaiNhanVien";
            this.cboLoaiNhanVien.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiNhanVien.TabIndex = 95;
            // 
            // txtDienThoaiNhanVien
            // 
            this.txtDienThoaiNhanVien.Location = new System.Drawing.Point(85, 215);
            this.txtDienThoaiNhanVien.Name = "txtDienThoaiNhanVien";
            this.txtDienThoaiNhanVien.Size = new System.Drawing.Size(121, 20);
            this.txtDienThoaiNhanVien.TabIndex = 94;
            this.txtDienThoaiNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoaiNhanVien_KeyPress);
            // 
            // txtDiaChiNhanVien
            // 
            this.txtDiaChiNhanVien.Location = new System.Drawing.Point(85, 185);
            this.txtDiaChiNhanVien.Name = "txtDiaChiNhanVien";
            this.txtDiaChiNhanVien.Size = new System.Drawing.Size(121, 20);
            this.txtDiaChiNhanVien.TabIndex = 93;
            this.txtDiaChiNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChiNhanVien_KeyPress);
            // 
            // dtpNgaySinhNhanVien
            // 
            this.dtpNgaySinhNhanVien.Location = new System.Drawing.Point(85, 156);
            this.dtpNgaySinhNhanVien.Name = "dtpNgaySinhNhanVien";
            this.dtpNgaySinhNhanVien.Size = new System.Drawing.Size(121, 20);
            this.dtpNgaySinhNhanVien.TabIndex = 92;
            // 
            // radNhanVienNu
            // 
            this.radNhanVienNu.AutoSize = true;
            this.radNhanVienNu.Location = new System.Drawing.Point(167, 132);
            this.radNhanVienNu.Name = "radNhanVienNu";
            this.radNhanVienNu.Size = new System.Drawing.Size(39, 17);
            this.radNhanVienNu.TabIndex = 91;
            this.radNhanVienNu.TabStop = true;
            this.radNhanVienNu.Text = "Nữ";
            this.radNhanVienNu.UseVisualStyleBackColor = true;
            // 
            // radNhanVienNam
            // 
            this.radNhanVienNam.AutoSize = true;
            this.radNhanVienNam.Location = new System.Drawing.Point(85, 132);
            this.radNhanVienNam.Name = "radNhanVienNam";
            this.radNhanVienNam.Size = new System.Drawing.Size(47, 17);
            this.radNhanVienNam.TabIndex = 90;
            this.radNhanVienNam.TabStop = true;
            this.radNhanVienNam.Text = "Nam";
            this.radNhanVienNam.UseVisualStyleBackColor = true;
            // 
            // picNhanVien
            // 
            this.picNhanVien.Location = new System.Drawing.Point(244, 91);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(156, 204);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 89;
            this.picNhanVien.TabStop = false;
            // 
            // btnHinhAnhNhanVien
            // 
            this.btnHinhAnhNhanVien.Location = new System.Drawing.Point(394, 62);
            this.btnHinhAnhNhanVien.Name = "btnHinhAnhNhanVien";
            this.btnHinhAnhNhanVien.Size = new System.Drawing.Size(30, 23);
            this.btnHinhAnhNhanVien.TabIndex = 88;
            this.btnHinhAnhNhanVien.Text = "...";
            this.btnHinhAnhNhanVien.UseVisualStyleBackColor = true;
            this.btnHinhAnhNhanVien.Click += new System.EventHandler(this.btnHinhAnhNhanVien_Click);
            // 
            // txtHinhAnhNhanVien
            // 
            this.txtHinhAnhNhanVien.Location = new System.Drawing.Point(278, 65);
            this.txtHinhAnhNhanVien.Name = "txtHinhAnhNhanVien";
            this.txtHinhAnhNhanVien.ReadOnly = true;
            this.txtHinhAnhNhanVien.Size = new System.Drawing.Size(110, 20);
            this.txtHinhAnhNhanVien.TabIndex = 87;
            // 
            // lblHinhAnhNhanVien
            // 
            this.lblHinhAnhNhanVien.AutoSize = true;
            this.lblHinhAnhNhanVien.Location = new System.Drawing.Point(222, 72);
            this.lblHinhAnhNhanVien.Name = "lblHinhAnhNhanVien";
            this.lblHinhAnhNhanVien.Size = new System.Drawing.Size(50, 13);
            this.lblHinhAnhNhanVien.TabIndex = 86;
            this.lblHinhAnhNhanVien.Text = "Hình ảnh";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(85, 95);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(121, 20);
            this.txtTenNhanVien.TabIndex = 85;
            this.txtTenNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNhanVien_KeyPress);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(85, 65);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(121, 20);
            this.txtMaNhanVien.TabIndex = 84;
            // 
            // lblMaLoaiNhanVien
            // 
            this.lblMaLoaiNhanVien.AutoSize = true;
            this.lblMaLoaiNhanVien.Location = new System.Drawing.Point(12, 252);
            this.lblMaLoaiNhanVien.Name = "lblMaLoaiNhanVien";
            this.lblMaLoaiNhanVien.Size = new System.Drawing.Size(77, 13);
            this.lblMaLoaiNhanVien.TabIndex = 83;
            this.lblMaLoaiNhanVien.Text = "Loại nhân viên";
            // 
            // lblDienThoaiNhanVien
            // 
            this.lblDienThoaiNhanVien.AutoSize = true;
            this.lblDienThoaiNhanVien.Location = new System.Drawing.Point(12, 222);
            this.lblDienThoaiNhanVien.Name = "lblDienThoaiNhanVien";
            this.lblDienThoaiNhanVien.Size = new System.Drawing.Size(55, 13);
            this.lblDienThoaiNhanVien.TabIndex = 82;
            this.lblDienThoaiNhanVien.Text = "Điện thoại";
            // 
            // lblDiaChiNhanVien
            // 
            this.lblDiaChiNhanVien.AutoSize = true;
            this.lblDiaChiNhanVien.Location = new System.Drawing.Point(12, 192);
            this.lblDiaChiNhanVien.Name = "lblDiaChiNhanVien";
            this.lblDiaChiNhanVien.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChiNhanVien.TabIndex = 81;
            this.lblDiaChiNhanVien.Text = "Địa chỉ";
            // 
            // lblNgaySinhNhanVien
            // 
            this.lblNgaySinhNhanVien.AutoSize = true;
            this.lblNgaySinhNhanVien.Location = new System.Drawing.Point(12, 162);
            this.lblNgaySinhNhanVien.Name = "lblNgaySinhNhanVien";
            this.lblNgaySinhNhanVien.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinhNhanVien.TabIndex = 80;
            this.lblNgaySinhNhanVien.Text = "Ngày sinh";
            // 
            // lblGioiTinhNhanVien
            // 
            this.lblGioiTinhNhanVien.AutoSize = true;
            this.lblGioiTinhNhanVien.Location = new System.Drawing.Point(12, 132);
            this.lblGioiTinhNhanVien.Name = "lblGioiTinhNhanVien";
            this.lblGioiTinhNhanVien.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinhNhanVien.TabIndex = 79;
            this.lblGioiTinhNhanVien.Text = "Giới tính";
            this.lblGioiTinhNhanVien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(12, 102);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(76, 13);
            this.lblTenNhanVien.TabIndex = 78;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(12, 72);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(72, 13);
            this.lblMaNhanVien.TabIndex = 77;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 391);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblThemNhanVien);
            this.Controls.Add(this.cboLoaiNhanVien);
            this.Controls.Add(this.txtDienThoaiNhanVien);
            this.Controls.Add(this.txtDiaChiNhanVien);
            this.Controls.Add(this.dtpNgaySinhNhanVien);
            this.Controls.Add(this.radNhanVienNu);
            this.Controls.Add(this.radNhanVienNam);
            this.Controls.Add(this.picNhanVien);
            this.Controls.Add(this.btnHinhAnhNhanVien);
            this.Controls.Add(this.txtHinhAnhNhanVien);
            this.Controls.Add(this.lblHinhAnhNhanVien);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblMaLoaiNhanVien);
            this.Controls.Add(this.lblDienThoaiNhanVien);
            this.Controls.Add(this.lblDiaChiNhanVien);
            this.Controls.Add(this.lblNgaySinhNhanVien);
            this.Controls.Add(this.lblGioiTinhNhanVien);
            this.Controls.Add(this.lblTenNhanVien);
            this.Controls.Add(this.lblMaNhanVien);
            this.KeyPreview = true;
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmThemNhanVien_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblThemNhanVien;
        private System.Windows.Forms.ComboBox cboLoaiNhanVien;
        private System.Windows.Forms.TextBox txtDienThoaiNhanVien;
        private System.Windows.Forms.TextBox txtDiaChiNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhNhanVien;
        private System.Windows.Forms.RadioButton radNhanVienNu;
        private System.Windows.Forms.RadioButton radNhanVienNam;
        private System.Windows.Forms.PictureBox picNhanVien;
        private System.Windows.Forms.Button btnHinhAnhNhanVien;
        private System.Windows.Forms.TextBox txtHinhAnhNhanVien;
        private System.Windows.Forms.Label lblHinhAnhNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaLoaiNhanVien;
        private System.Windows.Forms.Label lblDienThoaiNhanVien;
        private System.Windows.Forms.Label lblDiaChiNhanVien;
        private System.Windows.Forms.Label lblNgaySinhNhanVien;
        private System.Windows.Forms.Label lblGioiTinhNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
    }
}