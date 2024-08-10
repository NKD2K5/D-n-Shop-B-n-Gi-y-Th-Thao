namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    partial class Voucher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voucher));
			cbb_TenVoucher = new ComboBox();
			label10 = new Label();
			txt_HSD = new TextBox();
			label12 = new Label();
			label11 = new Label();
			label4 = new Label();
			dateTime_NgayHetHan = new DateTimePicker();
			cbb_LoaiVoucher = new ComboBox();
			label8 = new Label();
			label9 = new Label();
			txt_NguoiTao = new TextBox();
			label6 = new Label();
			label7 = new Label();
			dateTime_NgayTao = new DateTimePicker();
			label5 = new Label();
			txt_TrangThai = new TextBox();
			txt_MaVoucher = new TextBox();
			label3 = new Label();
			label1 = new Label();
			label2 = new Label();
			dtgView_Voucher = new DataGridView();
			btn_Xoa = new Button();
			btn_Sua = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dtgView_Voucher).BeginInit();
			SuspendLayout();
			// 
			// cbb_TenVoucher
			// 
			cbb_TenVoucher.FormattingEnabled = true;
			cbb_TenVoucher.Items.AddRange(new object[] { "Voucher Giảm Giá Phần Trăm", "", "Voucher Giảm Giá Số Tiền Cụ Thể", "", "Voucher Mua 1 Tặng 1", "", "Voucher Lần Mua Đầu Tiên", "Voucher Sinh Nhật", "", "Voucher Khách Hàng Thân Thiết", "", "Voucher Nhóm Sản Phẩm", "", "Voucher Sự Kiện", "", "Voucher Ứng Dụng Di Động" });
			cbb_TenVoucher.Location = new Point(138, 81);
			cbb_TenVoucher.Margin = new Padding(3, 2, 3, 2);
			cbb_TenVoucher.Name = "cbb_TenVoucher";
			cbb_TenVoucher.Size = new Size(176, 23);
			cbb_TenVoucher.TabIndex = 78;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.Transparent;
			label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label10.ForeColor = Color.White;
			label10.Location = new Point(12, 84);
			label10.Name = "label10";
			label10.Size = new Size(97, 20);
			label10.TabIndex = 77;
			label10.Text = "Tên Voucher";
			// 
			// txt_HSD
			// 
			txt_HSD.Location = new Point(863, 11);
			txt_HSD.Margin = new Padding(3, 2, 3, 2);
			txt_HSD.Name = "txt_HSD";
			txt_HSD.Size = new Size(153, 23);
			txt_HSD.TabIndex = 76;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = Color.Transparent;
			label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label12.ForeColor = Color.White;
			label12.Location = new Point(769, 11);
			label12.Name = "label12";
			label12.Size = new Size(40, 20);
			label12.TabIndex = 75;
			label12.Text = "TGD";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label11.Location = new Point(430, 267);
			label11.Name = "label11";
			label11.Size = new Size(0, 20);
			label11.TabIndex = 74;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.White;
			label4.Location = new Point(10, 8);
			label4.Name = "label4";
			label4.Size = new Size(93, 20);
			label4.TabIndex = 73;
			label4.Text = "Mã Voucher";
			// 
			// dateTime_NgayHetHan
			// 
			dateTime_NgayHetHan.Location = new Point(509, 42);
			dateTime_NgayHetHan.Margin = new Padding(3, 2, 3, 2);
			dateTime_NgayHetHan.Name = "dateTime_NgayHetHan";
			dateTime_NgayHetHan.Size = new Size(213, 23);
			dateTime_NgayHetHan.TabIndex = 72;
			// 
			// cbb_LoaiVoucher
			// 
			cbb_LoaiVoucher.FormattingEnabled = true;
			cbb_LoaiVoucher.Items.AddRange(new object[] { "Voucher Giảm Giá Phần Trăm", "", "Voucher Giảm Giá Số Tiền Cụ Thể", "", "Voucher Mua 1 Tặng 1", "", "Voucher Lần Mua Đầu Tiên", "Voucher Sinh Nhật", "", "Voucher Khách Hàng Thân Thiết", "", "Voucher Nhóm Sản Phẩm", "", "Voucher Sự Kiện", "", "Voucher Ứng Dụng Di Động" });
			cbb_LoaiVoucher.Location = new Point(140, 45);
			cbb_LoaiVoucher.Margin = new Padding(3, 2, 3, 2);
			cbb_LoaiVoucher.Name = "cbb_LoaiVoucher";
			cbb_LoaiVoucher.Size = new Size(174, 23);
			cbb_LoaiVoucher.TabIndex = 71;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label8.ForeColor = Color.White;
			label8.Location = new Point(380, 42);
			label8.Name = "label8";
			label8.Size = new Size(109, 20);
			label8.TabIndex = 70;
			label8.Text = "Ngày Hết Hạn";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.Transparent;
			label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label9.ForeColor = Color.White;
			label9.Location = new Point(330, 43);
			label9.Name = "label9";
			label9.Size = new Size(0, 20);
			label9.TabIndex = 69;
			// 
			// txt_NguoiTao
			// 
			txt_NguoiTao.Location = new Point(509, 8);
			txt_NguoiTao.Margin = new Padding(3, 2, 3, 2);
			txt_NguoiTao.Name = "txt_NguoiTao";
			txt_NguoiTao.Size = new Size(213, 23);
			txt_NguoiTao.TabIndex = 68;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(384, 8);
			label6.Name = "label6";
			label6.Size = new Size(85, 20);
			label6.TabIndex = 67;
			label6.Text = "Người Tạo\r\n";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label7.ForeColor = Color.White;
			label7.Location = new Point(330, 4);
			label7.Name = "label7";
			label7.Size = new Size(0, 20);
			label7.TabIndex = 66;
			// 
			// dateTime_NgayTao
			// 
			dateTime_NgayTao.Location = new Point(509, 78);
			dateTime_NgayTao.Margin = new Padding(3, 2, 3, 2);
			dateTime_NgayTao.Name = "dateTime_NgayTao";
			dateTime_NgayTao.Size = new Size(213, 23);
			dateTime_NgayTao.TabIndex = 65;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label5.ForeColor = Color.White;
			label5.Location = new Point(384, 78);
			label5.Name = "label5";
			label5.Size = new Size(78, 20);
			label5.TabIndex = 64;
			label5.Text = "Ngày Tạo";
			// 
			// txt_TrangThai
			// 
			txt_TrangThai.Location = new Point(862, 50);
			txt_TrangThai.Margin = new Padding(3, 2, 3, 2);
			txt_TrangThai.Name = "txt_TrangThai";
			txt_TrangThai.Size = new Size(154, 23);
			txt_TrangThai.TabIndex = 63;
			// 
			// txt_MaVoucher
			// 
			txt_MaVoucher.Location = new Point(140, 8);
			txt_MaVoucher.Margin = new Padding(3, 2, 3, 2);
			txt_MaVoucher.Name = "txt_MaVoucher";
			txt_MaVoucher.Size = new Size(174, 23);
			txt_MaVoucher.TabIndex = 62;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(769, 50);
			label3.Name = "label3";
			label3.Size = new Size(87, 20);
			label3.TabIndex = 61;
			label3.Text = "Trạng Thái";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(10, 45);
			label1.Name = "label1";
			label1.Size = new Size(102, 20);
			label1.TabIndex = 60;
			label1.Text = "Loại Voucher";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(10, 8);
			label2.Name = "label2";
			label2.Size = new Size(0, 20);
			label2.TabIndex = 59;
			// 
			// dtgView_Voucher
			// 
			dtgView_Voucher.BackgroundColor = SystemColors.ControlLight;
			dtgView_Voucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgView_Voucher.Location = new Point(4, 167);
			dtgView_Voucher.Margin = new Padding(3, 2, 3, 2);
			dtgView_Voucher.Name = "dtgView_Voucher";
			dtgView_Voucher.RowHeadersWidth = 51;
			dtgView_Voucher.RowTemplate.Height = 29;
			dtgView_Voucher.Size = new Size(1065, 459);
			dtgView_Voucher.TabIndex = 58;
			dtgView_Voucher.CellClick += dtgView_Voucher_CellClick;
			// 
			// btn_Xoa
			// 
			btn_Xoa.BackColor = SystemColors.GradientActiveCaption;
			btn_Xoa.BackgroundImage = (Image)resources.GetObject("btn_Xoa.BackgroundImage");
			btn_Xoa.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btn_Xoa.Location = new Point(803, 118);
			btn_Xoa.Margin = new Padding(3, 2, 3, 2);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(208, 45);
			btn_Xoa.TabIndex = 57;
			btn_Xoa.Text = "Xoá";
			btn_Xoa.UseVisualStyleBackColor = false;
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.BackColor = SystemColors.GradientActiveCaption;
			btn_Sua.BackgroundImage = (Image)resources.GetObject("btn_Sua.BackgroundImage");
			btn_Sua.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btn_Sua.Location = new Point(397, 118);
			btn_Sua.Margin = new Padding(3, 2, 3, 2);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(203, 45);
			btn_Sua.TabIndex = 56;
			btn_Sua.Text = "Sửa ";
			btn_Sua.UseVisualStyleBackColor = false;
			btn_Sua.Click += btn_Sua_Click;
			// 
			// button1
			// 
			button1.BackColor = SystemColors.GradientActiveCaption;
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			button1.Location = new Point(57, 118);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(202, 45);
			button1.TabIndex = 55;
			button1.Text = "Thêm ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// Voucher
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1072, 631);
			Controls.Add(cbb_TenVoucher);
			Controls.Add(label10);
			Controls.Add(txt_HSD);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(label4);
			Controls.Add(dateTime_NgayHetHan);
			Controls.Add(cbb_LoaiVoucher);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(txt_NguoiTao);
			Controls.Add(label6);
			Controls.Add(label7);
			Controls.Add(dateTime_NgayTao);
			Controls.Add(label5);
			Controls.Add(txt_TrangThai);
			Controls.Add(txt_MaVoucher);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(dtgView_Voucher);
			Controls.Add(btn_Xoa);
			Controls.Add(btn_Sua);
			Controls.Add(button1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Voucher";
			Text = "Voucher";
			((System.ComponentModel.ISupportInitialize)dtgView_Voucher).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbb_TenVoucher;
		private Label label10;
		private TextBox txt_HSD;
		private Label label12;
		private Label label11;
		private Label label4;
		private DateTimePicker dateTime_NgayHetHan;
		private ComboBox cbb_LoaiVoucher;
		private Label label8;
		private Label label9;
		private TextBox txt_NguoiTao;
		private Label label6;
		private Label label7;
		private DateTimePicker dateTime_NgayTao;
		private Label label5;
		private TextBox txt_TrangThai;
		private TextBox txt_MaVoucher;
		private Label label3;
		private Label label1;
		private Label label2;
		private DataGridView dtgView_Voucher;
		private Button btn_Xoa;
		private Button btn_Sua;
		private Button button1;
	}
}