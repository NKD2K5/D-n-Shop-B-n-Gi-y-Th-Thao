using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Keyless]
    [Table("FEEDBACK")]
    public partial class Feedback
    {
        [Column("maKhachHang")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaKhachHang { get; set; }
        [Column("maHoaDon")]
        [StringLength(20)]
        [Unicode(false)]
        public string? MaHoaDon { get; set; }

        [ForeignKey(nameof(MaHoaDon))]
        public virtual HoaDon? MaHoaDonNavigation { get; set; }
        [ForeignKey(nameof(MaKhachHang))]
        public virtual KhachHang? MaKhachHangNavigation { get; set; }
    }
}
