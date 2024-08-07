using BUS_DuAn.Repository;
using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System.Collections.Generic;
using System.Linq;

namespace BUS_DuAn.Service
{
	public class Service_ThongKe
	{
		Repository_ThongKe ropes;
		public Service_ThongKe()
		{
			ropes = new Repository_ThongKe();
		}
		public List<ThongKe> GetThongKes()
		{
			return ropes.GetAll();
		}
		public string Themtk(ThongKe tk)
		{
			if (ropes.Addtk(tk))
			{
				return "Thêm thành công";
			}
			return "Thêm Thất bại";
		}
		public bool RemoveAll()
		{
			return ropes.RemoveAll();
		}
		public string Sửanv(ThongKe tk)
		{
			if (ropes.Updatetk(tk))
			{
				return "Sửa thành công";
			}
			return "Sửa Thất bại";
		}
	}
}
