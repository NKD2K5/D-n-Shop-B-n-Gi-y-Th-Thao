using BUS_DuAn.Service;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.DataFormats;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
	public partial class TrangChu : Form
	{
		Service_SanPham svsp = new Service_SanPham();
		private Service_GioHang svgh = new Service_GioHang();
		private Dictionary<string, Dictionary<string, int>> comboBoxData;
		private Dictionary<string, int> phuKienData;
		private Dictionary<string, int> dichVuData;
		private decimal tongTien;
		private string idWhenClick;
		private ThongKe1 thongKeForm;
		private HoaDoncs hoaDoncs;
		public TrangChu()
		{
			InitializeComponent();
			InitializeComboBoxData();
			SetupComboBox1();
			LoadData();
			LoadDataSP();
	
			// Khởi tạo ThongKe1 và HoaDoncs
			thongKeForm = new ThongKe1();
			hoaDoncs = new HoaDoncs(thongKeForm);


			txt_TongTien.Text = tongTien.ToString();

			// Thêm sự kiện cho các ComboBox và NumericUpDown
			cbb_LoaiGiay.SelectedIndexChanged += cbb_LoaiGiay_SelectedIndexChanged;
			cbb_Hang.SelectedIndexChanged += cbb_Hang_SelectedIndexChanged;
			cbb_Giay.SelectedIndexChanged += cbb_Giay_SelectedIndexChanged;
			cbb_PhuKien.SelectedIndexChanged += cbb_PhuKien_SelectedIndexChanged;
			cbb_DichVu.SelectedIndexChanged += cbb_DichVu_SelectedIndexChanged;
			n_soluong.ValueChanged += n_soluong_ValueChanged;
		}

		private void InitializeComboBoxData()
		{
			// Khởi tạo dữ liệu cho ComboBox
			comboBoxData = new Dictionary<string, Dictionary<string, int>>()
			{
				{ "Giầy Bóng Rổ", new Dictionary<string, int> { { "Táo", 1000 }, { "Chuối", 500 }, { "Cam", 800 } } },
				{ "Giầy Bóng Đá", new Dictionary<string, int> { { "Cà rốt", 200 }, { "Bông cải", 300 }, { "Rau chân vịt", 150 } } },
				{ "Giầy Chạy Bộ", new Dictionary<string, int> { { "Mèo", 10 }, { "Chó", 15 }, { "Voi", 5 } } },
				{ "Giầy Tennis", new Dictionary<string, int> { { "Mèo", 10 }, { "Chó", 15 }, { "Voi", 5 } } },
				{ "Giầy Địa Hình", new Dictionary<string, int> { { "Mèo", 10 }, { "Chó", 15 }, { "Voi", 5 } } },
				{ "Giầy Bóng Chuyền", new Dictionary<string, int> { { "Mèo", 10 }, { "Chó", 15 }, { "Voi", 5 } } }
			};

			phuKienData = new Dictionary<string, int>()
			{
				{ "Dây giày", 50 },
				{ "Lót giày", 100 },
				{ "Tấm lót chống trượt", 150 },
				{ "Bảo vệ giày", 200 },
				{ "Bàn chải và dung dịch vệ sinh giày", 250 },
				{ "Miếng chống trầy", 75 },
				{ "Túi giặt giày", 125 },
				{ "Tất", 50 },
				{ "Thiết bị kéo giày", 150 },
				{ "Khung giữ form giày", 200 }
			};

			dichVuData = new Dictionary<string, int>()
			{
				{ "Combo Vệ Sinh Giầy", 300 },
				{ "Khâu Đế", 200 },
				{ "Bảo Dưỡng", 250 },
				{ "Xịt Phủ NaNô", 400 },
				{ "Sơn Giầy", 350 }
			};
		}
		private void SetupComboBox1()
		{
			// Thêm các mục vào ComboBox1
			cbb_LoaiGiay.Items.AddRange(new string[]
			{
				"Giầy Bóng Rổ",
				"Giầy Bóng Đá",
				"Giầy Chạy Bộ",
				"Giầy Tennis",
				"Giầy Địa Hình",
				"Giầy Bóng Chuyền"
			});

			// Thêm các mục vào ComboBox Hãng
			cbb_Hang.Items.AddRange(new string[] { "Nike", "Adisda", "Puma", "Vans", "Converse", "Under", "Armour", "New Balance", "ASICS", "Skechers" });

			// Thiết lập sự kiện SelectedIndexChanged
			cbb_LoaiGiay.SelectedIndexChanged += cbb_LoaiGiay_SelectedIndexChanged;
			cbb_Hang.SelectedIndexChanged += cbb_Hang_SelectedIndexChanged;
			cbb_PhuKien.Items.Clear();
			foreach (var item in phuKienData)
			{
				cbb_PhuKien.Items.Add(item.Key);
			}
			cbb_DichVu.Items.Clear();
			foreach (var item in dichVuData)
			{
				cbb_DichVu.Items.Add(item.Key);
			}
		}
		private void button16_Click(object sender, EventArgs e)
		{
			OpenChildForm(new ThongKe1());
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
		private void cbb_LoaiGiay_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateComboBoxGiay();
			TinhTongGiaTri();
		}

		private void cbb_Hang_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateComboBoxGiay();
			TinhTongGiaTri();
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
					foreach (var item in comboBoxData[selectedLoaiGiay])
					{
						// Thêm giày với hãng giày vào ComboBox
						cbb_Giay.Items.Add(item.Key);
					}
				}
			}
		}
		private void LoadData()
		{

			dtgView_GioHang.ColumnCount = 3;
			dtgView_GioHang.Columns[0].Name = "Tên Giỏ Hàng";
			dtgView_GioHang.Columns[1].Name = "Giá";
			dtgView_GioHang.Columns[2].Name = "Số Lượng Sản Phẩm";

			dtgView_GioHang.Rows.Clear();

			foreach (var gh in svgh.GetGioHangs())
			{
				dtgView_GioHang.Rows.Add(gh.MaGioHang, gh.Gia, gh.SoLuong);
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double totalPrice = 0;
				int totalQuantity = 0;

				// Xóa các dòng hiện tại trong giỏ hàng
				dtgView_GioHang.Rows.Clear();

				foreach (DataGridViewRow row in dtgView_SanPham.Rows)
				{
					if (row.Cells["Giá"].Value != null && row.Cells["Số Lượng"].Value != null)
					{
						double price;
						int quantity;

						if (double.TryParse(row.Cells["Giá"].Value.ToString(), out price) &&
							int.TryParse(row.Cells["Số Lượng"].Value.ToString(), out quantity))
						{
							totalPrice += price;
							totalQuantity += quantity;

							// Thêm dòng vào giỏ hàng
							dtgView_GioHang.Rows.Add(row.Cells["Tên Giầy"].Value, price, quantity);
						}
					}
				}

				// Thêm dòng tổng giá trị và số lượng vào giỏ hàng
				dtgView_GioHang.Rows.Add("Tổng", totalPrice, totalQuantity);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			}
		}
		private void LoadDataSP()
		{
			dtgView_SanPham.ColumnCount = 12;
			dtgView_SanPham.Columns[0].Name = "Mã Thông Tin Sản Phẩm";
			dtgView_SanPham.Columns[1].Name = "Mã Loại Sản Phẩm";
			dtgView_SanPham.Columns[2].Name = "Mã Hãng Giầy";
			dtgView_SanPham.Columns[3].Name = "Loại Giầy";
			dtgView_SanPham.Columns[4].Name = "Hãng";
			dtgView_SanPham.Columns[5].Name = "Tên Giầy";
			dtgView_SanPham.Columns[6].Name = "Màu";
			dtgView_SanPham.Columns[7].Name = "Size";
			dtgView_SanPham.Columns[8].Name = "Phụ Kiện";
			dtgView_SanPham.Columns[9].Name = "Dịch Vụ";
			dtgView_SanPham.Columns[10].Name = "Giá";
			dtgView_SanPham.Columns[11].Name = "Số Lượng";

			dtgView_SanPham.Rows.Clear();
			foreach (var sp in svsp.GetThongTinSanPhams())
			{
				dtgView_SanPham.Rows.Add(sp.MaThongTinSanPham, sp.MaLoaiSanPham, sp.MaHangGiay, sp.LoaiGiay, sp.HangGiay, sp.TenGiay, sp.MauGiay, sp.SoSize, sp.Phukien, sp.Dichvu, sp.GiaSanPham, sp.SoLuong);
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			try
			{

				ThongTinSanPham sp = new ThongTinSanPham
				{
					MaThongTinSanPham = txt_mathongtin.Text,
					MaLoaiSanPham = txt_Maloaigiay.Text,
					MaHangGiay = txt_Mahang.Text,
					LoaiGiay = cbb_LoaiGiay.Text,
					HangGiay = cbb_Hang.Text,
					TenGiay = cbb_Giay.Text,
					MauGiay = txt_Mau.Text,
					SoSize = cbb_Size.Text,
					Phukien = cbb_PhuKien.Text,
					Dichvu = cbb_DichVu.Text,
					GiaSanPham = Convert.ToInt32(txt_Gia.Text),
					SoLuong = Convert.ToInt32(n_soluong.Text)
				};

				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string resultMessage = svsp.Themsp(sp);
					LoadDataSP();
					MessageBox.Show(resultMessage);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}\nChi tiết: {ex.InnerException?.Message}");
			}
		}
		private void dtgView_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				DataGridViewRow selectedRow = dtgView_GioHang.Rows[e.RowIndex];

				// Lấy giá trị của cột "Mã Giỏ Hàng"
				if (selectedRow.Cells["Tên Giỏ Hàng"].Value != null)
				{
					string maGioHang = selectedRow.Cells["Tên Giỏ Hàng"].Value.ToString();
					txt_MaHoaDon.Text = maGioHang;
				}
				else
				{
					MessageBox.Show("Ô Mã Giỏ Hàng không hợp lệ hoặc trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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

			#region Code cũ của duy 
			//decimal tongTien = 0;

			//foreach (DataGridViewRow row in dtgView_GioHang.Rows) // thấy r b
			//{
			//    // Kiểm tra giá trị ô giá có hợp lệ không
			//    if (row.Cells["Giá"].Value != null && !string.IsNullOrWhiteSpace(row.Cells["Giá"].Value.ToString()))
			//    {
			//        string giaString = row.Cells["Giá"].Value.ToString();

			//        // Kiểm tra định dạng tiền tệ và chuyển đổi giá trị
			//        if (decimal.TryParse(giaString, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal gia))
			//        {
			//            tongTien += gia;
			//        }
			//        else
			//        {
			//            // Xử lý lỗi nếu giá trị không thể parse
			//            MessageBox.Show($"Giá trị không hợp lệ: {giaString}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//        }
			//        txt_TongTien.Text = tongTien.ToString("", CultureInfo.CurrentCulture);
			//    }
			//}

			//decimal soTienNhan;

			//if (decimal.TryParse(txt_SoTienNhan.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out soTienNhan))
			//{
			//    if (soTienNhan >= tongTien)
			//    {
			//        decimal tienThua = soTienNhan - tongTien;
			//        txt_TienThua.Text = tienThua.ToString("", CultureInfo.CurrentCulture);

			//        string maHoaDon = txt_MaHoaDon.Text;
			//        string tenNhanVien = txt_TenNhanVien.Text;
			//        string tenKhachHang = txt_TenKhachHang.Text;
			//        string ngayLap = DateTime.Now.ToString("dd/MM/yyyy");

			//        HoaDoncs hoaDonForm = new HoaDoncs();
			//        hoaDonForm.XuatHoaDon(maHoaDon, tenNhanVien, tenKhachHang, ngayLap, tongTien, soTienNhan, tienThua);

			//        hoaDonForm.Show(); //no dien thong tin o phan thanh toan vao hoa don 

			//        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//    }
			//    else
			//    {
			//        MessageBox.Show("Số tiền nhận không đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//    }
			//}
			//else
			//{
			//    MessageBox.Show("Vui lòng nhập số tiền nhận hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}

			#endregion


			if (decimal.TryParse(txt_TienThua.Text, out decimal tienThua) && decimal.TryParse(txt_SoTienNhan.Text, out decimal soTienNhan) && decimal.TryParse(txt_TongTien.Text, out decimal tongTien))
			{
				string maHoaDon = txt_MaHoaDon.Text;
				string tenNhanVien = txt_TenNhanVien.Text;
				string tenKhachHang = txt_TenKhachHang.Text;
				string ngayLap = DateTime.Now.ToString("dd/MM/yyyy");


				HoaDoncs hoaDonForm = new HoaDoncs(thongKeForm);
				hoaDonForm.XuatHoaDon(maHoaDon, tenNhanVien, tenKhachHang, ngayLap, tongTien, soTienNhan, tienThua);
				hoaDonForm.Show(); //no dien thong tin o phan thanh toan vao hoa don 

				MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("thất bại!");
			}


		}
		private void button13_Click(object sender, EventArgs e)
		{
			var gh = svgh.GetGioHangs().Find(x => x.MaGioHang == idWhenClick);
			MessageBox.Show(svgh.Xóa(gh));
			LoadData();
		}

		private void txt_SoTienNhan_TextChanged(object sender, EventArgs e)
		{
			if (!txt_SoTienNhan.Text.All(char.IsDigit))
			{
				MessageBox.Show("Không được nhập chữ!");
			}
			else
			{
				if (decimal.TryParse(txt_TongTien.Text, out decimal tongtien) && decimal.TryParse(txt_SoTienNhan.Text, out decimal tiennhan))
				{
					if (tiennhan - tongtien <= 0)
					{
						txt_TienThua.Text = "0";
					}
					else
					{
						txt_TienThua.Text = (tiennhan - tongtien).ToString();
					}
				}
			}
		}


		private void btn_DangXuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public void reset()
		{
			cbb_LoaiGiay.Text = "";
			cbb_Hang.Text = "";
			cbb_Giay.Text = "";
			cbb_Size.Text = "";
			cbb_PhuKien.Text = "";
			cbb_DichVu.Text = "";
			txt_Gia.Text = "";
			txt_Mau.Text = "";
			n_soluong.Value = 1;
		}
		private void button9_Click(object sender, EventArgs e)
		{
			reset();
			//MessageBox.Show(dtgView_GioHang.Rows.Count.ToString());

		}
		private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{

			}
			else
			{
				e.Cancel = true;
			}
		}

		private void btn_ThongKe_Click(object sender, EventArgs e)
		{
			OpenChildForm(new ThongKe1());
			lb_TieuDe.Text = btn_ThongKe.Text;
		}

		private void cbb_Giay_SelectedIndexChanged(object sender, EventArgs e)
		{
			TinhTongGiaTri();
		}

		private void cbb_DichVu_SelectedIndexChanged(object sender, EventArgs e)
		{
			TinhTongGiaTri();
		}

		private void n_soluong_ValueChanged(object sender, EventArgs e)
		{
			TinhTongGiaTri();
		}

		private void cbb_PhuKien_SelectedIndexChanged(object sender, EventArgs e)
		{
			TinhTongGiaTri();
		}
		private void TinhTongGiaTri()
		{
			int giaGiay = 0;
			int giaPhuKien = 0;
			int giaDichVu = 0;

			// Lấy giá trị của giày
			if (cbb_Giay.SelectedItem != null && comboBoxData.ContainsKey(cbb_LoaiGiay.SelectedItem.ToString()))
			{
				var selectedLoaiGiay = comboBoxData[cbb_LoaiGiay.SelectedItem.ToString()];
				if (selectedLoaiGiay.ContainsKey(cbb_Giay.SelectedItem.ToString()))
				{
					giaGiay = selectedLoaiGiay[cbb_Giay.SelectedItem.ToString()];
				}
			}

			// Lấy giá trị của phụ kiện
			if (cbb_PhuKien.SelectedItem != null && phuKienData.ContainsKey(cbb_PhuKien.SelectedItem.ToString()))
			{
				giaPhuKien = phuKienData[cbb_PhuKien.SelectedItem.ToString()];
			}

			// Lấy giá trị của dịch vụ
			if (cbb_DichVu.SelectedItem != null && dichVuData.ContainsKey(cbb_DichVu.SelectedItem.ToString()))
			{
				giaDichVu = dichVuData[cbb_DichVu.SelectedItem.ToString()];
			}

			// Tính tổng giá trị
			int soLuong = (int)n_soluong.Value;
			int tongGiaTri = (giaGiay + giaPhuKien + giaDichVu) * soLuong;

			// Hiển thị tổng giá trị lên TextBox
			txt_Gia.Text = tongGiaTri.ToString();
		}

		private void btn_SanPham_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Sản_Phẩm());
			lb_TieuDe.Text = btn_SanPham.Text;
		}

		private void btn_KhachHang_Click(object sender, EventArgs e)
		{
			OpenChildForm(new KhachHang());
			lb_TieuDe.Text = btn_KhachHang.Text;
		}

		private void btn_NhanVien_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Nhân_Viên());
			lb_TieuDe.Text = btn_NhanVien.Text;
		}

		private void btn_GiamGia_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Voucher());
			lb_TieuDe.Text = btn_GiamGia.Text;
		}

		private void btn_FeedBack_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FeedBack());
			lb_TieuDe.Text = btn_FeedBack.Text;
		}

		private void btn_BanHang_Click_1(object sender, EventArgs e)
		{
			if (currentFormChild != null)
			{
				currentFormChild.Close();
			}
			label1.Text = "Home";
		}

		private void label15_Click(object sender, EventArgs e)
		{

		}

		private void label16_Click(object sender, EventArgs e)
		{

		}

		private void dtgView_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void txt_TienThua_TextChanged(object sender, EventArgs e)
		{

		}

		private void button15_Click(object sender, EventArgs e)
		{

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
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void dtgView_SanPham_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
		}
	}
}
