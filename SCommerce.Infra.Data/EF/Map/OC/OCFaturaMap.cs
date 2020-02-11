using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.OC
{
    public class OCFaturaMap : IEntityTypeConfiguration<OCFatura>
    {
        public void Configure(EntityTypeBuilder<OCFatura> builder)
        {
            builder.ToTable("OCFatura");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.OC).WithMany(x => x.OCFaturas).HasForeignKey(x => x.IdOC);
            builder.HasMany(x => x.OCPagamentos).WithOne(x => x.OCFatura).HasForeignKey(x => x.IdOCFatura);
        }
    }
}
