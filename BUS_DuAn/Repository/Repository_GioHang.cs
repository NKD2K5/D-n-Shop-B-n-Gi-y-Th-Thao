using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
    internal class Repository_GioHang
    {
        MyContext context; //
        public Repository_GioHang()
        {
            context = new MyContext();
        }
        public List<GioHang> GetAll()
        {
            return context.GioHangs.ToList();
        }
        public bool Add(GioHang gh)
        {
            if (gh == null)
            {
                return false;
            }
            context.GioHangs.Add(gh);
            context.SaveChanges();
            return true;
        }
        public bool Remove(GioHang gh)
        {
            if (gh == null)
            {
                return false;
            }
            context.GioHangs.Remove(gh);
            context.SaveChanges();
            return true;
        }
    }
}
