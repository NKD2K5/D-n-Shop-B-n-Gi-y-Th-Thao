using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System.Collections.Generic;
using System.Linq;

namespace BUS_DuAn.Service
{
	public class Service_ThongKe
	{
		private MyContext context;

		public Service_ThongKe()
		{
			context = new MyContext();
		}

		public List<ThongKe> GetAll()
		{
			return context.ThongKes.ToList();
		}

		public bool Add_Obj(ThongKe tk)
		{
			if (tk == null)
			{
				return false;
			}
			var existingEntity = context.ThongKes.Find(tk.MaThongKe);
			if (existingEntity != null)
			{
				return false; // Khóa chính đã tồn tại
			}
			context.ThongKes.Add(tk);
			context.SaveChanges();
			return true;
		}

		public bool Update_Obj(ThongKe tk)
		{
			if (tk == null)
			{
				return false;
			}

			var existingEntity = context.ThongKes.Find(tk.MaThongKe);
			if (existingEntity != null)
			{
				context.Entry(existingEntity).CurrentValues.SetValues(tk);
				context.SaveChanges();
				return true;
			}
			return false;
		}

		public bool Remove_Obj(ThongKe tk)
		{
			if (tk == null)
			{
				return false;
			}

			var existingEntity = context.ThongKes.Find(tk.MaThongKe);
			if (existingEntity != null)
			{
				context.ThongKes.Remove(existingEntity);
				context.SaveChanges();
				return true;
			}
			return false;
		}
	}
}
