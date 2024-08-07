using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DuAn.DomainClass
{
	[Table("GioHang")]
	public partial class GioHang
	{
		public GioHang()
		{
			HoaDons = new HashSet<HoaDon>();
			SanPhams = new HashSet<SanPham>();
		}

		[Key]
		[Column("maGioHang")]
		[StringLength(20)]
		[Unicode(false)]
		public string MaGioHang { get; set; } = null!;

		[Column("soLuong")]
		public int? SoLuong { get; set; }

		[Column("gia", TypeName = "money")]
		public decimal? Gia { get; set; }

		[InverseProperty(nameof(HoaDon.MaGioHangNavigation))]
		public virtual ICollection<HoaDon> HoaDons { get; set; }

		[InverseProperty(nameof(SanPham.MaGioHangNavigation))]
		public virtual ICollection<SanPham> SanPhams { get; set; }
	}
}
