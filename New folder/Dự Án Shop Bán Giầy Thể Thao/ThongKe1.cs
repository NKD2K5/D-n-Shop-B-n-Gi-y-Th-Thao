using BUS_DuAn.Service;
using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
	public partial class ThongKe1 : Form
	{
		private Service_ThongKe svtk;

		public ThongKe1()
		{
			InitializeComponent();
			svtk = new Service_ThongKe();
			LoadThongKeData();
			CustomizeDataGridView();
		}

		private void LoadThongKeData()
		{
			try
			{
				var data = svtk.GetAll();
				DataTable dt = new DataTable();
				dt.Columns.Add("Mã Thống Kê");
				dt.Columns.Add("Mã Hóa Đơn");
				dt.Columns.Add("Người Thống Kê");
				dt.Columns.Add("Số Lượng Bán");
				dt.Columns.Add("Thu Nhập");
				dt.Columns.Add("Ngày Tạo Thống Kê");

				foreach (var item in data)
				{
					dt.Rows.Add(item.MaThongKe, item.MaHoaDon, item.NguoiTaoThongKe, item.TonKho, item.MaThuNhap, item.NgayTaoThongKe);
				}

				dataGridViewThongKe.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
			}
		}

		private void CustomizeDataGridView()
		{
			dataGridViewThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dataGridViewThongKe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewThongKe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewThongKe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewThongKe.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewThongKe.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dataGridViewThongKe.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			dataGridViewThongKe.Columns[0].HeaderText = "Mã Thống Kê";
			dataGridViewThongKe.Columns[1].HeaderText = "Mã Hóa Đơn";
			dataGridViewThongKe.Columns[2].HeaderText = "Người Thống Kê";
			dataGridViewThongKe.Columns[3].HeaderText = "Số Lượng Bán";
			dataGridViewThongKe.Columns[4].HeaderText = "Thu Nhập";
			dataGridViewThongKe.Columns[5].HeaderText = "Ngày Tạo Thống Kê";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaThongKe.Text) ||
				string.IsNullOrWhiteSpace(txtMaHoaDon.Text) ||
				string.IsNullOrWhiteSpace(txtNguoiThongKe.Text) ||
				string.IsNullOrWhiteSpace(txtSoLuongBan.Text) ||
				string.IsNullOrWhiteSpace(txtThuNhap.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
				return;
			}

			try
			{
				using (var context = new MyContext())
				{
					var hoaDon = context.HoaDons.Find(txtMaHoaDon.Text);
					if (hoaDon == null)
					{
						MessageBox.Show("Mã Hóa Đơn không tồn tại.");
						return;
					}

					var thuNhap = context.ThuNhaps.Find(txtThuNhap.Text);
					if (thuNhap == null)
					{
						MessageBox.Show("Mã Thu Nhập không tồn tại.");
						return;
					}
				}

				ThongKe newRecord = new ThongKe
				{
					MaThongKe = txtMaThongKe.Text,
					MaHoaDon = txtMaHoaDon.Text,
					NguoiTaoThongKe = txtNguoiThongKe.Text,
					TonKho = int.Parse(txtSoLuongBan.Text),
					MaThuNhap = txtThuNhap.Text,
					NgayTaoThongKe = dtpNgay.Value
				};

				bool result = svtk.Add_Obj(newRecord);
				if (result)
				{
					MessageBox.Show("Thêm bản ghi thành công.");
					LoadThongKeData();
				}
				else
				{
					MessageBox.Show("Thêm bản ghi thất bại. Mã Thống Kê đã tồn tại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}\nChi tiết: {ex.InnerException?.Message}");
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaThongKe.Text) ||
				string.IsNullOrWhiteSpace(txtMaHoaDon.Text) ||
				string.IsNullOrWhiteSpace(txtNguoiThongKe.Text) ||
				string.IsNullOrWhiteSpace(txtSoLuongBan.Text) ||
				string.IsNullOrWhiteSpace(txtThuNhap.Text))
			{
				MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
				return;
			}

			try
			{
				ThongKe updatedRecord = new ThongKe
				{
					MaThongKe = txtMaThongKe.Text,
					MaHoaDon = txtMaHoaDon.Text,
					NguoiTaoThongKe = txtNguoiThongKe.Text,
					TonKho = int.Parse(txtSoLuongBan.Text),
					MaThuNhap = txtThuNhap.Text,
					NgayTaoThongKe = dtpNgay.Value
				};

				bool result = svtk.Update_Obj(updatedRecord);
				if (result)
				{
					MessageBox.Show("Sửa bản ghi thành công.");
					LoadThongKeData();
				}
				else
				{
					MessageBox.Show("Sửa bản ghi thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtMaThongKe.Text))
			{
				MessageBox.Show("Vui lòng điền mã thống kê.");
				return;
			}

			try
			{
				ThongKe recordToDelete = new ThongKe
				{
					MaThongKe = txtMaThongKe.Text
				};

				bool result = svtk.Remove_Obj(recordToDelete);
				if (result)
				{
					MessageBox.Show("Xóa bản ghi thành công.");
					LoadThongKeData();
				}
				else
				{
					MessageBox.Show("Xóa bản ghi thất bại. Mã Thống Kê không tồn tại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}");
			}
		}

		private void ThongKe1_Load(object sender, EventArgs e)
		{
			LoadThongKeData();
		}
	}
}
