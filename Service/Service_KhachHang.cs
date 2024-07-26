using BUS_DuAn.Repository;
using DAL_DuAn1.DomainClass;
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
    }
}
