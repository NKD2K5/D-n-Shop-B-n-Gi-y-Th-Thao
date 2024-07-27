using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn1.DomainClass
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
        [Column("soSize")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SoSize { get; set; }
        [Column("ngaySanXuat", TypeName = "date")]
        public DateTime? NgaySanXuat { get; set; }
        [Column("moTa")]
        [StringLength(150)]
        public string? MoTa { get; set; }
        [Column("mauGiay")]
        [StringLength(50)]
        public string? MauGiay { get; set; }
        [Column("giaSanPham", TypeName = "money")]
        public decimal? GiaSanPham { get; set; }

        [ForeignKey(nameof(MaHangGiay))]
        [InverseProperty(nameof(HangGiay.ThongTinSanPhams))]
        public virtual HangGiay? MaHangGiayNavigation { get; set; }
        [ForeignKey(nameof(MaLoaiSanPham))]
        [InverseProperty(nameof(LoaiSanPham.ThongTinSanPhams))]
        public virtual LoaiSanPham? MaLoaiSanPhamNavigation { get; set; }
        [ForeignKey(nameof(SoSize))]
        [InverseProperty(nameof(SizeGiay.ThongTinSanPhams))]
        public virtual SizeGiay? SoSizeNavigation { get; set; }
        [InverseProperty(nameof(SanPham.MaThongTinSanPhamNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
