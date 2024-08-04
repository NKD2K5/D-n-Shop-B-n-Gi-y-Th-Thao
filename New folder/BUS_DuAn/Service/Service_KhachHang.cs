using BUS_DuAn.Repository;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Service
{
    public class Service_KhachHang
    {
        Repository_KhachHang ropes;
        public Service_KhachHang()
        {
            ropes = new Repository_KhachHang();
        }
        public List<KhachHang> GetKhachHangs()
        {
            return ropes.GetAll();
        }
		public string Them(KhachHang kh)
		{
			if (ropes.Add(kh))
			{
				return "Thêm thành công";
			}
			return "Thêm Thất bại";
		}
		public string Xóa(KhachHang kh)
		{
			if (ropes.Remove(kh))
			{
				return "Xóa thành công";
			}
			return "Xóa Thất bại";
		}
		public string Sửa(KhachHang kh)
		{
			if (ropes.Update(kh))
			{
				return "Xóa thành công";
			}
			return "Xóa Thất bại";
		}
	}
}
