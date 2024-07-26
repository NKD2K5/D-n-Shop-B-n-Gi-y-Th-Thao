using BUS_DuAn.Repository;
using DAL_DuAn1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Service
{
    public class Service_SanPham
    {
        Repository_SanPham ropes;
        public Service_SanPham()
        {
            ropes = new Repository_SanPham();
        }
        public List<SanPham> GetSanPhams()
        {
            return ropes.GetAll();
        }
    }
}
