namespace QLTV.Sach
{
    partial class frmChoMuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoMuonSach));
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.cboMaDocGia = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblChoMuonSach = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboSoLuong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.ImageIndex = 2;
            this.btnThemChiTiet.ImageList = this.ilsIcon;
            this.btnThemChiTiet.Location = new System.Drawing.Point(135, 188);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(40, 40);
            this.btnThemChiTiet.TabIndex = 112;
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // ilsIcon
            // 
            this.ilsIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsIcon.ImageStream")));
            this.ilsIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsIcon.Images.SetKeyName(0, "check.png");
            this.ilsIcon.Images.SetKeyName(1, "cancel32.png");
            this.ilsIcon.Images.SetKeyName(2, "apply32.png");
            // 
            // cboMaDocGia
            // 
            this.cboMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDocGia.FormattingEnabled = true;
            this.cboMaDocGia.Location = new System.Drawing.Point(87, 69);
            this.cboMaDocGia.Name = "cboMaDocGia";
            this.cboMaDocGia.Size = new System.Drawing.Size(121, 21);
            this.cboMaDocGia.TabIndex = 110;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 1;
            this.btnHuy.ImageList = this.ilsIcon;
            this.btnHuy.Location = new System.Drawing.Point(227, 188);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(40, 40);
            this.btnHuy.TabIndex = 105;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Location = new System.Drawing.Point(214, 69);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(21, 21);
            this.btnThemDocGia.TabIndex = 111;
            this.btnThemDocGia.Text = "+";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.ilsIcon;
            this.btnThem.Location = new System.Drawing.Point(181, 188);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.TabIndex = 104;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblChoMuonSach
            // 
            this.lblChoMuonSach.AutoSize = true;
            this.lblChoMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoMuonSach.ForeColor = System.Drawing.Color.Red;
            this.lblChoMuonSach.Location = new System.Drawing.Point(19, 9);
            this.lblChoMuonSach.Name = "lblChoMuonSach";
            this.lblChoMuonSach.Size = new System.Drawing.Size(248, 31);
            this.lblChoMuonSach.TabIndex = 103;
            this.lblChoMuonSach.Text = "CHO MƯỢN SÁCH";
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(12, 72);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(61, 13);
            this.lblMaDocGia.TabIndex = 80;
            this.lblMaDocGia.Text = "Mã độc giả";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(12, 102);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(48, 13);
            this.lblMaSach.TabIndex = 81;
            this.lblMaSach.Text = "Mã sách";
            // 
            // cboMaSach
            // 
            this.cboMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(87, 99);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(121, 21);
            this.cboMaSach.TabIndex = 113;
            this.cboMaSach.SelectedIndexChanged += new System.EventHandler(this.cboMaSach_SelectedIndexChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(12, 129);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 87;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // cboSoLuong
            // 
            this.cboSoLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSoLuong.FormattingEnabled = true;
            this.cboSoLuong.Location = new System.Drawing.Point(87, 129);
            this.cboSoLuong.Name = "cboSoLuong";
            this.cboSoLuong.Size = new System.Drawing.Size(121, 21);
            this.cboSoLuong.TabIndex = 115;
            // 
            // frmChoMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 240);
            this.Controls.Add(this.cboSoLuong);
            this.Controls.Add(this.cboMaSach);
            this.Controls.Add(this.btnThemChiTiet);
            this.Controls.Add(this.cboMaDocGia);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemDocGia);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblChoMuonSach);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.lblMaDocGia);
            this.Name = "frmChoMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.frmChoMuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.ComboBox cboMaDocGia;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblChoMuonSach;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cboSoLuong;
    }
}