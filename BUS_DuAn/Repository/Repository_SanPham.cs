﻿using DAL_DuAn.Context;
using DAL_DuAn.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_DuAn.Repository
{
    internal class Repository_SanPham
    {
        MyContext context;
        public Repository_SanPham()
        {
            context = new MyContext();
        }
        public List<SanPham> GetAll()
        {
            return context.SanPhams.ToList();
        }
    }
}
