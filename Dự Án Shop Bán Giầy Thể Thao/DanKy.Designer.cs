namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            txt_XacNhanMK = new TextBox();
            txt_Email = new TextBox();
            txt_MatKhau = new TextBox();
            txt_TenTK = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_XacNhanMK
            // 
            txt_XacNhanMK.Location = new Point(469, 199);
            txt_XacNhanMK.Margin = new Padding(3, 2, 3, 2);
            txt_XacNhanMK.Name = "txt_XacNhanMK";
            txt_XacNhanMK.Size = new Size(193, 23);
            txt_XacNhanMK.TabIndex = 4;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(469, 234);
            txt_Email.Margin = new Padding(3, 2, 3, 2);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(193, 23);
            txt_Email.TabIndex = 5;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(469, 162);
            txt_MatKhau.Margin = new Padding(3, 2, 3, 2);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(193, 23);
            txt_MatKhau.TabIndex = 6;
            // 
            // txt_TenTK
            // 
            txt_TenTK.Location = new Point(469, 119);
            txt_TenTK.Margin = new Padding(3, 2, 3, 2);
            txt_TenTK.Name = "txt_TenTK";
            txt_TenTK.Size = new Size(193, 23);
            txt_TenTK.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(328, 119);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 39;
            label1.Text = "Tên Tài Khoản: \r\n";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(319, 45);
            label2.Name = "label2";
            label2.Size = new Size(353, 27);
            label2.TabIndex = 10;
            label2.Text = "Shop Bán Giầy Thể Thao ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(328, 162);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 11;
            label3.Text = "Mật Khẩu: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(328, 199);
            label4.Name = "label4";
            label4.Size = new Size(115, 45);
            label4.TabIndex = 12;
            label4.Text = "Xác Nhận Mật Khẩu:\r\n\r\n\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(328, 237);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Email:";
            // 
            // button1
            // 
            button1.BackColor = Color.Azure;
            button1.Location = new Point(382, 281);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(223, 32);
            button1.TabIndex = 14;
            button1.Text = "Đăng Ký ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(668, 338);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_TenTK);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_Email);
            Controls.Add(txt_XacNhanMK);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DangKy";
            Text = "Form2";
            Load += DangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_XacNhanMK;
        private TextBox txt_Email;
        private TextBox txt_MatKhau;
        private TextBox txt_TenTK;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}