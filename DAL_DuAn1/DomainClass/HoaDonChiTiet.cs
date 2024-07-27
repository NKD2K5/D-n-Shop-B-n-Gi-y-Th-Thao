using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn1.DomainClass
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        public HoaDonChiTiet()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("maHoaDonChiTiet")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaHoaDonChiTiet { get; set; } = null!;
        [Column("maSanPham")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaSanPham { get; set; }
        [Column("maKhachHang")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaKhachHang { get; set; }
        [Column("soLuong")]
        public int? SoLuong { get; set; }
        [Column("donGia", TypeName = "money")]
        public decimal? DonGia { get; set; }
        [Column("maNhanVien")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaNhanVien { get; set; }

        [ForeignKey(nameof(MaKhachHang))]
        [InverseProperty(nameof(KhachHang.HoaDonChiTiets))]
        public virtual KhachHang? MaKhachHangNavigation { get; set; }
        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDonChiTiets))]
        public virtual NhanVien? MaNhanVienNavigation { get; set; }
        [ForeignKey(nameof(MaSanPham))]
        [InverseProperty(nameof(SanPham.HoaDonChiTiets))]
        public virtual SanPham? MaSanPhamNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.MaHoaDonChiTietNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
