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
    public class SP_HDConfi : IEntityTypeConfiguration<SP_HD>
    {
        public void Configure(EntityTypeBuilder<SP_HD> builder)
        {
            builder.HasKey(p => new { p.IdHd, p.IdSp });
            builder.Property(p => p.SoLuong).HasColumnType("int");
            builder.Property(p => p.DonGia).HasColumnType("int");
            builder.HasOne(p => p.SanPham).WithMany(p => p.SP_HDs).HasForeignKey(p => p.IdSp).HasConstraintName("FK_SPHD");
            builder.HasOne(p => p.HoaDon).WithMany(p => p.SP_HDs).HasForeignKey(p => p.IdHd);
        }
    }
}
