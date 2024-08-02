using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("Voucher")]
    public partial class Voucher
    {
        public Voucher()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("maVoucher")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaVoucher { get; set; } = null!;
        [Column("ngayTao", TypeName = "datetime")]
        public DateTime? NgayTao { get; set; }
        [Column("ngayHetHan", TypeName = "datetime")]
        public DateTime? NgayHetHan { get; set; }
        [Column("trangThai")]
        public bool? TrangThai { get; set; }
        [Column("thoiGianDung", TypeName = "datetime")]
        public DateTime? ThoiGianDung { get; set; }
        [Column("nguoiTao")]
        [StringLength(50)]
        public string? NguoiTao { get; set; }
        [Column("maLoaiVoucher")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaLoaiVoucher { get; set; }

        [ForeignKey(nameof(MaLoaiVoucher))]
        [InverseProperty(nameof(LoaiVoucher.Vouchers))]
        public virtual LoaiVoucher? MaLoaiVoucherNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.MaVoucherNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
