using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
    internal class Repository_GioHang
    {
        MyContext context = new MyContext();
        public Repository_GioHang()
        {

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
