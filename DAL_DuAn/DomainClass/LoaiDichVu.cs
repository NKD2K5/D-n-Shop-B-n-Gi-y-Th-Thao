using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("LoaiDichVu")]
    public partial class LoaiDichVu
    {
        public LoaiDichVu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [Column("maLoaiDichVu")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaLoaiDichVu { get; set; } = null!;
        [Column("comboVeSinhGiay")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ComboVeSinhGiay { get; set; }
        [Column("khauDe")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KhauDe { get; set; }
        [Column("baoDuongGiay")]
        [StringLength(50)]
        [Unicode(false)]
        public string? BaoDuongGiay { get; set; }
        [Column("xitPhuNano")]
        [StringLength(50)]
        [Unicode(false)]
        public string? XitPhuNano { get; set; }
        [Column("sonGiay")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SonGiay { get; set; }

        [InverseProperty(nameof(SanPham.MaLoaiDichVuNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
