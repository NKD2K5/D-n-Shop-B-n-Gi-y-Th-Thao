using BUS_DuAn.Repository;
using DAL_DuAn1.DomainClass;
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
    }
}
