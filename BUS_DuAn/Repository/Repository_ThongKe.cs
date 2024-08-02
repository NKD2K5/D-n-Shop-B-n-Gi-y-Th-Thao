using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
    internal class Repository_ThongKe
    {
        MyContext context;
        public Repository_ThongKe()
        {
            context = new MyContext();
        }
        public List<ThongKe> GetAll()
        {
            return context.ThongKes.ToList();
        }
    }
}
