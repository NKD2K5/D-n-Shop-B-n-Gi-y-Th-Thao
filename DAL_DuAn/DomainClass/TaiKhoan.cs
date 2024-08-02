using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Keyless]
    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Column("tenTaiKhoan_DangKy")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TenTaiKhoanDangKy { get; set; }
        [Column("tenTaiKhoan_DangNhap")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TenTaiKhoanDangNhap { get; set; }

        [ForeignKey(nameof(TenTaiKhoanDangKy))]
        public virtual DangKy? TenTaiKhoanDangKyNavigation { get; set; }
        [ForeignKey(nameof(TenTaiKhoanDangNhap))]
        public virtual DangNhap? TenTaiKhoanDangNhapNavigation { get; set; }
    }
}
