﻿namespace QuanLyBanXeMay.GUI
{
    partial class frmTimKiemNhanVien
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
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.dgvDanhSachTimKiemXe = new System.Windows.Forms.DataGridView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.lblTenNcc = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTimKiemXe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(137, 176);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(81, 23);
            this.btnXuatFile.TabIndex = 18;
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
            this.colMaNV,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colTenNV,
            this.colChucVu});
            this.dgvDanhSachTimKiemXe.Location = new System.Drawing.Point(61, 205);
            this.dgvDanhSachTimKiemXe.Name = "dgvDanhSachTimKiemXe";
            this.dgvDanhSachTimKiemXe.ReadOnly = true;
            this.dgvDanhSachTimKiemXe.RowHeadersWidth = 51;
            this.dgvDanhSachTimKiemXe.RowTemplate.Height = 24;
            this.dgvDanhSachTimKiemXe.Size = new System.Drawing.Size(678, 207);
            this.dgvDanhSachTimKiemXe.TabIndex = 17;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(545, 176);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(75, 23);
            this.btnTroVe.TabIndex = 13;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(521, 418);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(99, 22);
            this.txtSoLuong.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(400, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(316, 176);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kết quả tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChucVu);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.lblTenNcc);
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.lblMaNV);
            this.groupBox1.Location = new System.Drawing.Point(61, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 150);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(133, 104);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(184, 24);
            this.cmbChucVu.TabIndex = 2;
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
            this.lblTenNcc.Size = new System.Drawing.Size(67, 16);
            this.lblTenNcc.TabIndex = 0;
            this.lblTenNcc.Text = "CHỨC VỤ";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(43, 70);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(57, 16);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "TÊN NV";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(43, 38);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(49, 16);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "MÃ NV";
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "MÃ NV";
            this.colMaNV.MinimumWidth = 6;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.ReadOnly = true;
            this.colMaNV.Width = 125;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "GIỚI TÍNH";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 125;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "NGÀY SINH";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Width = 125;
            // 
            // colTenNV
            // 
            this.colTenNV.HeaderText = "TÊN NV";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.ReadOnly = true;
            this.colTenNV.Width = 125;
            // 
            // colChucVu
            // 
            this.colChucVu.HeaderText = "CHỨC VỤ";
            this.colChucVu.MinimumWidth = 6;
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.ReadOnly = true;
            this.colChucVu.Width = 125;
            // 
            // frmTimKiemNhanVien
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
            this.Name = "frmTimKiemNhanVien";
            this.Text = "frmTimKiemNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTimKiemXe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DataGridView dgvDanhSachTimKiemXe;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label lblTenNcc;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
    }
}