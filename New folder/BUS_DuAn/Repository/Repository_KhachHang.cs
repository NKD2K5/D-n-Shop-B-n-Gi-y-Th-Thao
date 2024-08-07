using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
    internal class Repository_KhachHang
    {
        MyContext context;
        public Repository_KhachHang()
        {
            context = new MyContext();
        }
        public List<KhachHang> GetAll()
        {
            return context.KhachHangs.ToList();
        }
		public bool Addkh(KhachHang kh)
		{
			if (kh == null)
			{
				return false;
			}
			context.KhachHangs.Add(kh);
			context.SaveChanges();
			return true;
		}
		public bool Removekh(KhachHang kh)
		{
			if (kh == null)
			{
				return false;
			}
			context.KhachHangs.Remove(kh);
			context.SaveChanges();
			return true;
		}
		public bool Updatekh(KhachHang kh)
		{
			try
			{
				if (kh == null)
				{
					return false;
				}

				var existingEntity = context.KhachHangs.Find(kh.MaKhachHang);
				if (existingEntity != null)
				{
					context.Entry(existingEntity).CurrentValues.SetValues(kh);
				}
				else
				{
					context.KhachHangs.Update(kh);
				}

				context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				// Ghi log hoặc xử lý ngoại lệ tùy theo yêu cầu của bạn
				throw new Exception("Đã xảy ra lỗi khi cập nhật khách hàng.", ex);
			}
		}

	}
}
