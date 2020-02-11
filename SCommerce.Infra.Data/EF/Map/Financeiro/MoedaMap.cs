using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Financeiro;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Financeiro
{
    public class MoedaMap : IEntityTypeConfiguration<Moeda>
    {
        public void Configure(EntityTypeBuilder<Moeda> builder)
        {
            builder.ToTable("Moeda");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.CodigoIso).IsRequired();
        }
    }
}
