using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Models
{
    public class CofffeeDbContext : DbContext
    {
        public CofffeeDbContext() { }
        public CofffeeDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<Ban> bans { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<LoaiSp> loaiSps { get; set; }
        public DbSet<KhuyenMai> khuyenMais { get; set; }
        public DbSet<Ban_HD> ban_HDs { get; set; }
        public DbSet<SP_HD> sP_HDs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.
                UseSqlServer(@"Data Source=DESKTOP-L9TSC4C\SQLEXPRESS;Initial Catalog=CoffeeLord;Persist Security Info=True;User ID=phatdk;Password=123456"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
