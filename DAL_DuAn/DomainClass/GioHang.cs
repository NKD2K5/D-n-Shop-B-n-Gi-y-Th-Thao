﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("GioHang")]
    public partial class GioHang
    {
        public GioHang()
        {
            HoaDons = new HashSet<HoaDon>();
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [Column("maGioHang")]
        [StringLength(20)]
        [Unicode(false)]
        public string MaGioHang { get; set; } = null!;
        [Column("loaiGiay")]
        [StringLength(150)]
        public string? LoaiGiay { get; set; }
        [StringLength(150)]
        public string? Hang { get; set; }
        [Column("tenSanPham")]
        [StringLength(150)]
        public string? TenSanPham { get; set; }
        [StringLength(150)]
        public string? Mau { get; set; }
        [Column("size")]
        [StringLength(150)]
        public string? Size { get; set; }
        [Column("phuKien")]
        [StringLength(150)]
        public string? PhuKien { get; set; }
        [Column("dichVu")]
        [StringLength(150)]
        public string? DichVu { get; set; }
        [Column("soLuong")]
        public int? SoLuong { get; set; }
        [Column("gia", TypeName = "money")]
        public decimal? Gia { get; set; }

        [InverseProperty(nameof(HoaDon.MaGioHangNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [InverseProperty(nameof(SanPham.MaGioHangNavigation))]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
