using BUS_DuAn.Service;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
	public partial class KhachHang : Form
	{
		Service_KhachHang svkh;
		private string idWhenClick;

		public KhachHang()
		{
			InitializeComponent();
			svkh = new Service_KhachHang();
			LoadData();
		}

		private void KhachHang_Load(object sender, EventArgs e)
		{
		}

		public void LoadData()
		{
			dtgView_KhachHang.ColumnCount = 7;
			dtgView_KhachHang.Columns[0].Name = "Mã NV";
			dtgView_KhachHang.Columns[1].Name = "Tên NV";
			dtgView_KhachHang.Columns[2].Name = "Địa Chỉ";
			dtgView_KhachHang.Columns[3].Name = "Email";
			dtgView_KhachHang.Columns[4].Name = "Số Điện Thoại";
			dtgView_KhachHang.Columns[5].Name = "Giới Tính";
			dtgView_KhachHang.Columns[6].Name = "Số Lượng Đặt Hàng";
			dtgView_KhachHang.Rows.Clear();
			foreach (var kh in svkh.GetKhachHangs())
			{
				dtgView_KhachHang.Rows.Add(kh.MaKhachHang, kh.TenKhachHang, kh.DiaChi, kh.Email, kh.SoDienThoai, kh.GioiTinh,kh.SoLuong);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DAL_DuAn.DomainClass.KhachHang kh = new DAL_DuAn.DomainClass.KhachHang
				{
					MaKhachHang = txt_MakhachHang.Text,
					TenKhachHang = txt_TenKhachHang.Text,
					DiaChi = txt_DiaChi.Text,
					Email = txt_Email.Text,
					SoDienThoai = txt_SoDientThoai.Text,
					GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
					SoLuong = Convert.ToInt32(txt_SoLuongDH.Text),
				};

				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string resultMessage = svkh.Themkh(kh);
					LoadData();
					MessageBox.Show(resultMessage);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			}
		}

		private void dtgView_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index < 0)
			{
				return;
			}
			// Nếu bấm đúng dòng có dữ liệu, thì phải lấy được ID của dòng đó
			idWhenClick = dtgView_KhachHang.Rows[index].Cells[0].Value.ToString();
			FillData();
		}

		public void FillData()
		{
			// Select * from nhanvien where manv = idewhenclick
			var kh = svkh.GetKhachHangs().Where(x => x.MaKhachHang == idWhenClick).FirstOrDefault();
			if (kh != null)
			{
				// Điền vào các trường textbox
				txt_MakhachHang.Text = kh.MaKhachHang;
				txt_TenKhachHang.Text = kh.TenKhachHang;
				txt_DiaChi.Text = kh.DiaChi;
				txt_Email.Text = kh.Email;
				txt_SoDientThoai.Text = kh.SoDienThoai;
				if (kh.GioiTinh == "Nam")
				{
					rbtn_Nam.Checked = true;
				}
				else
				{
					rbtn_Nu.Checked = true;
				}
				txt_SoLuongDH.Text = kh.SoLuong?.ToString() ?? string.Empty;
			}
		}

		private void txt_SoDientThoai_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			try
			{
				DAL_DuAn.DomainClass.KhachHang kh = new DAL_DuAn.DomainClass.KhachHang
				{
					MaKhachHang = txt_MakhachHang.Text,
					TenKhachHang = txt_TenKhachHang.Text,
					DiaChi = txt_DiaChi.Text,
					Email = txt_Email.Text,
					SoDienThoai = txt_SoDientThoai.Text,
					GioiTinh = rbtn_Nam.Checked ? "Nam" : "Nữ",
					SoLuong = Convert.ToInt32(txt_SoLuongDH.Text)
				};

				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string resultMessage = svkh.Sửakh(kh);
					LoadData();
					MessageBox.Show(resultMessage);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var kh = svkh.GetKhachHangs().Find(x => x.MaKhachHang == idWhenClick);
			MessageBox.Show(svkh.Xóakh(kh));
			LoadData();
		}
	}
}
