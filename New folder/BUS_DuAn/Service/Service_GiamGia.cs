using BUS_DuAn.Repository;
using DAL_DuAn.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Service
{
	public class Service_Voucher
	{
		Repository_Voucher ropes;
		public Service_Voucher()
		{
			ropes = new Repository_Voucher();
		}
		public List<Voucher> GetVouchers()
		{
			return ropes.GetAll();
		}
		public string Themvoucher(Voucher voucher)
		{
			if (ropes.Addvoucher(voucher))
			{
				return "Thêm Thành Công";
			}
			return "Thêm Thất Bại";
		}
		public string Xoávoucher(Voucher voucher)
		{
			if (ropes.Removevoucher(voucher))
			{
				return "Xoá Thành Công";
			}
			return "Xoá Thất Bại";
		}
		public string Sửavoucher(Voucher voucher)
		{
			if (ropes.Updatevoucher(voucher))
			{
				return "Sửa Thành Công";
			}
			return "Sửa Thất Bại";
		}
	}
}


