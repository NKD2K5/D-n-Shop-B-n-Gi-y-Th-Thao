using BUS_DuAn.Repository;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Service
{
    public class Service_ThongKe
    {
        Repository_ThongKe ropes;
        public Service_ThongKe()
        {
            ropes = new Repository_ThongKe();
        }
        public List<ThongKe> GetSanPhams()
        {
            return ropes.GetAll();
        }
    }
}
