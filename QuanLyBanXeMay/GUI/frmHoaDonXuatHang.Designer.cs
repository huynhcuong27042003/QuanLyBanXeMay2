namespace QuanLyBanXeMay.GUI
{
    partial class frmHoaDonXuatHang
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
            this.lblLoai = new System.Windows.Forms.Label();
            this.cmbTenXe = new System.Windows.Forms.ComboBox();
            this.cmbMaXe = new System.Windows.Forms.ComboBox();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.cmbMau = new System.Windows.Forms.ComboBox();
            this.lblMau = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTenKH = new System.Windows.Forms.ComboBox();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.dgvDanhSachHoaDonNhapHang = new System.Windows.Forms.DataGridView();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.dateThoiGian = new System.Windows.Forms.DateTimePicker();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDonNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(9, 305);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(56, 16);
            this.lblLoai.TabIndex = 18;
            this.lblLoai.Text = "LOẠI XE";
            // 
            // cmbTenXe
            // 
            this.cmbTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenXe.FormattingEnabled = true;
            this.cmbTenXe.Location = new System.Drawing.Point(104, 209);
            this.cmbTenXe.Name = "cmbTenXe";
            this.cmbTenXe.Size = new System.Drawing.Size(121, 24);
            this.cmbTenXe.TabIndex = 10;
            // 
            // cmbMaXe
            // 
            this.cmbMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaXe.FormattingEnabled = true;
            this.cmbMaXe.Location = new System.Drawing.Point(105, 160);
            this.cmbMaXe.Name = "cmbMaXe";
            this.cmbMaXe.Size = new System.Drawing.Size(121, 24);
            this.cmbMaXe.TabIndex = 9;
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenXe.Location = new System.Drawing.Point(6, 212);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(55, 16);
            this.lblTenXe.TabIndex = 8;
            this.lblTenXe.Text = "TÊN XE";
            // 
            // lblMaXe
            // 
            this.lblMaXe.AutoSize = true;
            this.lblMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaXe.Location = new System.Drawing.Point(7, 163);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(47, 16);
            this.lblMaXe.TabIndex = 7;
            this.lblMaXe.Text = "MÃ XE";
            // 
            // cmbMau
            // 
            this.cmbMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMau.FormattingEnabled = true;
            this.cmbMau.Location = new System.Drawing.Point(105, 347);
            this.cmbMau.Name = "cmbMau";
            this.cmbMau.Size = new System.Drawing.Size(121, 24);
            this.cmbMau.TabIndex = 27;
            // 
            // lblMau
            // 
            this.lblMau.AutoSize = true;
            this.lblMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMau.Location = new System.Drawing.Point(9, 355);
            this.lblMau.Name = "lblMau";
            this.lblMau.Size = new System.Drawing.Size(37, 16);
            this.lblMau.TabIndex = 26;
            this.lblMau.Text = "MÀU";
            this.lblMau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(134, 396);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(65, 22);
            this.numSoLuong.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 402);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 16);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "SỐ LƯỢNG";
            // 
            // cmbLoai
            // 
            this.cmbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(105, 302);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(121, 24);
            this.cmbLoai.TabIndex = 19;
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Location = new System.Drawing.Point(1191, 478);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(198, 47);
            this.btnXuatHang.TabIndex = 3;
            this.btnXuatHang.Text = "Xuất Hàng";
            this.btnXuatHang.UseVisualStyleBackColor = true;
            this.btnXuatHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.lblThoiGian);
            this.groupBox1.Controls.Add(this.dateThoiGian);
            this.groupBox1.Controls.Add(this.cmbTenKH);
            this.groupBox1.Controls.Add(this.cmbMaKH);
            this.groupBox1.Controls.Add(this.lblTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnXuatHang);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.lblMaHoaDon);
            this.groupBox1.Controls.Add(this.btnTroVe);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.lblThanhTien);
            this.groupBox1.Controls.Add(this.dgvDanhSachHoaDonNhapHang);
            this.groupBox1.Controls.Add(this.cmbMau);
            this.groupBox1.Controls.Add(this.lblMau);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.cmbLoai);
            this.groupBox1.Controls.Add(this.lblLoai);
            this.groupBox1.Controls.Add(this.cmbTenXe);
            this.groupBox1.Controls.Add(this.cmbMaXe);
            this.groupBox1.Controls.Add(this.lblTenXe);
            this.groupBox1.Controls.Add(this.lblMaXe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1405, 531);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // cmbTenKH
            // 
            this.cmbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenKH.FormattingEnabled = true;
            this.cmbTenKH.Location = new System.Drawing.Point(104, 108);
            this.cmbTenKH.Name = "cmbTenKH";
            this.cmbTenKH.Size = new System.Drawing.Size(121, 24);
            this.cmbTenKH.TabIndex = 37;
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(104, 66);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(121, 24);
            this.cmbMaKH.TabIndex = 36;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(6, 111);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(56, 16);
            this.lblTenKH.TabIndex = 35;
            this.lblTenKH.Text = "TÊN KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "MÃ KH";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(104, 26);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(121, 22);
            this.txtMaHoaDon.TabIndex = 33;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(7, 29);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(91, 16);
            this.lblMaHoaDon.TabIndex = 32;
            this.lblMaHoaDon.Text = "MÃ HÓA ĐƠN";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(10, 475);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(83, 31);
            this.btnTroVe.TabIndex = 31;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(137, 475);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 31);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 438);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 31);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(137, 438);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 31);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(1155, 423);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(234, 27);
            this.txtThanhTien.TabIndex = 30;
            this.txtThanhTien.Text = "VNĐ";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(1016, 428);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(97, 20);
            this.lblThanhTien.TabIndex = 29;
            this.lblThanhTien.Text = "Thành Tiền ";
            // 
            // dgvDanhSachHoaDonNhapHang
            // 
            this.dgvDanhSachHoaDonNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHoaDonNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colMaKH,
            this.colTenKH,
            this.colMaXe,
            this.colTenXe,
            this.colThoiGian,
            this.colLoaiXe,
            this.colMau,
            this.colSoLuong,
            this.colGia,
            this.colThanhTien});
            this.dgvDanhSachHoaDonNhapHang.Location = new System.Drawing.Point(237, 26);
            this.dgvDanhSachHoaDonNhapHang.Name = "dgvDanhSachHoaDonNhapHang";
            this.dgvDanhSachHoaDonNhapHang.RowHeadersWidth = 51;
            this.dgvDanhSachHoaDonNhapHang.RowTemplate.Height = 24;
            this.dgvDanhSachHoaDonNhapHang.Size = new System.Drawing.Size(1168, 370);
            this.dgvDanhSachHoaDonNhapHang.TabIndex = 28;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(7, 258);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(74, 16);
            this.lblThoiGian.TabIndex = 39;
            this.lblThoiGian.Text = "THỜI GIAN";
            // 
            // dateThoiGian
            // 
            this.dateThoiGian.CustomFormat = "dd/MM/yyyy";
            this.dateThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateThoiGian.Location = new System.Drawing.Point(104, 253);
            this.dateThoiGian.Name = "dateThoiGian";
            this.dateThoiGian.Size = new System.Drawing.Size(121, 22);
            this.dateThoiGian.TabIndex = 38;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.HeaderText = "MÃ HÓA ĐƠN";
            this.colMaHoaDon.MinimumWidth = 6;
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.Width = 125;
            // 
            // colMaKH
            // 
            this.colMaKH.HeaderText = "MÃ KH";
            this.colMaKH.MinimumWidth = 6;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Width = 125;
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "TÊN KH";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Width = 125;
            // 
            // colMaXe
            // 
            this.colMaXe.HeaderText = "MÃ XE";
            this.colMaXe.MinimumWidth = 6;
            this.colMaXe.Name = "colMaXe";
            this.colMaXe.Width = 125;
            // 
            // colTenXe
            // 
            this.colTenXe.HeaderText = "TÊN XE";
            this.colTenXe.MinimumWidth = 6;
            this.colTenXe.Name = "colTenXe";
            this.colTenXe.Width = 125;
            // 
            // colThoiGian
            // 
            this.colThoiGian.HeaderText = "THỜI GIAN";
            this.colThoiGian.MinimumWidth = 6;
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Width = 125;
            // 
            // colLoaiXe
            // 
            this.colLoaiXe.HeaderText = "LOẠI";
            this.colLoaiXe.MinimumWidth = 6;
            this.colLoaiXe.Name = "colLoaiXe";
            this.colLoaiXe.Width = 125;
            // 
            // colMau
            // 
            this.colMau.HeaderText = "MÀU";
            this.colMau.MinimumWidth = 6;
            this.colMau.Name = "colMau";
            this.colMau.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "SỐ LƯỢNG";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 125;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "GIÁ";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.Width = 125;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "THÀNH TIỀN";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 125;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(953, 478);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(198, 47);
            this.btnIn.TabIndex = 40;
            this.btnIn.Text = "In Hóa Đơn Xuất Hàng";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // frmHoaDonXuatHang
            // 
            this.AcceptButton = this.btnXuatHang;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 555);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDonXuatHang";
            this.Text = "frmHoaDonXuatHang";
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHoaDonNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cmbTenXe;
        private System.Windows.Forms.ComboBox cmbMaXe;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.ComboBox cmbMau;
        private System.Windows.Forms.Label lblMau;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.DataGridView dgvDanhSachHoaDonNhapHang;
        private System.Windows.Forms.ComboBox cmbTenKH;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.DateTimePicker dateThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}