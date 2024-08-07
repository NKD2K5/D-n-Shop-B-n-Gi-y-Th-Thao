using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
    internal class Repository_NhanVien
    {
        MyContext context;
        public Repository_NhanVien()
        {
            context = new MyContext();
        }
        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }
		public bool Addkh(NhanVien nv)
		{
			if (nv == null)
			{
				return false;
			}
			context.NhanViens.Add(nv);
			context.SaveChanges();
			return true;
		}
		public bool Removekh(NhanVien nv)
		{
			if (nv == null)
			{
				return false;
			}
			context.NhanViens.Remove(nv);
			context.SaveChanges();
			return true;
		}
		public bool Updatekh(NhanVien nv)
		{
			try
			{
				if (nv == null)
				{
					return false;
				}

				var existingEntity = context.NhanViens.Find(nv.MaNhanVien);
				if (existingEntity != null)
				{
					context.Entry(existingEntity).CurrentValues.SetValues(nv);
				}
				else
				{
					context.NhanViens.Update(nv);
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
