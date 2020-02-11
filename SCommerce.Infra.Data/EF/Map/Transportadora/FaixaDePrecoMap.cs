using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Transportadora
{
    public class FaixaDePrecoMap : IEntityTypeConfiguration<FaixaDePreco>
    {
        public void Configure(EntityTypeBuilder<FaixaDePreco> builder)
        {
            builder.ToTable("FaixaDePreco");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Transportadora).WithMany(x => x.FaixaDePreco).HasForeignKey(x => x.IdTransportadora);
        }
    }
}
