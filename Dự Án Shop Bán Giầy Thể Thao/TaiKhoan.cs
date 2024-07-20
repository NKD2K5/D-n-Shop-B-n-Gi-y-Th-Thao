using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
    class TaiKhoan
    {
        private string TenTaiKhoan;
        private string MatKhau;
        public TaiKhoan()
        {
        }

        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
        }

        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}
