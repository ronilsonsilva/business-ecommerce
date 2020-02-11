using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Transportadora
{
    public class TransportadoraMap : IEntityTypeConfiguration<Domain.Entities.Transportadora.Transportadora>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Transportadora.Transportadora> builder)
        {
            builder.ToTable("Transportadora");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome);
            builder.HasMany(x => x.TransportadoraEndereco).WithOne(x => x.Transportadora).HasForeignKey(x => x.IdTranportadora);
            builder.HasMany(x => x.TransportadoraLoja).WithOne(x => x.Transportadora).HasForeignKey(x => x.IdTransportadora);
            builder.HasMany(x => x.FaixaDePeso).WithOne(x => x.Transportadora).HasForeignKey(x => x.IdTransportadora);
            builder.HasMany(x => x.FaixaDePreco).WithOne(x => x.Transportadora).HasForeignKey(x => x.IdTransportadora);
            builder.HasMany(x => x.ProdutoTransportadoras).WithOne(x => x.Transportadora).HasForeignKey(x => x.IdTransportadora);
            builder.HasMany(x => x.Entregas).WithOne(x => x.Transportadora).HasForeignKey(x => x.IdTransportadora);
        }
    }
}
