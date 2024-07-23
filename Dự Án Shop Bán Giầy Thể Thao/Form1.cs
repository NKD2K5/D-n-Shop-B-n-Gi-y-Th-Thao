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
            comboBox1.Items.Add("Giầy Bóng Rổ");
            comboBox1.Items.Add("Giầy Bóng Đá");
            comboBox1.Items.Add("Giầy Chạy Bộ");
            comboBox1.Items.Add("Giầy Tennis");
            comboBox1.Items.Add("Giầy Địa Hình");
            comboBox1.Items.Add("Giầy Bóng Chuyền");
            // Thiết lập sự kiện SelectedIndexChanged
            //comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem.ToString();

            // Cập nhật ComboBox2 dựa trên mục được chọn
            if (comboBoxData.ContainsKey(selectedCategory))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(comboBoxData[selectedCategory].ToArray());
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

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
    }
}
