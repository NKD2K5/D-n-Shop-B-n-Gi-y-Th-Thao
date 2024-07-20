using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailDangKy = txt_EmailDangKy.Text;
            string matKhau = txt_MatKhau.Text;

            if (string.IsNullOrEmpty(emailDangKy))
            {
                MessageBox.Show("Vui lòng nhập Email đăng ký.");
                return;
            }

            // Kiểm tra email đăng ký có tồn tại trong cơ sở dữ liệu không
            // Đây là ví dụ, bạn cần thay thế bằng mã kết nối cơ sở dữ liệu thực tế
            //if (IsEmailExist(emailDangKy))
            //{
            //    // Gửi email với mật khẩu
            //    SendPasswordEmail(emailDangKy, matKhau);
            //    MessageBox.Show("Mật khẩu đã được gửi tới email của bạn.");
            //}
            //else
            //{
            //    MessageBox.Show("Email đăng ký không tồn tại.");
            //}
        }
    }
}
