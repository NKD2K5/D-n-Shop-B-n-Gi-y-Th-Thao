using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    public partial class TrangChu : Form
    {
        private Dictionary<string, List<string>> comboBoxData;
        public TrangChu()
        {
            InitializeComponent();
            InitializeComboBoxData();
            SetupComboBox1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComboBoxData()
        {
            // Khởi tạo dữ liệu cho ComboBox2
            comboBoxData = new Dictionary<string, List<string>>()
            {
                { "Giầy Bóng Rổ", new List<string> { "Táo", "Chuối", "Cam" } },
                { "Giầy Bóng Đá", new List<string> { "Cà rốt", "Bông cải", "Rau chân vịt" } },
                { "Giầy Chạy Bộ", new List<string> { "Mèo", "Chó", "Voi" } },
                { "Giầy Tennis", new List<string> { "Mèo", "Chó", "Voi" } },
                { "Giầy Địa Hình", new List<string> { "Mèo", "Chó", "Voi" } },
                { "Giầy Bóng Chuyền", new List<string> { "Mèo", "Chó", "Voi" } }
            };
        }
        private void SetupComboBox1()
        {
            // Thêm các mục vào ComboBox1
            cbb_LoaiGiay.Items.Add("Giầy Bóng Rổ");
            cbb_LoaiGiay.Items.Add("Giầy Bóng Đá");
            cbb_LoaiGiay.Items.Add("Giầy Chạy Bộ");
            cbb_LoaiGiay.Items.Add("Giầy Tennis");
            cbb_LoaiGiay.Items.Add("Giầy Địa Hình");
            cbb_LoaiGiay.Items.Add("Giầy Bóng Chuyền");

            // Thêm các mục vào ComboBox Hãng
            //List<string> hangGiay = new List<string> { "Nike", "Adidas", "Puma" };
            //foreach (string hang in hangGiay)
            //{
            //    cbb_Hang.Items.Add(hang);
            //}

            // Thiết lập sự kiện SelectedIndexChanged
            cbb_LoaiGiay.SelectedIndexChanged += cbb_LoaiGiay_SelectedIndexChanged;
            cbb_Hang.SelectedIndexChanged += cbb_Hang_SelectedIndexChanged;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedCategory = cbb_LoaiGiay.SelectedItem.ToString();

            //// Cập nhật ComboBox2 dựa trên mục được chọn
            //if (comboBoxData.ContainsKey(selectedCategory))
            //{
            //    cbb_Giay.Items.Clear();
            //    cbb_Giay.Items.AddRange(comboBoxData[selectedCategory].ToArray());
            //}
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe());
            lb_TieuDe.Text = btn_SanPham.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            HoaDoncs hoaDoncs = new HoaDoncs();
            hoaDoncs.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sản_Phẩm());
            lb_TieuDe.Text = btn_SanPham.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
            lb_TieuDe.Text = btn_KhachHang.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Nhân_Viên());
            lb_TieuDe.Text = btn_NhanVien.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Voucher());
            lb_TieuDe.Text = btn_GiamGia.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FeedBack());
            lb_TieuDe.Text = btn_FeedBack.Text;
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new TrangChu());
            //lb_TieuDe.Text = btn_BanHang.Text;
        }

        private void cbb_LoaiGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxGiay();
        }

        private void cbb_Hang_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboBoxGiay();
        }
        private void UpdateComboBoxGiay()
        {
            if (cbb_LoaiGiay.SelectedItem != null && cbb_Hang.SelectedItem != null)
            {
                string selectedLoaiGiay = cbb_LoaiGiay.SelectedItem.ToString();
                string selectedHang = cbb_Hang.SelectedItem.ToString();

                // Cập nhật ComboBox giày dựa trên loại giày và hãng giày đã chọn
                if (comboBoxData.ContainsKey(selectedLoaiGiay))
                {
                    cbb_Giay.Items.Clear();
                    // Giả sử bạn có dữ liệu kết hợp giữa loại giày và hãng giày
                    // Dưới đây là ví dụ đơn giản cập nhật dựa trên loại giày
                    foreach (string item in comboBoxData[selectedLoaiGiay])
                    {
                        // Thêm giày với hãng giày vào ComboBox
                        cbb_Giay.Items.Add($"{item} - {selectedHang}");
                    }
                }
            }
        }
    }
}
