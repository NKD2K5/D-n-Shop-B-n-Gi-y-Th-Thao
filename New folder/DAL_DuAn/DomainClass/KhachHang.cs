using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
	[Table("KhachHang")]
	public partial class KhachHang
	{
		public KhachHang()
		{
			HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
		}

		[Key]
		[Column("maKhachHang")]
		[StringLength(20)]
		[Unicode(false)]
		public string MaKhachHang { get; set; } = null!;

		[Column("tenKhachHang")]
		[StringLength(80)]
		public string? TenKhachHang { get; set; }

		[Column("diaChi")]
		[StringLength(150)]
		public string? DiaChi { get; set; }

		[Column("email")]
		[StringLength(50)]
		[Unicode(false)]
		public string? Email { get; set; }

		[Column("soDienThoai")]
		[StringLength(15)]
		[Unicode(false)]
		public string? SoDienThoai { get; set; }

		[Column("gioiTinh")]
		[StringLength(20)]
		public string? GioiTinh { get; set; }

		[Column("soLuong")]
		public int? SoLuong { get; set; }  

		[InverseProperty(nameof(HoaDonChiTiet.MaKhachHangNavigation))]
		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
	}
}
