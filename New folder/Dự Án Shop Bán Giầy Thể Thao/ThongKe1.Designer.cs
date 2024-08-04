namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    partial class ThongKe1
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
			btnXoa = new Button();
			btnSua = new Button();
			btnThem = new Button();
			label2 = new Label();
			label1 = new Label();
			txtMaThongKe = new TextBox();
			txtMaHoaDon = new TextBox();
			label3 = new Label();
			txtNguoiThongKe = new TextBox();
			label4 = new Label();
			label5 = new Label();
			dtpNgay = new DateTimePicker();
			txtSoLuongBan = new TextBox();
			label6 = new Label();
			label7 = new Label();
			txtThuNhap = new TextBox();
			label8 = new Label();
			label9 = new Label();
			dataGridViewThongKe = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridViewThongKe).BeginInit();
			SuspendLayout();
			// 
			// btnXoa
			// 
			btnXoa.BackColor = SystemColors.GradientActiveCaption;
			btnXoa.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btnXoa.Location = new Point(340, 118);
			btnXoa.Margin = new Padding(3, 2, 3, 2);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(190, 32);
			btnXoa.TabIndex = 6;
			btnXoa.Text = "Xoá";
			btnXoa.UseVisualStyleBackColor = false;
			// 
			// btnSua
			// 
			btnSua.BackColor = SystemColors.GradientActiveCaption;
			btnSua.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btnSua.Location = new Point(629, 118);
			btnSua.Margin = new Padding(3, 2, 3, 2);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(218, 32);
			btnSua.TabIndex = 5;
			btnSua.Text = "Sửa ";
			btnSua.UseVisualStyleBackColor = false;
			// 
			// btnThem
			// 
			btnThem.BackColor = SystemColors.GradientActiveCaption;
			btnThem.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btnThem.Location = new Point(87, 118);
			btnThem.Margin = new Padding(3, 2, 3, 2);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(192, 32);
			btnThem.TabIndex = 4;
			btnThem.Text = "Thêm ";
			btnThem.UseVisualStyleBackColor = false;
			btnThem.Click += btnThem_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(10, 7);
			label2.Name = "label2";
			label2.Size = new Size(0, 20);
			label2.TabIndex = 11;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(10, 7);
			label1.Name = "label1";
			label1.Size = new Size(102, 20);
			label1.TabIndex = 12;
			label1.Text = "Mã Thống Kê";
			// 
			// txtMaThongKe
			// 
			txtMaThongKe.Location = new Point(140, 7);
			txtMaThongKe.Margin = new Padding(3, 2, 3, 2);
			txtMaThongKe.Name = "txtMaThongKe";
			txtMaThongKe.Size = new Size(301, 23);
			txtMaThongKe.TabIndex = 13;
			// 
			// txtMaHoaDon
			// 
			txtMaHoaDon.Location = new Point(140, 45);
			txtMaHoaDon.Margin = new Padding(3, 2, 3, 2);
			txtMaHoaDon.Name = "txtMaHoaDon";
			txtMaHoaDon.Size = new Size(301, 23);
			txtMaHoaDon.TabIndex = 15;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(10, 45);
			label3.Name = "label3";
			label3.Size = new Size(97, 20);
			label3.TabIndex = 14;
			label3.Text = "Mã Hoá Đơn";
			// 
			// txtNguoiThongKe
			// 
			txtNguoiThongKe.Location = new Point(140, 84);
			txtNguoiThongKe.Margin = new Padding(3, 2, 3, 2);
			txtNguoiThongKe.Name = "txtNguoiThongKe";
			txtNguoiThongKe.Size = new Size(301, 23);
			txtNguoiThongKe.TabIndex = 17;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label4.Location = new Point(3, 84);
			label4.Name = "label4";
			label4.Size = new Size(125, 20);
			label4.TabIndex = 16;
			label4.Text = "Người Thống Kê";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label5.Location = new Point(501, 84);
			label5.Name = "label5";
			label5.Size = new Size(47, 20);
			label5.TabIndex = 18;
			label5.Text = "Ngày";
			// 
			// dtpNgay
			// 
			dtpNgay.Location = new Point(598, 84);
			dtpNgay.Margin = new Padding(3, 2, 3, 2);
			dtpNgay.Name = "dtpNgay";
			dtpNgay.Size = new Size(269, 23);
			dtpNgay.TabIndex = 19;
			// 
			// txtSoLuongBan
			// 
			txtSoLuongBan.Location = new Point(598, 8);
			txtSoLuongBan.Margin = new Padding(3, 2, 3, 2);
			txtSoLuongBan.Name = "txtSoLuongBan";
			txtSoLuongBan.Size = new Size(269, 23);
			txtSoLuongBan.TabIndex = 22;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label6.Location = new Point(468, 8);
			label6.Name = "label6";
			label6.Size = new Size(107, 20);
			label6.TabIndex = 21;
			label6.Text = "Số Lượng Bán";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label7.Location = new Point(468, 8);
			label7.Name = "label7";
			label7.Size = new Size(0, 20);
			label7.TabIndex = 20;
			// 
			// txtThuNhap
			// 
			txtThuNhap.Location = new Point(598, 46);
			txtThuNhap.Margin = new Padding(3, 2, 3, 2);
			txtThuNhap.Name = "txtThuNhap";
			txtThuNhap.Size = new Size(269, 23);
			txtThuNhap.TabIndex = 25;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label8.Location = new Point(492, 44);
			label8.Name = "label8";
			label8.Size = new Size(83, 20);
			label8.TabIndex = 24;
			label8.Text = "Thu Nhập ";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label9.Location = new Point(468, 46);
			label9.Name = "label9";
			label9.Size = new Size(0, 20);
			label9.TabIndex = 23;
			// 
			// dataGridViewThongKe
			// 
			dataGridViewThongKe.BackgroundColor = Color.FromArgb(224, 224, 224);
			dataGridViewThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewThongKe.Location = new Point(3, 166);
			dataGridViewThongKe.Margin = new Padding(3, 2, 3, 2);
			dataGridViewThongKe.Name = "dataGridViewThongKe";
			dataGridViewThongKe.RowHeadersWidth = 51;
			dataGridViewThongKe.RowTemplate.Height = 29;
			dataGridViewThongKe.Size = new Size(903, 460);
			dataGridViewThongKe.TabIndex = 26;
			// 
			// ThongKe1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			ClientSize = new Size(908, 627);
			Controls.Add(dataGridViewThongKe);
			Controls.Add(txtThuNhap);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(txtSoLuongBan);
			Controls.Add(label6);
			Controls.Add(label7);
			Controls.Add(dtpNgay);
			Controls.Add(label5);
			Controls.Add(txtNguoiThongKe);
			Controls.Add(label4);
			Controls.Add(txtMaHoaDon);
			Controls.Add(label3);
			Controls.Add(txtMaThongKe);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(btnXoa);
			Controls.Add(btnSua);
			Controls.Add(btnThem);
			Margin = new Padding(3, 2, 3, 2);
			Name = "ThongKe1";
			Text = "ThongKe";
			((System.ComponentModel.ISupportInitialize)dataGridViewThongKe).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridViewThongKe;
        private Label label2;
        private Label label1;
        private TextBox txtMaThongKe;
        private TextBox txtMaHoaDon;
        private Label label3;
        private TextBox txtNguoiThongKe;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpNgay;
        private TextBox txtSoLuongBan;
        private Label label6;
        private Label label7;
        private TextBox txtThuNhap;
        private Label label8;
        private Label label9;
    }
}