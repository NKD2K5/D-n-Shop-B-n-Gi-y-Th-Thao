using System;
using System.Data;
using System.Windows.Forms;
using BUS_DuAn.Service;
using DAL_DuAn.DomainClass;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
	public partial class ThongKe1 : Form
	{
		private Service_ThongKe svtk;
		private HoaDoncs hoaDonForm;

		public ThongKe1()
		{
			InitializeComponent();
			svtk = new Service_ThongKe();
			hoaDonForm = new HoaDoncs(this);
			LoadData();
			CustomizeDataGridView();
		}
		public void LoadData()
		{
			dtgView_ThongKe.ColumnCount = 5;
			dtgView_ThongKe.Columns[0].Name = "Mã Thông Kê";
			dtgView_ThongKe.Columns[1].Name = "Mã Hóa Đơn";
			dtgView_ThongKe.Columns[2].Name = "Người Tạo Thông Kê";
			dtgView_ThongKe.Columns[3].Name = "Thu Nhập";
			dtgView_ThongKe.Columns[4].Name = "Ngày Tạo Thông Kê";
			dtgView_ThongKe.Rows.Clear();
			foreach (var tk in svtk.GetThongKes())
			{
				dtgView_ThongKe.Rows.Add(tk.MaThongKe, tk.MaHoaDon, tk.NguoiTaoThongKe, tk.MaThuNhap, tk.NgayTaoThongKe);
			}
		}

		private void CustomizeDataGridView()
		{
			dtgView_ThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			dtgView_ThongKe.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dtgView_ThongKe.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dtgView_ThongKe.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dtgView_ThongKe.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dtgView_ThongKe.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			dtgView_ThongKe.Columns[0].HeaderText = "Mã Thống Kê";
			dtgView_ThongKe.Columns[1].HeaderText = "Mã Hóa Đơn";
			dtgView_ThongKe.Columns[2].HeaderText = "Người Thống Kê";
			dtgView_ThongKe.Columns[3].HeaderText = "Thu Nhập";
			dtgView_ThongKe.Columns[4].HeaderText = "Ngày Tạo Thống Kê";
		}
		private void btnThem_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			dtgView_ThongKe.Rows.Clear();

			// Xóa dữ liệu trong cơ sở dữ liệu (nếu cần)
			foreach (var tk in svtk.GetThongKes())
			{
				svtk.RemoveAll();
			}

			// Tải lại dữ liệu để cập nhật giao diện
			LoadData();
		}

		private void ThongKe1_Load(object sender, EventArgs e)
		{

		}
	}
}
