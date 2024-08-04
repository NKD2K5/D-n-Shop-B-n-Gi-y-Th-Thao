using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [Column("maNhanVien")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaNhanVien { get; set; } = null!;
        [Column("tenNhanVien")]
        [StringLength(80)]
        public string? TenNhanVien { get; set; }
        [Column("diaChi")]
        [StringLength(150)]
        public string? DiaChi { get; set; }
        [Column("soDienThoai")]
        [StringLength(15)]
        [Unicode(false)]
        public string? SoDienThoai { get; set; }
        [Column("email")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("gioiTinh")]
        [StringLength(10)]
        public string? GioiTinh { get; set; }
        [Column("luong", TypeName = "money")]
        public decimal? Luong { get; set; }

        [InverseProperty(nameof(HoaDonChiTiet.MaNhanVienNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        [InverseProperty(nameof(HoaDon.MaNhanVienNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
