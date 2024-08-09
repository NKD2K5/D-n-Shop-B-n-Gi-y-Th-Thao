using Dự_Án_Shop_Bán_Giầy_Thể_Thao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Shop_Ban_Giay_The_Thao
{
	public class ListUser
	{
		// Private static field
		private static ListUser instance;

		// Private field
		private List<User> list;

		// Public property to access the list
		public List<User> List
		{
			get => list;
			set => list = value;
		}

		// Public static property to access the singleton instance
		public static ListUser Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ListUser();
				}
				return instance;
			}
			set => instance = value;
		}

		// Private constructor to prevent external instantiation
		private ListUser()
		{
			list = new List<User>();
			list.Add(new User("admin", "12345", true));
			list.Add(new User("nhanvien1", "12345", false));
			list.Add(new User("nhanvien2", "12345", false));
		}
	}

	//Assuming a User class exists
	public class User
	{
		public string Username { get; set; }
		public string Password { get; set; }

		public bool loaiTaiKhoan { get; set; }
		public bool LoaiTaiKhoan
		{
			get { return loaiTaiKhoan; }
			set => loaiTaiKhoan = value;
		}

		public User(string username, string password, bool loaiTaiKhoan)
		{
			this.Username = username;
			this.Password = password;
			this.loaiTaiKhoan = loaiTaiKhoan;
		}
	}
}