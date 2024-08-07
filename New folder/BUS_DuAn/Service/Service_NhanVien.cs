using BUS_DuAn.Repository;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Service
{
    public class Service_NhanVien
    {
        Repository_NhanVien ropes;
        public Service_NhanVien()
        {
            ropes = new Repository_NhanVien();
        }
        public List<NhanVien> GetNhanViens()
        {
            return ropes.GetAll();
        }
		public string Themnv(NhanVien nv)
		{
			if (ropes.Addkh(nv))
			{
				return "Thêm thành công";
			}
			return "Thêm Thất bại";
		}
		public string Xóanv(NhanVien nv)
		{
			if (ropes.Removekh(nv))
			{
				return "Xóa thành công";
			}
			return "Xóa Thất bại";
		}
		public string Sửanv(NhanVien nv)
		{
			if (ropes.Updatekh(nv))
			{
				return "Sửa thành công";
			}
			return "Sửa Thất bại";
		}
	}
}
