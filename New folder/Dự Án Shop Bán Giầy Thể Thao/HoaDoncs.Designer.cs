namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDoncs));
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
			button1 = new Button();
			sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)dtgView_HoaDon).BeginInit();
			SuspendLayout();
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(242, 9);
			label3.Name = "label3";
			label3.Size = new Size(353, 27);
			label3.TabIndex = 13;
			label3.Text = "Shop Bán Giầy Thể Thao ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("SimSun", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(298, 53);
			label1.Name = "label1";
			label1.Size = new Size(216, 38);
			label1.TabIndex = 14;
			label1.Text = "Hóa Đơn Thanh Toán \r\n\r\n";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(12, 124);
			label2.Name = "label2";
			label2.Size = new Size(107, 21);
			label2.TabIndex = 15;
			label2.Text = "Mã Hóa Đơn:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.White;
			label4.Location = new Point(429, 126);
			label4.Name = "label4";
			label4.Size = new Size(125, 21);
			label4.TabIndex = 16;
			label4.Text = "Tên Nhân Viên:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label5.ForeColor = Color.White;
			label5.Location = new Point(470, 169);
			label5.Name = "label5";
			label5.Size = new Size(84, 21);
			label5.TabIndex = 17;
			label5.Text = "Ngày Lập:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(5, 169);
			label6.Name = "label6";
			label6.Size = new Size(139, 21);
			label6.TabIndex = 18;
			label6.Text = "Tên Khách Hàng: ";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label7.ForeColor = Color.White;
			label7.Location = new Point(459, 452);
			label7.Name = "label7";
			label7.Size = new Size(87, 21);
			label7.TabIndex = 20;
			label7.Text = "Tổng Tiền:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label8.ForeColor = Color.White;
			label8.Location = new Point(459, 484);
			label8.Name = "label8";
			label8.Size = new Size(129, 21);
			label8.TabIndex = 21;
			label8.Text = "Tổng Khách Trả:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.Transparent;
			label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label9.ForeColor = Color.White;
			label9.Location = new Point(459, 514);
			label9.Name = "label9";
			label9.Size = new Size(88, 21);
			label9.TabIndex = 22;
			label9.Text = "Tiền Thừa:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.Black;
			label10.Font = new Font("SimSun", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label10.ForeColor = Color.White;
			label10.Location = new Point(57, 560);
			label10.Name = "label10";
			label10.Size = new Size(722, 70);
			label10.TabIndex = 23;
			label10.Text = "Cảm Ơn Quý Khách Đã Mua Hàng Tại Shop\r\n              😍😍😍\r\n";
			// 
			// dtgView_HoaDon
			// 
			dtgView_HoaDon.BackgroundColor = SystemColors.ControlLight;
			dtgView_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgView_HoaDon.Location = new Point(5, 209);
			dtgView_HoaDon.Margin = new Padding(3, 2, 3, 2);
			dtgView_HoaDon.Name = "dtgView_HoaDon";
			dtgView_HoaDon.RowHeadersWidth = 51;
			dtgView_HoaDon.RowTemplate.Height = 29;
			dtgView_HoaDon.Size = new Size(848, 236);
			dtgView_HoaDon.TabIndex = 19;
			// 
			// txt_NgayLap
			// 
			txt_NgayLap.Location = new Point(568, 164);
			txt_NgayLap.Margin = new Padding(3, 2, 3, 2);
			txt_NgayLap.Name = "txt_NgayLap";
			txt_NgayLap.Size = new Size(261, 23);
			txt_NgayLap.TabIndex = 48;
			// 
			// txt_TenNhanVien
			// 
			txt_TenNhanVien.Location = new Point(568, 126);
			txt_TenNhanVien.Margin = new Padding(3, 2, 3, 2);
			txt_TenNhanVien.Name = "txt_TenNhanVien";
			txt_TenNhanVien.Size = new Size(261, 23);
			txt_TenNhanVien.TabIndex = 47;
			// 
			// txt_TenKhachHang
			// 
			txt_TenKhachHang.Location = new Point(150, 169);
			txt_TenKhachHang.Margin = new Padding(3, 2, 3, 2);
			txt_TenKhachHang.Name = "txt_TenKhachHang";
			txt_TenKhachHang.Size = new Size(261, 23);
			txt_TenKhachHang.TabIndex = 46;
			// 
			// txt_MaHoaDon
			// 
			txt_MaHoaDon.Location = new Point(150, 126);
			txt_MaHoaDon.Margin = new Padding(3, 2, 3, 2);
			txt_MaHoaDon.Name = "txt_MaHoaDon";
			txt_MaHoaDon.Size = new Size(261, 23);
			txt_MaHoaDon.TabIndex = 45;
			// 
			// txt_TienThua
			// 
			txt_TienThua.Location = new Point(593, 511);
			txt_TienThua.Margin = new Padding(3, 2, 3, 2);
			txt_TienThua.Name = "txt_TienThua";
			txt_TienThua.Size = new Size(236, 23);
			txt_TienThua.TabIndex = 44;
			// 
			// txt_TienKhachTra
			// 
			txt_TienKhachTra.Location = new Point(593, 480);
			txt_TienKhachTra.Margin = new Padding(3, 2, 3, 2);
			txt_TienKhachTra.Name = "txt_TienKhachTra";
			txt_TienKhachTra.Size = new Size(236, 23);
			txt_TienKhachTra.TabIndex = 43;
			// 
			// txt_TongTien
			// 
			txt_TongTien.Location = new Point(593, 449);
			txt_TongTien.Margin = new Padding(3, 2, 3, 2);
			txt_TongTien.Name = "txt_TongTien";
			txt_TongTien.Size = new Size(236, 23);
			txt_TongTien.TabIndex = 42;
			// 
			// btn_luu
			// 
			btn_luu.BackColor = SystemColors.Info;
			btn_luu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btn_luu.Location = new Point(26, 468);
			btn_luu.Name = "btn_luu";
			btn_luu.Size = new Size(162, 49);
			btn_luu.TabIndex = 49;
			btn_luu.Text = "Lưu Hoá Đơn";
			btn_luu.UseVisualStyleBackColor = false;
			btn_luu.Click += btn_luu_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.Info;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(229, 468);
			button1.Name = "button1";
			button1.Size = new Size(166, 49);
			button1.TabIndex = 50;
			button1.Text = "Lưu Hoá Đơn";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// sqlCommand1
			// 
			sqlCommand1.CommandTimeout = 30;
			sqlCommand1.Connection = null;
			sqlCommand1.Notification = null;
			sqlCommand1.Transaction = null;
			// 
			// HoaDoncs
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientActiveCaption;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(856, 639);
			Controls.Add(button1);
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
		private Button button1;
		private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
	}
}