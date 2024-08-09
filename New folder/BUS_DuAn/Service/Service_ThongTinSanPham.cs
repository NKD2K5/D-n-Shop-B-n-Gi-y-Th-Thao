using BUS_DuAn.Repository;
using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Service
{
	public class Service_ThongTinSanPham
	{
		Repository_ThongTinSanPham ropes;
		public Service_ThongTinSanPham()
		{
			ropes = new Repository_ThongTinSanPham();
		}

		public List<SanPham> GetSanPhams()
		{
			return ropes.GetAll();
		}

		public string Themsp(SanPham sp)
		{
			try
			{
				if (ropes.Add(sp))
				{
					return "Thêm sản phẩm thành công!";
				}
				return "Thêm sản phẩm thất bại.";
			}
			catch (Exception ex)
			{
				return $"Đã xảy ra lỗi: {ex.Message}\nChi tiết: {ex.InnerException?.Message}";
			}
		}

		public string Xoasp(SanPham sp)
		{
			if (ropes.Remove(sp))
			{
				return "Xóa thành công";
			}
			return "Xóa thất bại";
		}

		// Phương thức cập nhật sản phẩm
		public string Suasp(SanPham sp)
		{
			try
			{
				using (var context = new MyContext())
				{
					// Tìm sản phẩm hiện tại trong cơ sở dữ liệu
					var existingSp = context.SanPhams.FirstOrDefault(x => x.MaSanPham == sp.MaSanPham);
					if (existingSp != null)
					{
						// Cập nhật các thuộc tính của sản phẩm
						existingSp.TenSanPham = sp.TenSanPham;
						existingSp.TonKho = sp.TonKho;
						existingSp.NgayNhap = sp.NgayNhap;
						existingSp.GiaNhap = sp.GiaNhap;
						existingSp.GiaBan = sp.GiaBan;

						// Lưu thay đổi vào cơ sở dữ liệu
						context.SaveChanges();
						return "Cập nhật sản phẩm thành công!";
					}
					else
					{
						return "Sản phẩm không tồn tại.";
					}
				}
			}
			catch (Exception ex)
			{
				return $"Đã xảy ra lỗi: {ex.Message}\nChi tiết: {ex.InnerException?.Message}";
			}
		}
	}
}
