using BUS_DuAn.Repository;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Service
{
    public class Service_GioHang
    {
        Repository_GioHang ropes;
        public Service_GioHang()
        {
            ropes = new Repository_GioHang();
        }
        public List<GioHang> GetGioHangs()
        {
            return ropes.GetAll();
        }
        public string Them(GioHang gh)
        {
            if (ropes.Add(gh))
            {
                return "Thêm thành công";
            }
            return "Thêm Thất bại";
        }
        public string Xóa(GioHang gh)
        {
            if (ropes.Remove(gh))
            {
                return "Xóa thành công";
            }
            return "Xóa Thất bại";
        }
    }
}
