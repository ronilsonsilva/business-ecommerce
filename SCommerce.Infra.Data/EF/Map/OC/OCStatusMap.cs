using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.OC
{
    public class OCStatusMap : IEntityTypeConfiguration<OCStatus>
    {
        public void Configure(EntityTypeBuilder<OCStatus> builder)
        {
            builder.ToTable("OCStatus");
            builder.HasKey(x => x.ID);
            builder.HasMany(x => x.OCs).WithOne(x => x.OCStatus).HasForeignKey(x => x.IdOCStatus);
        }
    }
}
