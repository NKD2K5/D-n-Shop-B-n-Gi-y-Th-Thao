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
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Excel Files (*.xlsx)|*.xlsx";
			saveFileDialog.DefaultExt = "txt";
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

				if (Path.GetExtension(filePath) == ".txt")
				{
					using (StreamWriter writer = new StreamWriter(filePath))
					{
						writer.WriteLine("Mã hóa đơn: " + maHoaDon);
						writer.WriteLine("Tên nhân viên: " + tenNhanVien);
						writer.WriteLine("Tên khách hàng: " + tenKhachHang);
						writer.WriteLine("Ngày lập: " + ngayLap);
						writer.WriteLine("Tổng tiền: " + tongTien);
						writer.WriteLine("Số tiền nhận: " + soTienNhan);
						writer.WriteLine("Tiền thừa: " + tienThua);
					}
				}
				else if (Path.GetExtension(filePath) == ".xlsx")
				{
					using (var workbook = new XLWorkbook())
					{
						var worksheet = workbook.Worksheets.Add("HoaDon");
						worksheet.Cell(1, 1).Value = "Mã hóa đơn";
						worksheet.Cell(1, 2).Value = maHoaDon;
						worksheet.Cell(2, 1).Value = "Tên nhân viên";
						worksheet.Cell(2, 2).Value = tenNhanVien;
						worksheet.Cell(3, 1).Value = "Tên khách hàng";
						worksheet.Cell(3, 2).Value = tenKhachHang;
						worksheet.Cell(4, 1).Value = "Ngày lập";
						worksheet.Cell(4, 2).Value = ngayLap;
						worksheet.Cell(5, 1).Value = "Tổng tiền";
						worksheet.Cell(5, 2).Value = tongTien;
						worksheet.Cell(6, 1).Value = "Số tiền nhận";
						worksheet.Cell(6, 2).Value = soTienNhan;
						worksheet.Cell(7, 1).Value = "Tiền thừa";
						worksheet.Cell(7, 2).Value = tienThua;
						workbook.SaveAs(filePath);
					}
				}

				MessageBox.Show("Mã hóa đơn đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Thêm mã hóa đơn vào DataGridView thống kê trong form ThongKe1
				ThongKe1 thongKeForm = new ThongKe1();
				thongKeForm.dtgView_ThongKe.Rows.Add(maHoaDon, tenNhanVien, tenKhachHang, ngayLap, tongTien);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				HoaDon hd = new HoaDon()
				{
					MaHoaDon = txt_MaHoaDon.Text,
					ThoiGian = DateTime.Parse(txt_NgayLap.Text),
					MaNhanVien = txt_TenNhanVien.Text,
				};

				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string resultMessage = svhd.Themhd(hd);


					MessageBox.Show(resultMessage);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
			}
		}
	}
}
