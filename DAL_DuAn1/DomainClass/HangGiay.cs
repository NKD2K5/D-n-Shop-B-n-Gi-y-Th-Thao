using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn1.DomainClass
{
    [Table("HangGiay")]
    public partial class HangGiay
    {
        public HangGiay()
        {
            ThongTinSanPhams = new HashSet<ThongTinSanPham>();
        }

        [Key]
        [Column("maHangGiay")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaHangGiay { get; set; } = null!;
        [Column("tenHangGiay")]
        [StringLength(100)]
        public string? TenHangGiay { get; set; }

        [InverseProperty(nameof(ThongTinSanPham.MaHangGiayNavigation))]
        public virtual ICollection<ThongTinSanPham> ThongTinSanPhams { get; set; }
    }
}
