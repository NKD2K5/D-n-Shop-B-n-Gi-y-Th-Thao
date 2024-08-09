using System;
using System.IO;
using System.Windows.Forms;
using BUS_DuAn.Service;
using ClosedXML.Excel;
using DAL_DuAn.DomainClass;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
	public partial class HoaDoncs : Form
	{
		Service_HoaDon svhd;
		public HoaDoncs(ThongKe1 thongKeForm)
		{
			InitializeComponent();
			InitializeDataGridView();
			svhd = new Service_HoaDon();
		}

		private void HoaDoncs_Load(object sender, EventArgs e)
		{

		}

		private void btnExportToExcel_Click(object sender, EventArgs e)
		{

		}

		private void InitializeDataGridView()
		{
			dtgView_HoaDon.ColumnCount = 2;
			dtgView_HoaDon.Columns[0].Name = "Thông tin";
			dtgView_HoaDon.Columns[1].Name = "Giá trị";
			dtgView_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}


		public void XuatHoaDon(string maHoaDon, string tenNhanVien, string tenKhachHang, string ngayLap, decimal tongTien, decimal soTienNhan, decimal tienThua)
		{
			txt_MaHoaDon.Text = maHoaDon;
			txt_TenNhanVien.Text = tenNhanVien;
			txt_TenKhachHang.Text = tenKhachHang;
			txt_NgayLap.Text = ngayLap;
			txt_TongTien.Text = tongTien.ToString();
			txt_TienKhachTra.Text = soTienNhan.ToString();
			txt_TienThua.Text = tienThua.ToString();

			dtgView_HoaDon.Rows.Clear();
			dtgView_HoaDon.Rows.Add("Mã hóa đơn", maHoaDon);
			dtgView_HoaDon.Rows.Add("Tên nhân viên", tenNhanVien);
			dtgView_HoaDon.Rows.Add("Tên khách hàng", tenKhachHang);
			dtgView_HoaDon.Rows.Add("Ngày lập", ngayLap);
			dtgView_HoaDon.Rows.Add("Tổng tiền", tongTien.ToString());
			dtgView_HoaDon.Rows.Add("Số tiền nhận", soTienNhan.ToString());
			dtgView_HoaDon.Rows.Add("Tiền thừa", tienThua.ToString());
		}

		private void btn_luu_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
			saveFileDialog.DefaultExt = "xlsx";
			saveFileDialog.AddExtension = true;
			saveFileDialog.FileName = "MaHoaDon";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;
				string maHoaDon = txt_MaHoaDon.Text;
				string tenNhanVien = txt_TenNhanVien.Text;
				string tenKhachHang = txt_TenKhachHang.Text;
				string ngayLap = txt_NgayLap.Text;
				string tongTien = txt_TongTien.Text;
				string soTienNhan = txt_TienKhachTra.Text;
				string tienThua = txt_TienThua.Text;

				bool fileExists = File.Exists(filePath);

				using (var workbook = fileExists ? new XLWorkbook(filePath) : new XLWorkbook())
				{
					var worksheet = workbook.Worksheets.FirstOrDefault() ?? workbook.Worksheets.Add("HoaDon");

					// Tạo các tiêu đề ở hàng đầu tiên nếu chưa có
					if (worksheet.Cell(1, 1).Value.ToString() == string.Empty)
					{
						worksheet.Cell(1, 1).Value = "Mã hóa đơn";
						worksheet.Cell(1, 2).Value = "Tên nhân viên";
						worksheet.Cell(1, 3).Value = "Tên khách hàng";
						worksheet.Cell(1, 4).Value = "Ngày lập";
						worksheet.Cell(1, 5).Value = "Tổng tiền";
						worksheet.Cell(1, 6).Value = "Số tiền nhận";
						worksheet.Cell(1, 7).Value = "Tiền thừa";
					}

					// Tìm hàng cuối cùng có dữ liệu
					int lastRow = worksheet.LastRowUsed()?.RowNumber() ?? 1;
					int newRow = lastRow + 1;

					// Ghi dữ liệu vào hàng mới
					worksheet.Cell(newRow, 1).Value = maHoaDon;
					worksheet.Cell(newRow, 2).Value = tenNhanVien;
					worksheet.Cell(newRow, 3).Value = tenKhachHang;
					worksheet.Cell(newRow, 4).Value = ngayLap;
					worksheet.Cell(newRow, 5).Value = tongTien;
					worksheet.Cell(newRow, 6).Value = soTienNhan;
					worksheet.Cell(newRow, 7).Value = tienThua;

					workbook.SaveAs(filePath);
				}


				MessageBox.Show("Mã hóa đơn đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Thêm mã hóa đơn vào DataGridView thống kê trong form ThongKe1
				ThongKe1 thongKeForm = new ThongKe1();
				thongKeForm.dtgView_ThongKe.Rows.Add(maHoaDon, tenNhanVien, tenKhachHang, ngayLap, tongTien);
			}
		}
	}
}
