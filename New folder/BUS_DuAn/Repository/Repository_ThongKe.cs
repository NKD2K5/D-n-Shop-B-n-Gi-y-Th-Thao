using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
    internal class Repository_ThongKe
    {
        MyContext context;
        public Repository_ThongKe()
        {
            context = new MyContext();
        }
        public List<ThongKe> GetAll()
        {
            return context.ThongKes.ToList();
        }
		public bool Addtk(ThongKe tk)
		{
			if (tk == null)
			{
				return false;
			}
			context.ThongKes.Add(tk);
			context.SaveChanges();
			return true;
		}
		public bool RemoveAll()
		{
			try
			{
				foreach (var tk in context.ThongKes)
				{
					context.ThongKes.Remove(tk);
				}
				context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}
		public bool Updatetk(ThongKe tk)
		{
			try
			{
				if (tk == null)
				{
					return false;
				}

				var existingEntity = context.ThongKes.Find(tk.MaThongKe);
				if (existingEntity != null)
				{
					context.Entry(existingEntity).CurrentValues.SetValues(tk);
				}
				else
				{
					context.ThongKes.Update(tk);
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
