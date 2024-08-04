namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.Show();
            this.Hide();

        }

        private void QuanMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quanMatKhau = new QuenMatKhau();
            quanMatKhau.Show();
            this.Hide();
;        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TenTk.Text;
            string password = txt_MatKhau.Text;

            // Logic kiểm tra tài khoản đăng nhập ở đây
            // Giả sử bạn có một phương thức CheckLogin để kiểm tra thông tin đăng nhập
            bool loginSuccess = CheckLogin(username, password);

            if (loginSuccess)
            {
                // Mở form chính của ứng dụng hoặc thực hiện hành động sau khi đăng nhập thành công
                TrangChu trangChu = new TrangChu();
                trangChu.Show();

                trangChu.FormClosed += (a, b) => this.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.");
            }
        }




        private bool CheckLogin(string username, string password)
        {
            // Thay thế bằng logic kiểm tra thực sự của bạn, ví dụ: kiểm tra từ cơ sở dữ liệu
            if (username == "" && password == "")
            {
                return true;
            }
            return false;
        }
    }
}
