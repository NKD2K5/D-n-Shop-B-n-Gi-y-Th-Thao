﻿namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    partial class HoaDoncs
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
			label3 = new Label();
			label1 = new Label();
			label2 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			dtgView_HoaDon = new DataGridView();
			txt_NgayLap = new TextBox();
			txt_TenNhanVien = new TextBox();
			txt_TenKhachHang = new TextBox();
			txt_MaHoaDon = new TextBox();
			txt_TienThua = new TextBox();
			txt_TienKhachTra = new TextBox();
			txt_TongTien = new TextBox();
			btn_luu = new Button();
			((System.ComponentModel.ISupportInitialize)dtgView_HoaDon).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(158, 21);
			label3.Name = "label3";
			label3.Size = new Size(353, 27);
			label3.TabIndex = 13;
			label3.Text = "Shop Bán Giầy Thể Thao ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("SimSun", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(214, 65);
			label1.Name = "label1";
			label1.Size = new Size(216, 38);
			label1.TabIndex = 14;
			label1.Text = "Hóa Đơn Thanh Toán \r\n\r\n";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(34, 106);
			label2.Name = "label2";
			label2.Size = new Size(96, 19);
			label2.TabIndex = 15;
			label2.Text = "Mã Hóa Đơn:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(34, 142);
			label4.Name = "label4";
			label4.Size = new Size(107, 19);
			label4.TabIndex = 16;
			label4.Text = "Tên Nhân Viên:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label5.Location = new Point(386, 106);
			label5.Name = "label5";
			label5.Size = new Size(75, 19);
			label5.TabIndex = 17;
			label5.Text = "Ngày Lập:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label6.Location = new Point(34, 179);
			label6.Name = "label6";
			label6.Size = new Size(122, 19);
			label6.TabIndex = 18;
			label6.Text = "Tên Khách Hàng: ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label7.Location = new Point(312, 330);
			label7.Name = "label7";
			label7.Size = new Size(76, 19);
			label7.TabIndex = 20;
			label7.Text = "Tổng Tiền:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label8.Location = new Point(312, 362);
			label8.Name = "label8";
			label8.Size = new Size(114, 19);
			label8.TabIndex = 21;
			label8.Text = "Tổng Khách Trả:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label9.Location = new Point(312, 392);
			label9.Name = "label9";
			label9.Size = new Size(77, 19);
			label9.TabIndex = 22;
			label9.Text = "Tiền Thừa:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("SimSun", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label10.Location = new Point(61, 442);
			label10.Name = "label10";
			label10.Size = new Size(453, 44);
			label10.TabIndex = 23;
			label10.Text = "Cảm Ơn Quý Khách Đã Mua Hàng Tại Shop\r\n              😍😍😍\r\n";
			// 
			// dtgView_HoaDon
			// 
			dtgView_HoaDon.BackgroundColor = SystemColors.ControlLight;
			dtgView_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgView_HoaDon.Location = new Point(3, 210);
			dtgView_HoaDon.Margin = new Padding(3, 2, 3, 2);
			dtgView_HoaDon.Name = "dtgView_HoaDon";
			dtgView_HoaDon.RowHeadersWidth = 51;
			dtgView_HoaDon.RowTemplate.Height = 29;
			dtgView_HoaDon.Size = new Size(646, 112);
			dtgView_HoaDon.TabIndex = 19;
			// 
			// txt_NgayLap
			// 
			txt_NgayLap.Location = new Point(480, 106);
			txt_NgayLap.Margin = new Padding(3, 2, 3, 2);
			txt_NgayLap.Name = "txt_NgayLap";
			txt_NgayLap.Size = new Size(156, 23);
			txt_NgayLap.TabIndex = 48;
			// 
			// txt_TenNhanVien
			// 
			txt_TenNhanVien.Location = new Point(172, 146);
			txt_TenNhanVien.Margin = new Padding(3, 2, 3, 2);
			txt_TenNhanVien.Name = "txt_TenNhanVien";
			txt_TenNhanVien.Size = new Size(190, 23);
			txt_TenNhanVien.TabIndex = 47;
			// 
			// txt_TenKhachHang
			// 
			txt_TenKhachHang.Location = new Point(172, 182);
			txt_TenKhachHang.Margin = new Padding(3, 2, 3, 2);
			txt_TenKhachHang.Name = "txt_TenKhachHang";
			txt_TenKhachHang.Size = new Size(190, 23);
			txt_TenKhachHang.TabIndex = 46;
			// 
			// txt_MaHoaDon
			// 
			txt_MaHoaDon.Location = new Point(172, 105);
			txt_MaHoaDon.Margin = new Padding(3, 2, 3, 2);
			txt_MaHoaDon.Name = "txt_MaHoaDon";
			txt_MaHoaDon.Size = new Size(190, 23);
			txt_MaHoaDon.TabIndex = 45;
			// 
			// txt_TienThua
			// 
			txt_TienThua.Location = new Point(446, 389);
			txt_TienThua.Margin = new Padding(3, 2, 3, 2);
			txt_TienThua.Name = "txt_TienThua";
			txt_TienThua.Size = new Size(190, 23);
			txt_TienThua.TabIndex = 44;
			// 
			// txt_TienKhachTra
			// 
			txt_TienKhachTra.Location = new Point(446, 358);
			txt_TienKhachTra.Margin = new Padding(3, 2, 3, 2);
			txt_TienKhachTra.Name = "txt_TienKhachTra";
			txt_TienKhachTra.Size = new Size(190, 23);
			txt_TienKhachTra.TabIndex = 43;
			// 
			// txt_TongTien
			// 
			txt_TongTien.Location = new Point(446, 327);
			txt_TongTien.Margin = new Padding(3, 2, 3, 2);
			txt_TongTien.Name = "txt_TongTien";
			txt_TongTien.Size = new Size(190, 23);
			txt_TongTien.TabIndex = 42;
			// 
			// btn_luu
			// 
			btn_luu.Location = new Point(61, 348);
			btn_luu.Name = "btn_luu";
			btn_luu.Size = new Size(129, 49);
			btn_luu.TabIndex = 49;
			btn_luu.Text = "Lưu Hoá Đơn";
			btn_luu.UseVisualStyleBackColor = true;
			// 
			// HoaDoncs
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(646, 511);
			Controls.Add(btn_luu);
			Controls.Add(txt_NgayLap);
			Controls.Add(txt_TenNhanVien);
			Controls.Add(txt_TenKhachHang);
			Controls.Add(txt_MaHoaDon);
			Controls.Add(txt_TienThua);
			Controls.Add(txt_TienKhachTra);
			Controls.Add(txt_TongTien);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(dtgView_HoaDon);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(label3);
			Margin = new Padding(3, 2, 3, 2);
			Name = "HoaDoncs";
			Text = "HoaDoncs";
			Load += HoaDoncs_Load;
			((System.ComponentModel.ISupportInitialize)dtgView_HoaDon).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dtgView_HoaDon;
        private TextBox txt_NgayLap;
        private TextBox txt_TenNhanVien;
        private TextBox txt_TenKhachHang;
        private TextBox txt_MaHoaDon;
        private TextBox txt_TienThua;
        private TextBox txt_TienKhachTra;
        private TextBox txt_TongTien;
		private Button btn_luu;
	}
}