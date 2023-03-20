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
    public class Ban_HDConfi : IEntityTypeConfiguration<Ban_HD>
    {
        public void Configure(EntityTypeBuilder<Ban_HD> builder)
        {
            builder.HasKey(p => new { p.IdBan, p.IdHd });
            builder.HasOne(p => p.Ban).WithMany(p => p.Ban_HDs).HasForeignKey(p => p.IdBan).HasConstraintName("FK_Ban");
            builder.HasOne(p => p.HoaDon).WithMany(p => p.Ban_HDs).HasForeignKey(p => p.IdHd);
        }
    }
}
