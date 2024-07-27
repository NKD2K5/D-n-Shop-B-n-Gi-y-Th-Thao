using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn1.DomainClass
{
    [Table("LoaiVoucher")]
    public partial class LoaiVoucher
    {
        public LoaiVoucher()
        {
            Vouchers = new HashSet<Voucher>();
        }

        [Key]
        [Column("maLoaiVoucher")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaLoaiVoucher { get; set; } = null!;
        [Column("voucherGiamGiaPhanTram")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherGiamGiaPhanTram { get; set; }
        [Column("voucherGiamGiaSoTienCuThe")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherGiamGiaSoTienCuThe { get; set; }
        [Column("voucherMua1Tang1")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherMua1Tang1 { get; set; }
        [Column("voucherLanMuaDauTien")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherLanMuaDauTien { get; set; }
        [Column("voucherSinhNhat")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherSinhNhat { get; set; }
        [Column("voucherKHThanThiet")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherKhthanThiet { get; set; }
        [Column("voucherNhomSanPham")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherNhomSanPham { get; set; }
        [Column("voucherSuKien")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherSuKien { get; set; }
        [Column("voucherUngDungDiDong")]
        [StringLength(20)]
        [Unicode(false)]
        public string? VoucherUngDungDiDong { get; set; }

        [InverseProperty(nameof(Voucher.MaLoaiVoucherNavigation))]
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
