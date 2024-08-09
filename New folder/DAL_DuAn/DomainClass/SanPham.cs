using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_DuAn.DomainClass
{
	[Table("SanPham")]
	public partial class SanPham
	{
		public SanPham()
		{
			HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
		}

		[Key]
		[Column("maSanPham")]
		[StringLength(20)]
		[Unicode(false)]
		public string MaSanPham { get; set; } = null!;

		[Column("maThongTinSanPham")]
		[StringLength(20)]
		[Unicode(false)]
		public string? MaThongTinSanPham { get; set; }

		[Column("maLoaiPhuKien")]
		[StringLength(20)]
		[Unicode(false)]
		public string? MaLoaiPhuKien { get; set; }

		[Column("maLoaiDichVu")]
		[StringLength(20)]
		[Unicode(false)]
		public string? MaLoaiDichVu { get; set; }

		[Column("maGioHang")]
		[StringLength(20)]
		[Unicode(false)]
		public string? MaGioHang { get; set; }

		[Column("tenSanPham")]
		[StringLength(50)]
		[Unicode(true)]
		public string? TenSanPham { get; set; }

		[Column("tonKho")]
		public int? TonKho { get; set; }

		[Column("giaNhap", TypeName = "money")]
		public decimal? GiaNhap { get; set; }

		[Column("giaBan", TypeName = "money")]
		public decimal? GiaBan { get; set; }

		[Column("ngayNhap", TypeName = "date")]
		public DateTime? NgayNhap { get; set; }

		[ForeignKey(nameof(MaGioHang))]
		[InverseProperty(nameof(GioHang.SanPhams))]
		public virtual GioHang? MaGioHangNavigation { get; set; }

		[ForeignKey(nameof(MaLoaiDichVu))]
		[InverseProperty(nameof(LoaiDichVu.SanPhams))]
		public virtual LoaiDichVu? MaLoaiDichVuNavigation { get; set; }

		[ForeignKey(nameof(MaLoaiPhuKien))]
		[InverseProperty(nameof(LoaiPhuKien.SanPhams))]
		public virtual LoaiPhuKien? MaLoaiPhuKienNavigation { get; set; }

		[ForeignKey(nameof(MaThongTinSanPham))]
		[InverseProperty(nameof(ThongTinSanPham.SanPhams))]
		public virtual ThongTinSanPham? MaThongTinSanPhamNavigation { get; set; }

		[InverseProperty(nameof(HoaDonChiTiet.MaSanPhamNavigation))]
		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
	}
}
