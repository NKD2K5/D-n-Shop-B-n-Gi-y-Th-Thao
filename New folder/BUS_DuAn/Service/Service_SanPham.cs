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
    public class Service_SanPham
    {
        Repository_SanPham ropes;
        public Service_SanPham()
        {
            ropes = new Repository_SanPham();
        }
        public List<ThongTinSanPham> GetThongTinSanPhams()
        {
            return ropes.GetAll();
        }
		public string Themsp(ThongTinSanPham sp)
		{
			try
			{
				using (var context = new MyContext())
				{
					context.ThongTinSanPhams.Add(sp);
					context.SaveChanges();
				}
				return "Thêm sản phẩm thành công!";
			}
			catch (Exception ex)
			{
				return $"Đã xảy ra lỗi: {ex.Message}\nChi tiết: {ex.InnerException?.Message}";
			}
		}
		public string Xóasp(ThongTinSanPham sp)
		{
			if (ropes.Remove(sp))
			{
				return "Xóa thành công";
			}
			return "Xóa Thất bại";
		}
	}
}
