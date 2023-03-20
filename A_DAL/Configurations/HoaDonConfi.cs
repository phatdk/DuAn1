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
    public class HoaDonConfi : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.Property(p => p.NgayTao).HasColumnType("datetime");
            builder.Property(p => p.NgayThanhToan).HasColumnType("datetime");
            builder.Property(p => p.TrangThai).HasColumnType("int");
            builder.Property(p=>p.TongTien).HasColumnType("int");
            builder.HasOne(p => p.NhanVien).WithMany(p => p.HoaDons).HasForeignKey(p => p.IdNv).HasConstraintName("FK_NVHD");
        }
    }
}
