using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL_DuAn.DomainClass;

namespace DAL_DuAn.Context
{
    public partial class MyContext : DbContext
    {
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DangKy> DangKies { get; set; } = null!;
        public virtual DbSet<DangNhap> DangNhaps { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<GioHang> GioHangs { get; set; } = null!;
        public virtual DbSet<HangGiay> HangGiays { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LoaiDichVu> LoaiDichVus { get; set; } = null!;
        public virtual DbSet<LoaiPhuKien> LoaiPhuKiens { get; set; } = null!;
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; } = null!;
        public virtual DbSet<LoaiVoucher> LoaiVouchers { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SizeGiay> SizeGiays { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<ThongKe> ThongKes { get; set; } = null!;
        public virtual DbSet<ThongTinSanPham> ThongTinSanPhams { get; set; } = null!;
        public virtual DbSet<ThuNhap> ThuNhaps { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source= DESKTOP-17FI7CO\\FPT ;Initial Catalog= DuAn3;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangKy>(entity =>
            {
                entity.HasKey(e => e.TenTaiKhoanDangKy)
                    .HasName("PK__DangKy__15CD6C419CF8B173");
            });

            modelBuilder.Entity<DangNhap>(entity =>
            {
                entity.HasKey(e => e.TenTaiKhoanDangNhap)
                    .HasName("PK__DangNhap__6FADC54E81A35515");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaHoaDon)
                    .HasConstraintName("FK__FEEDBACK__maHoaD__5441852A");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK__FEEDBACK__maKhac__534D60F1");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasKey(e => e.MaGioHang)
                    .HasName("PK__GioHang__2C76D203E98D68AD");
            });

            modelBuilder.Entity<HangGiay>(entity =>
            {
                entity.HasKey(e => e.MaHangGiay)
                    .HasName("PK__HangGiay__7A66089A5B0B394B");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__026B4D9A742DB196");

                entity.HasOne(d => d.MaGioHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaGioHang)
                    .HasConstraintName("FK__HoaDon__maGioHan__4E88ABD4");

                entity.HasOne(d => d.MaHoaDonChiTietNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaHoaDonChiTiet)
                    .HasConstraintName("FK__HoaDon__maHoaDon__5070F446");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK__HoaDon__maNhanVi__5165187F");

                entity.HasOne(d => d.MaVoucherNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaVoucher)
                    .HasConstraintName("FK__HoaDon__maVouche__4F7CD00D");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.MaHoaDonChiTiet)
                    .HasName("PK__HoaDonCh__1FEAFF2B9E002B6D");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK__HoaDonChi__maKha__4BAC3F29");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaNhanVien)
                    .HasConstraintName("FK__HoaDonChi__maNha__49C3F6B7");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaSanPham)
                    .HasConstraintName("FK__HoaDonChi__maSan__4AB81AF0");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__0CCB3D49725C1BF4");
            });

            modelBuilder.Entity<LoaiDichVu>(entity =>
            {
                entity.HasKey(e => e.MaLoaiDichVu)
                    .HasName("PK__LoaiDich__9A9DA689665C47E5");
            });

            modelBuilder.Entity<LoaiPhuKien>(entity =>
            {
                entity.HasKey(e => e.MaLoaiPhuKien)
                    .HasName("PK__LoaiPhuK__E92B2F3C3FC3BC21");
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSanPham)
                    .HasName("PK__LoaiSanP__20860A2210A9E14C");
            });

            modelBuilder.Entity<LoaiVoucher>(entity =>
            {
                entity.HasKey(e => e.MaLoaiVoucher)
                    .HasName("PK__LoaiVouc__AE4DC09799FA1002");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__BDDEF20D12F3F482");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__5B439C4354F7C10A");

                entity.HasOne(d => d.MaGioHangNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaGioHang)
                    .HasConstraintName("FK__SanPham__maGioHa__3E52440B");

                entity.HasOne(d => d.MaLoaiDichVuNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoaiDichVu)
                    .HasConstraintName("FK__SanPham__maLoaiD__3D5E1FD2");

                entity.HasOne(d => d.MaLoaiPhuKienNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoaiPhuKien)
                    .HasConstraintName("FK__SanPham__maLoaiP__3C69FB99");

                entity.HasOne(d => d.MaThongTinSanPhamNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaThongTinSanPham)
                    .HasConstraintName("FK__SanPham__maThong__3B75D760");
            });

            modelBuilder.Entity<SizeGiay>(entity =>
            {
                entity.HasKey(e => e.SoSize)
                    .HasName("PK__SizeGiay__847DBD6CA57F584C");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasOne(d => d.TenTaiKhoanDangKyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TenTaiKhoanDangKy)
                    .HasConstraintName("FK__TaiKhoan__tenTai__276EDEB3");

                entity.HasOne(d => d.TenTaiKhoanDangNhapNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.TenTaiKhoanDangNhap)
                    .HasConstraintName("FK__TaiKhoan__tenTai__286302EC");
            });

            modelBuilder.Entity<ThongKe>(entity =>
            {
                entity.HasKey(e => e.MaThongKe)
                    .HasName("PK__ThongKe__171157B00999E298");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.ThongKes)
                    .HasForeignKey(d => d.MaHoaDon)
                    .HasConstraintName("FK__ThongKe__maHoaDo__797309D9");

                entity.HasOne(d => d.MaThuNhapNavigation)
                    .WithMany(p => p.ThongKes)
                    .HasForeignKey(d => d.MaThuNhap)
                    .HasConstraintName("FK__ThongKe__maThuNh__7A672E12");
            });

            modelBuilder.Entity<ThongTinSanPham>(entity =>
            {
                entity.HasKey(e => e.MaThongTinSanPham)
                    .HasName("PK__ThongTin__A1990AF936110AD0");

                entity.HasOne(d => d.MaHangGiayNavigation)
                    .WithMany(p => p.ThongTinSanPhams)
                    .HasForeignKey(d => d.MaHangGiay)
                    .HasConstraintName("FK__ThongTinS__maHan__31EC6D26");

                entity.HasOne(d => d.MaLoaiSanPhamNavigation)
                    .WithMany(p => p.ThongTinSanPhams)
                    .HasForeignKey(d => d.MaLoaiSanPham)
                    .HasConstraintName("FK__ThongTinS__maLoa__30F848ED");

                entity.HasOne(d => d.SoSizeNavigation)
                    .WithMany(p => p.ThongTinSanPhams)
                    .HasForeignKey(d => d.SoSize)
                    .HasConstraintName("FK__ThongTinS__soSiz__32E0915F");
            });

            modelBuilder.Entity<ThuNhap>(entity =>
            {
                entity.HasKey(e => e.MaThuNhap)
                    .HasName("PK__ThuNhap__0E4D1E1393A68F8B");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.MaVoucher)
                    .HasName("PK__Voucher__E335C400F864BD59");

                entity.HasOne(d => d.MaLoaiVoucherNavigation)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.MaLoaiVoucher)
                    .HasConstraintName("FK__Voucher__maLoaiV__44FF419A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
