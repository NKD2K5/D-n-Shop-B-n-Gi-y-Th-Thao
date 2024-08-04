using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL_DuAn.DomainClass
{
    [Table("DangKy")]
    public partial class DangKy
    {
        [Key]
        [Column("tenTaiKhoan_DangKy")]
        [StringLength(50)]
        [Unicode(false)]
        public string TenTaiKhoanDangKy { get; set; } = null!;
        [Column("matKhau")]
        [StringLength(50)]
        [Unicode(false)]
        public string? MatKhau { get; set; }
        [Column("email")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("soDienThoai")]
        [StringLength(15)]
        [Unicode(false)]
        public string? SoDienThoai { get; set; }
        [Column("diaChi")]
        [StringLength(150)]
        public string? DiaChi { get; set; }
    }
}
