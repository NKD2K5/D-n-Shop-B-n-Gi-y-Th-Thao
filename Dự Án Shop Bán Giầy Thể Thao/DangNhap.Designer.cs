namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txt_TenTk = new TextBox();
            txt_MatKhau = new TextBox();
            DangKy = new LinkLabel();
            linkLabel_QuenMatKhau = new LinkLabel();
            btn_DangNhap = new Button();
            label1 = new Label();
            QuenMatKhau = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 199);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(91, 261);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(91, 322);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 42);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txt_TenTk
            // 
            txt_TenTk.Location = new Point(174, 273);
            txt_TenTk.Name = "txt_TenTk";
            txt_TenTk.Size = new Size(220, 27);
            txt_TenTk.TabIndex = 3;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(174, 337);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(220, 27);
            txt_MatKhau.TabIndex = 4;
            // 
            // DangKy
            // 
            DangKy.AutoSize = true;
            DangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DangKy.LinkColor = Color.Black;
            DangKy.Location = new Point(91, 388);
            DangKy.Name = "DangKy";
            DangKy.Size = new Size(78, 23);
            DangKy.TabIndex = 5;
            DangKy.TabStop = true;
            DangKy.Text = "Đăng Ký ";
            DangKy.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel_QuenMatKhau
            // 
            linkLabel_QuenMatKhau.AutoSize = true;
            linkLabel_QuenMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel_QuenMatKhau.LinkColor = Color.Black;
            linkLabel_QuenMatKhau.Location = new Point(292, 386);
            linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            linkLabel_QuenMatKhau.Size = new Size(0, 25);
            linkLabel_QuenMatKhau.TabIndex = 6;
            linkLabel_QuenMatKhau.TabStop = true;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.ForeColor = SystemColors.ActiveCaptionText;
            btn_DangNhap.Location = new Point(151, 435);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(193, 48);
            btn_DangNhap.TabIndex = 7;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(73, 201);
            label1.Name = "label1";
            label1.Size = new Size(427, 34);
            label1.TabIndex = 8;
            label1.Text = "Shop Bán Giầy Thể Thao ";
            // 
            // QuenMatKhau
            // 
            QuenMatKhau.AutoSize = true;
            QuenMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuenMatKhau.LinkColor = Color.Black;
            QuenMatKhau.Location = new Point(316, 388);
            QuenMatKhau.Name = "QuenMatKhau";
            QuenMatKhau.Size = new Size(131, 23);
            QuenMatKhau.TabIndex = 9;
            QuenMatKhau.TabStop = true;
            QuenMatKhau.Text = "Quên Mật Khẩu";
            QuenMatKhau.LinkClicked += QuanMatKhau_LinkClicked;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(547, 511);
            Controls.Add(QuenMatKhau);
            Controls.Add(label1);
            Controls.Add(btn_DangNhap);
            Controls.Add(linkLabel_QuenMatKhau);
            Controls.Add(DangKy);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TenTk);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "DangNhap";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txt_TenTk;
        private TextBox txt_MatKhau;
        private LinkLabel DangKy;
        private LinkLabel linkLabel_QuenMatKhau;
        private Button btn_DangNhap;
        private Label label1;
        private LinkLabel QuenMatKhau;
    }
}
