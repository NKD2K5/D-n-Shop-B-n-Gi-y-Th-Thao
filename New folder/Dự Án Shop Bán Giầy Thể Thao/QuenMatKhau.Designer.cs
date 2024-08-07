namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    partial class QuenMatKhau
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
			txt_EmailDangKy = new TextBox();
			label1 = new Label();
			label2 = new Label();
			txt_MatKhau = new TextBox();
			label3 = new Label();
			button1 = new Button();
			textBox1 = new TextBox();
			label4 = new Label();
			SuspendLayout();
			// 
			// txt_EmailDangKy
			// 
			txt_EmailDangKy.Location = new Point(282, 178);
			txt_EmailDangKy.Margin = new Padding(3, 2, 3, 2);
			txt_EmailDangKy.Name = "txt_EmailDangKy";
			txt_EmailDangKy.Size = new Size(193, 23);
			txt_EmailDangKy.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(107, 176);
			label1.Name = "label1";
			label1.Size = new Size(112, 21);
			label1.TabIndex = 9;
			label1.Text = "Email Đăng Ký:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(107, 216);
			label2.Name = "label2";
			label2.Size = new Size(111, 21);
			label2.TabIndex = 10;
			label2.Text = "Mật Khẩu Mới:\r\n";
			// 
			// txt_MatKhau
			// 
			txt_MatKhau.Location = new Point(282, 216);
			txt_MatKhau.Margin = new Padding(3, 2, 3, 2);
			txt_MatKhau.Name = "txt_MatKhau";
			txt_MatKhau.Size = new Size(193, 23);
			txt_MatKhau.TabIndex = 11;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(138, 108);
			label3.Name = "label3";
			label3.Size = new Size(353, 27);
			label3.TabIndex = 12;
			label3.Text = "Shop Bán Giầy Thể Thao ";
			// 
			// button1
			// 
			button1.BackColor = Color.Transparent;
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			button1.ForeColor = SystemColors.ActiveCaptionText;
			button1.Location = new Point(213, 332);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(169, 44);
			button1.TabIndex = 13;
			button1.Text = "Lấy Lại Mật Khẩu ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(282, 259);
			textBox1.Margin = new Padding(3, 2, 3, 2);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(193, 23);
			textBox1.TabIndex = 15;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.White;
			label4.Location = new Point(107, 259);
			label4.Name = "label4";
			label4.Size = new Size(149, 42);
			label4.TabIndex = 14;
			label4.Text = "Xác Nhận Mật Khẩu:\r\n\r\n";
			// 
			// QuenMatKhau
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(610, 407);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(txt_MatKhau);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txt_EmailDangKy);
			Margin = new Padding(3, 2, 3, 2);
			Name = "QuenMatKhau";
			Text = "Quên_Mật_Khẩu";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txt_EmailDangKy;
        private Label label1;
        private Label label2;
        private TextBox txt_MatKhau;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
    }
}