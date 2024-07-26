using DAL_DuAn1.Context;
using DAL_DuAn1.DomainClass;
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
    }
}
