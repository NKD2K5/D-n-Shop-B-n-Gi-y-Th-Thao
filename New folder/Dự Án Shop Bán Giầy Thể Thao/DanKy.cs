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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txt_TenTK.Text;
            string password = txt_MatKhau.Text;
            string confirmPassword = txt_XacNhanMK.Text;
            string email = txt_Email.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Mất khẩu không hợp lệ.");
                return;
            }
            MessageBox.Show("Đăng ký thành công!");
            this.Close();
        }
    }
}
