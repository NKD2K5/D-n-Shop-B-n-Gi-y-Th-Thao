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
			if (kh == null)
			{
				return false;
			}
			context.KhachHangs.Update(kh);
			return true;
		}
	}
}
