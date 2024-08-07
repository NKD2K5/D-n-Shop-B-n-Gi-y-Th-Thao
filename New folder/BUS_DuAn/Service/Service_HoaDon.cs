using BUS_DuAn.Repository;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Service
{
	public class Service_HoaDon
	{
		Repository_HoaDon ropes;
		public Service_HoaDon()
		{
			ropes = new Repository_HoaDon();
		}
		public List<HoaDon> GetSanPhams()
		{
			return ropes.GetAll();
		}

		public string Themhd(HoaDon hd)
		{
			if (ropes.Add(hd))
			{
				return "Thêm thành công";
			}
			return "Thêm Thất bại";
		}
	}
}
