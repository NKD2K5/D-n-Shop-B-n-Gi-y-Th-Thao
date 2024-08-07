using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
	internal class Repository_HoaDon
	{
		MyContext context;
		public Repository_HoaDon()
		{
			context = new MyContext();
		}
		public List<HoaDon> GetAll()
		{
			return context.HoaDons.ToList();
		}
		public bool Add(HoaDon hd)
		{
			if (hd == null)
			{
				return false;
			}
			context.HoaDons.Add(hd);
			context.SaveChanges();
			return true;
		}
	}
}
