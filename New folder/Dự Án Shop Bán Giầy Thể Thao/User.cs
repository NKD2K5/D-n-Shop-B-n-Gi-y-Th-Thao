using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_Án_Shop_Bán_Giầy_Thể_Thao
{
	public class User
	{
		private string usename;
		private string password;

		private string UserName { get => usename; set => usename = value; }
		private string PassWord { get => password; set => password = value; }
		private bool loaiTaiKhoan;
		public User(string usename, string password, bool loaiTaiKhoan)
		{
			this.usename = usename;
			this.password = password;
			this.loaiTaiKhoan = loaiTaiKhoan;
		}

	}
}
