namespace QuanLyBanXeMay.GUI
{
    partial class frmTimKiemXe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNCC = new System.Windows.Forms.ComboBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.lblTenNcc = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.dgvDanhSachTimKiemXe = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.colMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTimKiemXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNCC);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.lblTenNcc);
            this.groupBox1.Controls.Add(this.lblTenXe);
            this.groupBox1.Controls.Add(this.lblMaXe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // cmbNCC
            // 
            this.cmbNCC.FormattingEnabled = true;
            this.cmbNCC.Location = new System.Drawing.Point(133, 104);
            this.cmbNCC.Name = "cmbNCC";
            this.cmbNCC.Size = new System.Drawing.Size(184, 24);
            this.cmbNCC.TabIndex = 2;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(133, 64);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(184, 22);
            this.txtTenXe.TabIndex = 1;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(133, 32);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(184, 22);
            this.txtMaXe.TabIndex = 1;
            // 
            // lblTenNcc
            // 
            this.lblTenNcc.AutoSize = true;
            this.lblTenNcc.Location = new System.Drawing.Point(43, 112);
            this.lblTenNcc.Name = "lblTenNcc";
            this.lblTenNcc.Size = new System.Drawing.Size(66, 16);
            this.lblTenNcc.TabIndex = 0;
            this.lblTenNcc.Text = "TÊN NCC";
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Location = new System.Drawing.Point(43, 70);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(55, 16);
            this.lblTenXe.TabIndex = 0;
            this.lblTenXe.Text = "TÊN XE";
            // 
            // lblMaXe
            // 
            this.lblMaXe.AutoSize = true;
            this.lblMaXe.Location = new System.Drawing.Point(43, 38);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(47, 16);
            this.lblMaXe.TabIndex = 0;
            this.lblMaXe.Text = "MÃ XE";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(88, 178);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(81, 23);
            this.btnXuatFile.TabIndex = 10;
            this.btnXuatFile.Text = "Excel";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachTimKiemXe
            // 
            this.dgvDanhSachTimKiemXe.AllowUserToAddRows = false;
            this.dgvDanhSachTimKiemXe.AllowUserToDeleteRows = false;
            this.dgvDanhSachTimKiemXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTimKiemXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaXe,
            this.colTenXe,
            this.colNCC,
            this.colGia,
            this.colSoLuong});
            this.dgvDanhSachTimKiemXe.Location = new System.Drawing.Point(12, 207);
            this.dgvDanhSachTimKiemXe.Name = "dgvDanhSachTimKiemXe";
            this.dgvDanhSachTimKiemXe.ReadOnly = true;
            this.dgvDanhSachTimKiemXe.RowHeadersWidth = 51;
            this.dgvDanhSachTimKiemXe.RowTemplate.Height = 24;
            this.dgvDanhSachTimKiemXe.Size = new System.Drawing.Size(678, 207);
            this.dgvDanhSachTimKiemXe.TabIndex = 9;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(496, 178);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 5;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(472, 420);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(99, 22);
            this.txtSoLuong.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(267, 178);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả tìm kiếm";
            // 
            // colMaXe
            // 
            this.colMaXe.HeaderText = "MÃ XE";
            this.colMaXe.MinimumWidth = 6;
            this.colMaXe.Name = "colMaXe";
            this.colMaXe.ReadOnly = true;
            this.colMaXe.Width = 125;
            // 
            // colTenXe
            // 
            this.colTenXe.HeaderText = "TÊN XE";
            this.colTenXe.MinimumWidth = 6;
            this.colTenXe.Name = "colTenXe";
            this.colTenXe.ReadOnly = true;
            this.colTenXe.Width = 125;
            // 
            // colNCC
            // 
            this.colNCC.HeaderText = "Tên NCC";
            this.colNCC.MinimumWidth = 6;
            this.colNCC.Name = "colNCC";
            this.colNCC.ReadOnly = true;
            this.colNCC.Width = 125;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "GIÁ";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "SỐ LƯỢNG";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 125;
            // 
            // frmTimKiemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.dgvDanhSachTimKiemXe);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimKiemXe";
            this.Text = "frmTimKiemXe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTimKiemXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNCC;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label lblTenNcc;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DataGridView dgvDanhSachTimKiemXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
    }
}