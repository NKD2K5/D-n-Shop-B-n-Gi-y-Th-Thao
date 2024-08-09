using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
	internal class Repository_Voucher
	{
		MyContext context;
		public Repository_Voucher()
		{
			context = new MyContext();
		}
		public List<Voucher> GetAll()
		{
			return context.Vouchers.ToList();
		}
		public bool Addvoucher(Voucher voucher)
		{
			if (voucher == null)
			{
				return false;
			}
			context.Vouchers.Add(voucher);
			context.SaveChanges();
			return true;
		}
		public bool Removevoucher(Voucher voucher)
		{
			if (voucher == null)
			{
				return false;
			}
			context.Vouchers.Remove(voucher);
			context.SaveChanges();
			return true;
		}
		public bool Updatevoucher(Voucher voucher)
		{
			try
			{
				if (voucher == null)
				{
					return false;
				}
				var existingEntity = context.Vouchers.Find(voucher.MaVoucher);
				if (existingEntity != null)
				{
					context.Entry(existingEntity).CurrentValues.SetValues(voucher);
				}
				else
				{
					context.Vouchers.Update(voucher);
				}
				context.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				throw new Exception("Đã Xảy ra lỗi khi cập nhật voucher", ex);
			}
		}
	}
}
