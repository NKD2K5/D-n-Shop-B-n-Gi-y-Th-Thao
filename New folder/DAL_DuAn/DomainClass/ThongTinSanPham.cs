using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
	[Table("ThongTinSanPham")]
	public partial class ThongTinSanPham
	{
		public ThongTinSanPham()
		{
			SanPhams = new HashSet<SanPham>();
		}

		[Key]
		[Column("maThongTinSanPham")]
		[StringLength(20)]
		[Unicode(false)]
		public string MaThongTinSanPham { get; set; } = null!;

		[Column("maLoaiSanPham")]
		[StringLength(20)]
		[Unicode(false)]
		public string? MaLoaiSanPham { get; set; }

		[Column("maHangGiay")]
		[StringLength(20)]
		[Unicode(false)]
		public string? MaHangGiay { get; set; }

		[Column("loaiGiay")]
		[StringLength(50)]
		public string? LoaiGiay { get; set; }

		[Column("hangGiay")]
		[StringLength(50)]
		public string? HangGiay { get; set; }

		[Column("tenGiay")]
		[StringLength(100)]
		public string? TenGiay { get; set; }

		[Column("soSize")]
		[StringLength(5)]
		[Unicode(false)]
		public string? SoSize { get; set; }

		//[Column("ngaySanXuat", TypeName = "date")]
		//public DateTime? NgaySanXuat { get; set; }

		//[Column("moTa")]
		//[StringLength(150)]
		//public string? MoTa { get; set; }

		[Column("mauGiay")]
		[StringLength(50)]
		public string? MauGiay { get; set; }

		[Column("dichvu")]
		[StringLength(50)]
		public string? Dichvu { get; set; }

		[Column("phukien")]
		[StringLength(50)]
		public string? Phukien { get; set; }

		[Column("giaSanPham", TypeName = "money")]
		public decimal? GiaSanPham { get; set; }

		[Column("soLuong")]
		public int? SoLuong { get; set; }

		[ForeignKey("MaHangGiay")]
		[InverseProperty("ThongTinSanPhams")]
		public virtual HangGiay? MaHangGiayNavigation { get; set; }

		[ForeignKey("MaLoaiSanPham")]
		[InverseProperty("ThongTinSanPhams")]
		public virtual LoaiSanPham? MaLoaiSanPhamNavigation { get; set; }

		[ForeignKey("SoSize")]
		[InverseProperty("ThongTinSanPhams")]
		public virtual SizeGiay? SoSizeNavigation { get; set; }

		[InverseProperty("MaThongTinSanPhamNavigation")]
		public virtual ICollection<SanPham> SanPhams { get; set; }
	}
}