using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.OC
{
    public class OCPagamentoMap : IEntityTypeConfiguration<OCPagamento>
    {
        public void Configure(EntityTypeBuilder<OCPagamento> builder)
        {
            builder.ToTable("OCPagamento");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.OCFatura).WithMany(x => x.OCPagamentos).HasForeignKey(x => x.IdOCFatura);
        }
    }
}
