using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Configurations
{
    public class NhanVienConfi : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.Property(p => p.TaiKhoan).HasColumnType("nvarchar(50)");
            builder.Property(p => p.MatKhau).HasColumnType("nvarchar(50)");
            builder.Property(p => p.HoTen).HasColumnType("nvarchar(100)");
            builder.Property(p => p.GioiTinh).HasColumnType("int");
            builder.Property(p => p.Sdt).HasColumnType("varchar(13)");
            builder.Property(p => p.ChucVu).HasColumnType("int");
            builder.Property(p => p.TrangThai).HasColumnType("int");
        }
    }
}
