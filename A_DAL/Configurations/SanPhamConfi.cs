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
    public class SanPhamConfi : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.Property(p => p.TenSp).HasColumnType("nvarchar(50)");
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(100)");
            builder.Property(p => p.GiaBan).HasColumnType("int");
            builder.Property(p => p.TrangThai).HasColumnType("int");
            builder.HasOne(p => p.KhuyenMai).WithMany(p => p.SanPhams).HasForeignKey(p=>p.IdKm).HasConstraintName("FK_SPKM");
            builder.HasOne(p => p.LoaiSp).WithMany(p => p.SanPhams).HasForeignKey(p=>p.IdLoai).HasConstraintName("FK_SPLoai");
        }
    }
}
