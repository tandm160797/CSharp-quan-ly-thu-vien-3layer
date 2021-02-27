namespace QLTV.Sach
{
    partial class frmTraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraSach));
            this.ilsIcon = new System.Windows.Forms.ImageList(this.components);
            this.cboMaHoaDon = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.lblTraSach = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.cboMaDocGia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ilsIcon
            // 
            this.ilsIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilsIcon.ImageStream")));
            this.ilsIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilsIcon.Images.SetKeyName(0, "check.png");
            this.ilsIcon.Images.SetKeyName(1, "cancel32.png");
            this.ilsIcon.Images.SetKeyName(2, "apply32.png");
            // 
            // cboMaHoaDon
            // 
            this.cboMaHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHoaDon.FormattingEnabled = true;
            this.cboMaHoaDon.Location = new System.Drawing.Point(87, 69);
            this.cboMaHoaDon.Name = "cboMaHoaDon";
            this.cboMaHoaDon.Size = new System.Drawing.Size(121, 21);
            this.cboMaHoaDon.TabIndex = 122;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageIndex = 1;
            this.btnHuy.ImageList = this.ilsIcon;
            this.btnHuy.Location = new System.Drawing.Point(227, 188);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(40, 40);
            this.btnHuy.TabIndex = 121;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.ImageIndex = 0;
            this.btnTraSach.ImageList = this.ilsIcon;
            this.btnTraSach.Location = new System.Drawing.Point(181, 188);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(40, 40);
            this.btnTraSach.TabIndex = 120;
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // lblTraSach
            // 
            this.lblTraSach.AutoSize = true;
            this.lblTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraSach.ForeColor = System.Drawing.Color.Red;
            this.lblTraSach.Location = new System.Drawing.Point(65, 9);
            this.lblTraSach.Name = "lblTraSach";
            this.lblTraSach.Size = new System.Drawing.Size(152, 31);
            this.lblTraSach.TabIndex = 119;
            this.lblTraSach.Text = "TRẢ SÁCH";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Location = new System.Drawing.Point(12, 72);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(65, 13);
            this.lblMaHoaDon.TabIndex = 116;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(12, 102);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(61, 13);
            this.lblMaDocGia.TabIndex = 123;
            this.lblMaDocGia.Text = "Mã độc giả";
            // 
            // cboMaDocGia
            // 
            this.cboMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDocGia.FormattingEnabled = true;
            this.cboMaDocGia.Location = new System.Drawing.Point(87, 99);
            this.cboMaDocGia.Name = "cboMaDocGia";
            this.cboMaDocGia.Size = new System.Drawing.Size(121, 21);
            this.cboMaDocGia.TabIndex = 124;
            this.cboMaDocGia.SelectedIndexChanged += new System.EventHandler(this.cboMaDocGia_SelectedIndexChanged);
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 240);
            this.Controls.Add(this.cboMaDocGia);
            this.Controls.Add(this.lblMaDocGia);
            this.Controls.Add(this.cboMaHoaDon);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.lblTraSach);
            this.Controls.Add(this.lblMaHoaDon);
            this.Name = "frmTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sách";
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTraSach_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ilsIcon;
        private System.Windows.Forms.ComboBox cboMaHoaDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Label lblTraSach;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.ComboBox cboMaDocGia;
    }
}