using DAL_DuAn1.Context;
using DAL_DuAn1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
    internal class Repository_GiamGia
    {
        MyContext context;
        public Repository_GiamGia()
        {
            context = new MyContext();
        }
        public List<Voucher> GetAll()
        {
            return context.Vouchers.ToList();
        }
    }
}
