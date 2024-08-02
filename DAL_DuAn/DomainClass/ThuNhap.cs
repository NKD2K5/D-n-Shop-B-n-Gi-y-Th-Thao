using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("ThuNhap")]
    public partial class ThuNhap
    {
        public ThuNhap()
        {
            ThongKes = new HashSet<ThongKe>();
        }

        [Key]
        [Column("maThuNhap")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaThuNhap { get; set; } = null!;
        [Column("tienNhaphang", TypeName = "money")]
        public decimal? TienNhaphang { get; set; }
        [Column("tienBanHang", TypeName = "money")]
        public decimal? TienBanHang { get; set; }
        [Column("tienLai", TypeName = "money")]
        public decimal? TienLai { get; set; }

        [InverseProperty(nameof(ThongKe.MaThuNhapNavigation))]
        public virtual ICollection<ThongKe> ThongKes { get; set; }
    }
}
