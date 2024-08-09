using BUS_DuAn.Service;
using DAL_DuAn.DomainClass;
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
	public partial class Sản_Phẩm : Form
	{
		Service_ThongTinSanPham svsp = new Service_ThongTinSanPham();
		private string idWhenClick;
		public Sản_Phẩm()
		{
			InitializeComponent();
			svsp = new Service_ThongTinSanPham();
			InitializeDataGridView();
			LoadDataSP();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void InitializeDataGridView()
		{
			dgvSanPham.ColumnCount = 6;
			dgvSanPham.Columns[0].Name = "Mã Sản Phẩm";
			dgvSanPham.Columns[1].Name = "Tên Sản Phẩm";
			dgvSanPham.Columns[2].Name = "Tôn Kho";
			dgvSanPham.Columns[3].Name = "Ngày Nhập";
			dgvSanPham.Columns[4].Name = "Gái Nhập";
			dgvSanPham.Columns[5].Name = "Giá Bán";
		}
		private void LoadDataSP()
		{
			dgvSanPham.Rows.Clear();
			var sanPhams = svsp.GetSanPhams();

			foreach (var sp in sanPhams)
			{
				dgvSanPham.Rows.Add(
					sp.MaSanPham,
					sp.TenSanPham,
					sp.TonKho,
					sp.NgayNhap,
					sp.GiaNhap,
					sp.GiaBan

				);
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			try
			{

				SanPham sp = new SanPham
				{
					MaSanPham = cbb_MaLoaiSanPham.Text,
					TenSanPham = txt_TenSanPham.Text,
					TonKho = Convert.ToInt32(txt_TonKho.Text),
					NgayNhap = DateTime.Parse(dateTime_NgayNhap.Text),
					GiaBan = Convert.ToInt32(txt_GiaBan.Text),
					GiaNhap = Convert.ToInt32(txt_GiaNhap.Text)
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

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				// Tạo đối tượng sản phẩm với các giá trị từ các ô nhập liệu
				var sp = new SanPham()
				{
					MaSanPham = cbb_MaLoaiSanPham.Text,
					TenSanPham = txt_TenSanPham.Text,
					TonKho = Convert.ToInt32(txt_TonKho.Text),
					NgayNhap = dateTime_NgayNhap.Value, // Sử dụng Value thay vì Text để lấy giá trị DateTime
					GiaNhap = Convert.ToDecimal(txt_GiaNhap.Text),
					GiaBan = Convert.ToDecimal(txt_GiaBan.Text)
				};

				// Xác nhận người dùng có muốn sửa hay không
				var result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					// Gọi phương thức sửa trong Service
					string resultMessage = svsp.Suasp(sp);
					MessageBox.Show(resultMessage); // Hiển thị kết quả sửa

					// Tải lại dữ liệu lên DataGridView sau khi sửa thành công
					if (resultMessage.Contains("thành công"))
					{
						LoadDataSP();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message); // Hiển thị lỗi nếu có
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var sp = svsp.GetSanPhams().Find(x => x.MaSanPham == idWhenClick);

			if (sp != null)
			{
				string result = svsp.Xoasp(sp).ToString(); // Convert the result to string
				MessageBox.Show(result);
				LoadDataSP();
			}
			else
			{
				MessageBox.Show("Sản phẩm không tìm thấy.");
			}
		}
	}
}
