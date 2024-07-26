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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txt_TenTk = new TextBox();
            txt_MatKhau = new TextBox();
            DangKy = new LinkLabel();
            linkLabel_QuenMatKhau = new LinkLabel();
            btn_DangNhap = new Button();
            label1 = new Label();
            QuenMatKhau = new LinkLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 87);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 141);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txt_TenTk
            // 
            txt_TenTk.Location = new Point(89, 96);
            txt_TenTk.Margin = new Padding(3, 2, 3, 2);
            txt_TenTk.Multiline = true;
            txt_TenTk.Name = "txt_TenTk";
            txt_TenTk.ReadOnly = true;
            txt_TenTk.Size = new Size(215, 26);
            txt_TenTk.TabIndex = 3;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(89, 151);
            txt_MatKhau.Margin = new Padding(3, 2, 3, 2);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(215, 23);
            txt_MatKhau.TabIndex = 4;
            txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // DangKy
            // 
            DangKy.AutoSize = true;
            DangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DangKy.LinkColor = Color.Black;
            DangKy.Location = new Point(53, 185);
            DangKy.Name = "DangKy";
            DangKy.Size = new Size(64, 19);
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
            linkLabel_QuenMatKhau.Location = new Point(246, 184);
            linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            linkLabel_QuenMatKhau.Size = new Size(0, 20);
            linkLabel_QuenMatKhau.TabIndex = 6;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.ForeColor = SystemColors.ActiveCaptionText;
            btn_DangNhap.Location = new Point(89, 228);
            btn_DangNhap.Margin = new Padding(3, 2, 3, 2);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(170, 40);
            btn_DangNhap.TabIndex = 7;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(328, 32);
            label1.TabIndex = 8;
            label1.Text = "Shop Bán Giầy Thể Thao ";
            label1.Click += label1_Click;
            // 
            // QuenMatKhau
            // 
            QuenMatKhau.AutoSize = true;
            QuenMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuenMatKhau.LinkColor = Color.Black;
            QuenMatKhau.Location = new Point(208, 184);
            QuenMatKhau.Name = "QuenMatKhau";
            QuenMatKhau.Size = new Size(107, 19);
            QuenMatKhau.TabIndex = 9;
            QuenMatKhau.TabStop = true;
            QuenMatKhau.Text = "Quên Mật Khẩu";
            QuenMatKhau.LinkClicked += QuanMatKhau_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(DangKy);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(QuenMatKhau);
            panel1.Controls.Add(txt_MatKhau);
            panel1.Controls.Add(linkLabel_QuenMatKhau);
            panel1.Controls.Add(txt_TenTk);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btn_DangNhap);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(301, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 294);
            panel1.TabIndex = 10;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(643, 405);
            Controls.Add(panel1);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DangNhap";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txt_TenTk;
        private TextBox txt_MatKhau;
        private LinkLabel DangKy;
        private LinkLabel linkLabel_QuenMatKhau;
        private Button btn_DangNhap;
        private Label label1;
        private LinkLabel QuenMatKhau;
        private Panel panel1;
    }
}
