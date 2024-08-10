namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    partial class Sản_Phẩm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sản_Phẩm));
			dgvSanPham = new DataGridView();
			btn_Them = new Button();
			btn_Sua = new Button();
			btn_Xoa = new Button();
			txt_TonKho = new TextBox();
			txt_TenSanPham = new TextBox();
			label2 = new Label();
			label1 = new Label();
			label3 = new Label();
			label4 = new Label();
			dateTime_NgayNhap = new DateTimePicker();
			label5 = new Label();
			txt_GiaNhap = new TextBox();
			txt_GiaBan = new TextBox();
			label6 = new Label();
			cbb_MaLoaiSanPham = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
			SuspendLayout();
			// 
			// dgvSanPham
			// 
			dgvSanPham.BackgroundColor = SystemColors.ControlLight;
			dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSanPham.Location = new Point(1, 176);
			dgvSanPham.Margin = new Padding(3, 2, 3, 2);
			dgvSanPham.Name = "dgvSanPham";
			dgvSanPham.RowHeadersWidth = 51;
			dgvSanPham.RowTemplate.Height = 29;
			dgvSanPham.Size = new Size(1043, 455);
			dgvSanPham.TabIndex = 0;
			dgvSanPham.CellClick += dgvSanPham_CellClick;
			// 
			// btn_Them
			// 
			btn_Them.BackColor = SystemColors.GradientActiveCaption;
			btn_Them.BackgroundImage = (Image)resources.GetObject("btn_Them.BackgroundImage");
			btn_Them.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btn_Them.Location = new Point(149, 126);
			btn_Them.Margin = new Padding(3, 2, 3, 2);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new Size(237, 46);
			btn_Them.TabIndex = 1;
			btn_Them.Text = "Thêm ";
			btn_Them.UseVisualStyleBackColor = false;
			btn_Them.Click += button1_Click_1;
			// 
			// btn_Sua
			// 
			btn_Sua.BackColor = SystemColors.GradientActiveCaption;
			btn_Sua.BackgroundImage = (Image)resources.GetObject("btn_Sua.BackgroundImage");
			btn_Sua.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btn_Sua.Location = new Point(433, 126);
			btn_Sua.Margin = new Padding(3, 2, 3, 2);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(247, 46);
			btn_Sua.TabIndex = 2;
			btn_Sua.Text = "Sửa ";
			btn_Sua.UseVisualStyleBackColor = false;
			btn_Sua.Click += button2_Click;
			// 
			// btn_Xoa
			// 
			btn_Xoa.BackColor = SystemColors.GradientActiveCaption;
			btn_Xoa.BackgroundImage = (Image)resources.GetObject("btn_Xoa.BackgroundImage");
			btn_Xoa.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			btn_Xoa.Location = new Point(720, 126);
			btn_Xoa.Margin = new Padding(3, 2, 3, 2);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(219, 46);
			btn_Xoa.TabIndex = 3;
			btn_Xoa.Text = "Xoá";
			btn_Xoa.UseVisualStyleBackColor = false;
			btn_Xoa.Click += button3_Click;
			// 
			// txt_TonKho
			// 
			txt_TonKho.Location = new Point(183, 84);
			txt_TonKho.Margin = new Padding(3, 2, 3, 2);
			txt_TonKho.Name = "txt_TonKho";
			txt_TonKho.Size = new Size(238, 23);
			txt_TonKho.TabIndex = 9;
			// 
			// txt_TenSanPham
			// 
			txt_TenSanPham.Location = new Point(183, 48);
			txt_TenSanPham.Margin = new Padding(3, 2, 3, 2);
			txt_TenSanPham.Name = "txt_TenSanPham";
			txt_TenSanPham.Size = new Size(238, 23);
			txt_TenSanPham.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(18, 17);
			label2.Name = "label2";
			label2.Size = new Size(141, 20);
			label2.TabIndex = 10;
			label2.Text = "Mã Loại Sản Phẩm";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(18, 51);
			label1.Name = "label1";
			label1.Size = new Size(110, 20);
			label1.TabIndex = 11;
			label1.Text = "Tên Sản Phẩm";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(18, 87);
			label3.Name = "label3";
			label3.Size = new Size(72, 20);
			label3.TabIndex = 12;
			label3.Text = "Tồn Kho ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label4.ForeColor = Color.White;
			label4.Location = new Point(661, 17);
			label4.Name = "label4";
			label4.Size = new Size(90, 20);
			label4.TabIndex = 13;
			label4.Text = "Ngày Nhập";
			// 
			// dateTime_NgayNhap
			// 
			dateTime_NgayNhap.Location = new Point(783, 14);
			dateTime_NgayNhap.Margin = new Padding(3, 2, 3, 2);
			dateTime_NgayNhap.Name = "dateTime_NgayNhap";
			dateTime_NgayNhap.Size = new Size(219, 23);
			dateTime_NgayNhap.TabIndex = 14;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label5.ForeColor = Color.White;
			label5.Location = new Point(661, 82);
			label5.Name = "label5";
			label5.Size = new Size(70, 20);
			label5.TabIndex = 15;
			label5.Text = " Giá Bán";
			// 
			// txt_GiaNhap
			// 
			txt_GiaNhap.Location = new Point(783, 47);
			txt_GiaNhap.Margin = new Padding(3, 2, 3, 2);
			txt_GiaNhap.Name = "txt_GiaNhap";
			txt_GiaNhap.Size = new Size(219, 23);
			txt_GiaNhap.TabIndex = 16;
			// 
			// txt_GiaBan
			// 
			txt_GiaBan.Location = new Point(783, 82);
			txt_GiaBan.Margin = new Padding(3, 2, 3, 2);
			txt_GiaBan.Name = "txt_GiaBan";
			txt_GiaBan.Size = new Size(219, 23);
			txt_GiaBan.TabIndex = 18;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(661, 48);
			label6.Name = "label6";
			label6.Size = new Size(77, 20);
			label6.TabIndex = 17;
			label6.Text = "Giá Nhập";
			// 
			// cbb_MaLoaiSanPham
			// 
			cbb_MaLoaiSanPham.FormattingEnabled = true;
			cbb_MaLoaiSanPham.Location = new Point(184, 14);
			cbb_MaLoaiSanPham.Margin = new Padding(3, 2, 3, 2);
			cbb_MaLoaiSanPham.Name = "cbb_MaLoaiSanPham";
			cbb_MaLoaiSanPham.Size = new Size(237, 23);
			cbb_MaLoaiSanPham.TabIndex = 19;
			cbb_MaLoaiSanPham.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// Sản_Phẩm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.GradientInactiveCaption;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(1046, 629);
			Controls.Add(cbb_MaLoaiSanPham);
			Controls.Add(txt_GiaBan);
			Controls.Add(label6);
			Controls.Add(txt_GiaNhap);
			Controls.Add(label5);
			Controls.Add(dateTime_NgayNhap);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(txt_TonKho);
			Controls.Add(txt_TenSanPham);
			Controls.Add(btn_Xoa);
			Controls.Add(btn_Sua);
			Controls.Add(btn_Them);
			Controls.Add(dgvSanPham);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Sản_Phẩm";
			Text = "Sản_Phẩm";
			((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvSanPham;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
        private TextBox txt_TonKho;
        private TextBox txt_TenSanPham;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTime_NgayNhap;
        private Label label5;
        private TextBox txt_GiaNhap;
        private TextBox txt_GiaBan;
        private Label label6;
        private ComboBox cbb_MaLoaiSanPham;
    }
}