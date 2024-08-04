using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            ThongKes = new HashSet<ThongKe>();
        }

        [Key]
        [Column("maHoaDon")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaHoaDon { get; set; } = null!;
        [Column("maGioHang")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaGioHang { get; set; }
        [Column("thoiGian", TypeName = "datetime")]
        public DateTime? ThoiGian { get; set; }
        [Column("maKhachHang")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaKhachHang { get; set; }
        [Column("maVoucher")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaVoucher { get; set; }
        [Column("maHoaDonChiTiet")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaHoaDonChiTiet { get; set; }
        [Column("maNhanVien")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaNhanVien { get; set; }

        [ForeignKey(nameof(MaGioHang))]
        [InverseProperty(nameof(GioHang.HoaDons))]
        public virtual GioHang? MaGioHangNavigation { get; set; }
        [ForeignKey(nameof(MaHoaDonChiTiet))]
        [InverseProperty(nameof(HoaDonChiTiet.HoaDons))]
        public virtual HoaDonChiTiet? MaHoaDonChiTietNavigation { get; set; }
        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien? MaNhanVienNavigation { get; set; }
        [ForeignKey(nameof(MaVoucher))]
        [InverseProperty(nameof(Voucher.HoaDons))]
        public virtual Voucher? MaVoucherNavigation { get; set; }
        [InverseProperty(nameof(ThongKe.MaHoaDonNavigation))]
        public virtual ICollection<ThongKe> ThongKes { get; set; }
    }
}
