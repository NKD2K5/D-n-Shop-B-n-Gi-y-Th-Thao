using BUS_DuAn.Service;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        Service_GioHang svgh;
        private Dictionary<string, List<string>> comboBoxData;
        private decimal tongTien;
        private string idWhenClick;
        public TrangChu()
        {
            InitializeComponent();
            InitializeComboBoxData();
            SetupComboBox1();
            svgh = new Service_GioHang();
            LoadData();
            this.dtgView_GioHang.CellClick += new DataGridViewCellEventHandler(this.dtgView_GioHang_CellClick);
            this.tongTien = tongTien; // ????
            txt_TongTien.Text = tongTien.ToString();
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



        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        //setting combobox
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
        private void LoadData()
        {
            dtgView_GioHang.ColumnCount = 10;
            dtgView_GioHang.Columns[0].Name = "Mã Giỏ Hàng";
            dtgView_GioHang.Columns[1].Name = "Loại Giầy";
            dtgView_GioHang.Columns[2].Name = "Hãng";
            dtgView_GioHang.Columns[3].Name = "Tên Giầy";
            dtgView_GioHang.Columns[4].Name = "Màu";
            dtgView_GioHang.Columns[5].Name = "Size";
            dtgView_GioHang.Columns[6].Name = "Phụ Kiện";
            dtgView_GioHang.Columns[7].Name = "Dịch Vụ";
            dtgView_GioHang.Columns[8].Name = "Giá";
            dtgView_GioHang.Columns[9].Name = "Số Lượng";
            dtgView_GioHang.Rows.Clear();

            foreach (var gh in svgh.GetGioHangs())
            {
                dtgView_GioHang.Rows.Add(gh.MaGioHang, gh.LoaiGiay, gh.Hang, gh.TenSanPham, gh.Mau, gh.Size, gh.PhuKien, gh.DichVu, gh.Gia, gh.SoLuong);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                GioHang gh = new GioHang
                {
                    MaGioHang = txt_MaHoaDon.Text,
                    LoaiGiay = cbb_LoaiGiay.Text,
                    Hang = cbb_Hang.Text,
                    TenSanPham = cbb_Giay.Text,
                    Mau = txt_Mau.Text,
                    Size = cbb_Size.Text,
                    PhuKien = cbb_PhuKien.Text,
                    DichVu = cbb_DichVu.Text,
                    Gia = Convert.ToInt32(txt_Gia.Text),
                    SoLuong = Convert.ToInt32(n_soluong.Text)
                };

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string resultMessage = svgh.Them(gh);
                    LoadData();
                    MessageBox.Show(resultMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private void dtgView_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgView_GioHang.Rows[e.RowIndex];
                if (selectedRow.Cells["Giá"].Value != null)
                {
                    string gia = selectedRow.Cells["Giá"].Value.ToString();
                    txt_TongTien.Text = gia;
                }
                else
                {
                    MessageBox.Show("Ô Giá trị không hợp lệ hoặc trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dtgView_GioHang.Rows)
            {
                // Kiểm tra giá trị ô giá có hợp lệ không
                if (row.Cells["Giá"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Giá"].Value.ToString()))
                {
                    string giaString = row.Cells["Giá"].Value.ToString();

                    // Kiểm tra định dạng tiền tệ và chuyển đổi giá trị
                    if (decimal.TryParse(giaString, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal gia))
                    {
                        tongTien += gia;
                    }
                    else
                    {
                        // Xử lý lỗi nếu giá trị không thể parse
                        MessageBox.Show($"Giá trị không hợp lệ: {giaString}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txt_TongTien.Text = tongTien.ToString("", CultureInfo.CurrentCulture);
                }
            }
                decimal soTienNhan;

                if (decimal.TryParse(txt_SoTienNhan.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out soTienNhan))
                {
                    if (soTienNhan >= tongTien)
                    {
                        decimal tienThua = soTienNhan - tongTien;
                        txt_TienThua.Text = tienThua.ToString("", CultureInfo.CurrentCulture);

                        string maHoaDon = txt_MaHoaDon.Text;
                        string tenNhanVien = txt_TenNhanVien.Text;
                        string tenKhachHang = txt_TenKhachHang.Text;
                        string ngayLap = DateTime.Now.ToString("dd/MM/yyyy");

                        HoaDoncs hoaDonForm = new HoaDoncs();
                        hoaDonForm.XuatHoaDon(maHoaDon, tenNhanVien, tenKhachHang, ngayLap, tongTien, soTienNhan, tienThua);

                        hoaDonForm.ShowDialog();

                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Số tiền nhận không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số tiền nhận hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new TrangChu());
            //lb_TieuDe.Text = btn_BanHang.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var gh = svgh.GetGioHangs().Find(x => x.MaGioHang == idWhenClick);
            MessageBox.Show(svgh.Xóa(gh));
            LoadData();
        }
    }
}
