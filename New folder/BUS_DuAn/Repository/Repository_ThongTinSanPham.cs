using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
	internal class Repository_ThongTinSanPham
	{
		MyContext context;
		public Repository_ThongTinSanPham()
		{
			context = new MyContext();
		}
		public List<SanPham> GetAll()
		{
			return context.SanPhams.ToList();
		}
		public bool Add(SanPham sp)
		{
			if (sp == null)
			{
				return false;
			}
			context.SanPhams.Add(sp);
			context.SaveChanges();
			return true;
		}
		public bool Remove(SanPham sp)
		{
			if (sp == null)
			{
				return false;
			}
			context.SanPhams.Remove(sp);
			context.SaveChanges();
			return true;
		}
	}
}
