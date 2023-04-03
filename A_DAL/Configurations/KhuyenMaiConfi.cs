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
    public class KhuyenMaiConfi : IEntityTypeConfiguration<KhuyenMai>
    {
        public void Configure(EntityTypeBuilder<KhuyenMai> builder)
        {
            builder.Property(p => p.Ten).HasColumnType("nvarchar(100)");
            builder.Property(p => p.NgayTao).HasColumnType("datetime");
            builder.Property(p => p.NgayBd).HasColumnType("datetime");
            builder.Property(p => p.NgayKt).HasColumnType("datetime");
            builder.Property(p => p.MoTa).HasColumnType("Nvarchar(100)");
            builder.Property(p => p.PhamTramGiam).HasColumnType("int");
            builder.Property(p => p.SoTienGiam).HasColumnType("int");
            builder.Property(p => p.DkGiam).HasColumnType("nvarchar(50)");
            builder.Property(p=>p.TrangThai).HasColumnType("int");
        }
    }
}
