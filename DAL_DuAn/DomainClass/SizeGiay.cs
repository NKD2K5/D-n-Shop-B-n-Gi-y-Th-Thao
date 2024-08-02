using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("SizeGiay")]
    public partial class SizeGiay
    {
        public SizeGiay()
        {
            ThongTinSanPhams = new HashSet<ThongTinSanPham>();
        }

        [Key]
        [Column("soSize")]
        [StringLength(5)]
        [Unicode(false)]
        public string SoSize { get; set; } = null!;

        [InverseProperty(nameof(ThongTinSanPham.SoSizeNavigation))]
        public virtual ICollection<ThongTinSanPham> ThongTinSanPhams { get; set; }
    }
}
