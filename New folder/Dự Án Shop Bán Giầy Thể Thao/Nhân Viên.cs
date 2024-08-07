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
	public partial class Nhân_Viên : Form
	{
		Service_NhanVien svnv;
		private string idWhenClick;
		public Nhân_Viên()
		{
			InitializeComponent();
			svnv = new Service_NhanVien();
			LoadData();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		public void LoadData()
		{
			dtgView_NhanVien.ColumnCount = 8;
			dtgView_NhanVien.Columns[0].Name = "Mã NV";
			dtgView_NhanVien.Columns[1].Name = "Tên NV";
			dtgView_NhanVien.Columns[2].Name = "Vị Trí";
			dtgView_NhanVien.Columns[3].Name = "Địa Chỉ";
			dtgView_NhanVien.Columns[4].Name = "Email";
			dtgView_NhanVien.Columns[5].Name = "Số Điện Thoại";
			dtgView_NhanVien.Columns[6].Name = "Giới Tính";
			dtgView_NhanVien.Columns[7].Name = "Lương";
			dtgView_NhanVien.Rows.Clear();
			foreach (var nv in svnv.GetNhanViens())
			{
				dtgView_NhanVien.Rows.Add(nv.MaNhanVien, nv.TenNhanVien, nv.Vitri, nv.DiaChi, nv.Email, nv.SoDienThoai, nv.GioiTinh, nv.Luong);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				NhanVien nv = new NhanVien()
				{
					MaNhanVien = txt_MaNhanVien.Text,
					TenNhanVien = txt_TenNhanVien.Text,
					Vitri = txt_ViTri.Text,
					DiaChi = txt_DiaChi.Text,
					Email = txt_Email.Text,
					SoDienThoai = txt_SoDienThoai.Text,
					GioiTinh = rbtn_nam.Checked ? "Nam" : "Nữ",
					Luong = Convert.ToDecimal(txt_Luong.Text)
				};

				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string resultMessage = svnv.Themnv(nv);
					LoadData();
					MessageBox.Show(resultMessage);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			var nv = svnv.GetNhanViens().Find(x => x.MaNhanVien == idWhenClick);
			MessageBox.Show(svnv.Xóanv(nv));
			LoadData();
		}
		public void FillData()
		{
			var nv = svnv.GetNhanViens().Where(x => x.MaNhanVien == idWhenClick).FirstOrDefault();
			if (nv != null)
			{
				// Điền vào các trường textbox
				txt_MaNhanVien.Text = nv.MaNhanVien;
				txt_TenNhanVien.Text += nv.TenNhanVien;
				txt_ViTri.Text += nv.Vitri;
				txt_DiaChi.Text += nv.DiaChi;
				txt_Email.Text += nv.Email;
				txt_SoDienThoai.Text += nv.SoDienThoai;
				if (nv.GioiTinh == "Nam")
				{
					rbtn_nam.Checked = true;
				}
				else
				{
					rbtn_nu.Checked = true;
				}
				txt_Luong.Text += nv.Luong;
			}
		}

		private void dtgView_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index < 0)
			{
				return;
			}
			idWhenClick = dtgView_NhanVien.Rows[index].Cells[0].Value.ToString();
			FillData();
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			try
			{
				var nv = new NhanVien()
				{
					MaNhanVien = txt_MaNhanVien.Text,
					TenNhanVien = txt_TenNhanVien.Text,
					Vitri = txt_ViTri.Text,
					DiaChi = txt_DiaChi.Text,
					Email = txt_Email.Text,
					SoDienThoai = txt_SoDienThoai.Text,
					GioiTinh = rbtn_nam.Checked ? "Nam" : "Nữ",
					Luong = Convert.ToDecimal(txt_Luong.Text)
				};

				var result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string resultMessage = svnv.Sửanv(nv);
					LoadData();
					MessageBox.Show(resultMessage);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			}
		}
	}
}
