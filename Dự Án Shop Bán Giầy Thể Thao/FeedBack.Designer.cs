namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    partial class FeedBack
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(97, 79);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Khách Hàng";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(97, 129);
            label2.Name = "label2";
            label2.Size = new Size(153, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên Khách Hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(386, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(97, 187);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 4;
            label3.Text = "Ngày";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(264, 185);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(386, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(97, 244);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 6;
            label4.Text = "Tiêu Đề";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(743, 27);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(97, 289);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 8;
            label5.Text = "Nội Dung ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(97, 354);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(910, 182);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(480, 558);
            button1.Name = "button1";
            button1.Size = new Size(170, 40);
            button1.TabIndex = 10;
            button1.Text = "Gửi Đi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(455, 18);
            label6.Name = "label6";
            label6.Size = new Size(195, 34);
            label6.TabIndex = 11;
            label6.Text = "FEEDBACK!!";
            // 
            // FeedBack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1093, 610);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FeedBack";
            Text = "FeedBack";
            Load += FeedBack_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label6;
    }
}