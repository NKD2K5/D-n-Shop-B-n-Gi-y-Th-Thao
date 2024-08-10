using BUS_DuAn.Service;
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
	public partial class Voucher : Form
	{
		Service_Voucher svvch = new Service_Voucher();
		private string idWhenClick;
		public Voucher()
		{
			InitializeComponent();
			LoadData();
		}

		public void LoadData()
		{
			dtgView_Voucher.Rows.Clear();
			dtgView_Voucher.ColumnCount = 8;
			dtgView_Voucher.Columns[0].Name = "Mã Vch";
			dtgView_Voucher.Columns[1].Name = "Mã Loại Vch";
			dtgView_Voucher.Columns[2].Name = "Ngày Tạo";
			dtgView_Voucher.Columns[3].Name = "Ngày Hết Hạn";
			dtgView_Voucher.Columns[4].Name = "Trạng Thái";
			dtgView_Voucher.Columns[5].Name = "Thời Gian Dùng";
			dtgView_Voucher.Columns[6].Name = "Người Tạo";
			dtgView_Voucher.Columns[7].Name = "Tên Voucher";
			foreach (var voucher in svvch.GetVouchers())
			{
				dtgView_Voucher.Rows.Add(voucher.MaVoucher, voucher.MaLoaiVoucher, voucher.NgayTao, voucher.NgayHetHan, voucher.TrangThai, voucher.ThoiGianDung, voucher.NguoiTao, voucher.TenVoucher);
			}
		}
		public void FillData()
		{
			var voucher = svvch.GetVouchers().Where(x => x.MaVoucher == idWhenClick).FirstOrDefault();
			if (voucher != null)
			{
				txt_MaVoucher.Text = voucher.MaVoucher;
				cbb_LoaiVoucher.Text = voucher.MaLoaiVoucher;
				dateTime_NgayHetHan.Text = voucher.NgayHetHan.ToString();
				dateTime_NgayTao.Text = voucher.NgayTao.ToString();
				txt_HSD.Text = voucher.ThoiGianDung.ToString();
				txt_TrangThai.Text = voucher.TrangThai.ToString();
				txt_NguoiTao.Text = voucher.NguoiTao;
				cbb_TenVoucher.Text = voucher.TenVoucher;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime ngayHetHan, ngayTao, thoiGianDung;

				// Kiểm tra và chuyển đổi ngày hết hạn
				if (!DateTime.TryParse(dateTime_NgayHetHan.Text, out ngayHetHan))
				{
					MessageBox.Show("Định dạng ngày hết hạn không hợp lệ.");
					return;
				}

				// Kiểm tra và chuyển đổi ngày tạo
				if (!DateTime.TryParse(dateTime_NgayTao.Text, out ngayTao))
				{
					MessageBox.Show("Định dạng ngày tạo không hợp lệ.");
					return;
				}

				// Kiểm tra và chuyển đổi thời gian dùng
				if (!DateTime.TryParse(txt_HSD.Text, out thoiGianDung))
				{
					MessageBox.Show("Định dạng thời gian dùng không hợp lệ.");
					return;
				}

				DAL_DuAn.DomainClass.Voucher voucher = new DAL_DuAn.DomainClass.Voucher()
				{
					MaVoucher = txt_MaVoucher.Text,
					MaLoaiVoucher = cbb_LoaiVoucher.Text,
					NgayHetHan = DateTime.Parse(dateTime_NgayHetHan.Text),
					NgayTao = DateTime.Parse(dateTime_NgayTao.Text),
					TrangThai = bool.Parse(txt_TrangThai.Text),
					ThoiGianDung = DateTime.Parse(txt_HSD.Text),
					NguoiTao = txt_NguoiTao.Text,
					TenVoucher = cbb_TenVoucher.Text,
				};
				DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string resultMessage = svvch.Themvoucher(voucher);
					LoadData();
					MessageBox.Show(resultMessage);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			try
			{
				DAL_DuAn.DomainClass.Voucher voucher = new DAL_DuAn.DomainClass.Voucher()
				{
					MaVoucher = txt_MaVoucher.Text,
					MaLoaiVoucher = cbb_LoaiVoucher.Text,
					NgayHetHan = DateTime.Parse(dateTime_NgayHetHan.Text),
					NgayTao = DateTime.Parse(dateTime_NgayTao.Text),
					TrangThai = txt_TrangThai.Text.ToLower() == "true" ? true : false,
					ThoiGianDung = DateTime.Parse(txt_HSD.Text),
					NguoiTao = txt_NguoiTao.Text,
					TenVoucher = cbb_TenVoucher.Text,

				};

				var result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string resultMessage = svvch.Sửavoucher(voucher);
					LoadData();
					MessageBox.Show(resultMessage);
				}
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					MessageBox.Show("Đã xảy ra lỗi: " + ex.InnerException.Message);
				}
				else
				{
					MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
				}
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			var voucher = svvch.GetVouchers().Find(x => x.MaVoucher == idWhenClick);
			MessageBox.Show(svvch.Xoávoucher(voucher));
			LoadData();
		}

		private void dtgView_Voucher_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index < 0)
			{
				return;
			}
			idWhenClick = dtgView_Voucher.Rows[index].Cells[0].Value.ToString();
			datatime();
		}
		public void datatime()
		{
			var voucher = svvch.GetVouchers().Where(x => x.MaVoucher == idWhenClick).FirstOrDefault();
			if (voucher != null)
			{
				txt_MaVoucher.Text = voucher.MaVoucher;
				cbb_LoaiVoucher.Text = voucher.MaLoaiVoucher;
				dateTime_NgayHetHan.Text = voucher.NgayHetHan.ToString();
				dateTime_NgayTao.Text = voucher.NgayTao.ToString();
				txt_HSD.Text = voucher.ThoiGianDung.ToString();
				txt_TrangThai.Text = voucher.TrangThai.ToString();
				txt_NguoiTao.Text = voucher.NguoiTao;
				cbb_TenVoucher.Text = voucher.TenVoucher;
			}
		}
	}
}
