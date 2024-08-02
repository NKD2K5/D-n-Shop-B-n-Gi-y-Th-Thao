using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("ThongKe")]
    public partial class ThongKe
    {
        [Key]
        [Column("maThongKe")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaThongKe { get; set; } = null!;
        [Column("maHoaDon")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaHoaDon { get; set; }
        [Column("maThuNhap")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaThuNhap { get; set; }
        [Column("tonKho")]
        public int? TonKho { get; set; }
        [Column("ngayTaoThongKe", TypeName = "date")]
        public DateTime? NgayTaoThongKe { get; set; }
        [Column("nguoiTaoThongKe")]
        [StringLength(150)]
        public string? NguoiTaoThongKe { get; set; }

        [ForeignKey(nameof(MaHoaDon))]
        [InverseProperty(nameof(HoaDon.ThongKes))]
        public virtual HoaDon? MaHoaDonNavigation { get; set; }
        [ForeignKey(nameof(MaThuNhap))]
        [InverseProperty(nameof(ThuNhap.ThongKes))]
        public virtual ThuNhap? MaThuNhapNavigation { get; set; }
    }
}
