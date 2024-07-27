using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn1.DomainClass
{
    [Table("LoaiPhuKien")]
    public partial class LoaiPhuKien
    {
        public LoaiPhuKien()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [Column("maLoaiPhuKien")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaLoaiPhuKien { get; set; } = null!;
        [Column("dayGiay")]
        [StringLength(50)]
        public string? DayGiay { get; set; }
        [Column("lotGiay")]
        [StringLength(50)]
        public string? LotGiay { get; set; }
        [StringLength(50)]
        public string? Tat { get; set; }
        [Column("tuiDungGiay")]
        [StringLength(50)]
        public string? TuiDungGiay { get; set; }
        [Column("khungGiuDangGiay")]
        [StringLength(50)]
        public string? KhungGiuDangGiay { get; set; }

        [InverseProperty(nameof(SanPham.MaLoaiPhuKienNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
