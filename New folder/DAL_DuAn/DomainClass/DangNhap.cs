using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
	[Table("DangNhap")]
	public partial class DangNhap
	{
		[Key]
		[Column("tenTaiKhoan_DangNhap")]
		[StringLength(50)]
		[Unicode(false)]
		public string TenTaiKhoanDangNhap { get; set; } = null!;

		[Column("matKhau")]
		[StringLength(50)]
		[Unicode(false)]
		public string? MatKhau { get; set; }

		[Column("quyenHan")]
		[StringLength(20)]
		[Unicode(false)]
		public string? QuyenHan { get; set; }
	}
}
