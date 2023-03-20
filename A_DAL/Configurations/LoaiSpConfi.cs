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
    public class LoaiSpConfi : IEntityTypeConfiguration<LoaiSp>
    {
        public void Configure(EntityTypeBuilder<LoaiSp> builder)
        {
            builder.Property(p => p.TenLoai).HasColumnType("nvarchar(50)");
            builder.Property(p => p.MoTa).HasColumnType("nvarchar(100)");
        }
    }
}
