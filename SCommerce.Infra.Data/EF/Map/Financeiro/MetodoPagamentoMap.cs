using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Financeiro
{
    public class MetodoPagamentoMap : IEntityTypeConfiguration<MetodoPagamento>
    {
        public void Configure(EntityTypeBuilder<MetodoPagamento> builder)
        {
            builder.ToTable("MetodoPagamento");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.HasMany(x => x.OCs).WithOne(x => x.MetodoPagamento).HasForeignKey(x => x.IdMetotoPagamento);
        }
    }
}
