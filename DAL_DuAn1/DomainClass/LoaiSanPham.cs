using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn1.DomainClass
{
    [Table("LoaiSanPham")]
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            ThongTinSanPhams = new HashSet<ThongTinSanPham>();
        }

        [Key]
        [Column("maLoaiSanPham")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaLoaiSanPham { get; set; } = null!;
        [Column("giayChayBo")]
        [StringLength(100)]
        public string? GiayChayBo { get; set; }
        [Column("giayTenis")]
        [StringLength(100)]
        public string? GiayTenis { get; set; }
        [Column("giayChayDiaHinh")]
        [StringLength(100)]
        public string? GiayChayDiaHinh { get; set; }
        [Column("giayBongRo")]
        [StringLength(100)]
        public string? GiayBongRo { get; set; }
        [Column("giayBongDa")]
        [StringLength(100)]
        public string? GiayBongDa { get; set; }
        [Column("giayBongChuyen")]
        [StringLength(100)]
        public string? GiayBongChuyen { get; set; }

        [InverseProperty(nameof(ThongTinSanPham.MaLoaiSanPhamNavigation))]
        public virtual ICollection<ThongTinSanPham> ThongTinSanPhams { get; set; }
    }
}
