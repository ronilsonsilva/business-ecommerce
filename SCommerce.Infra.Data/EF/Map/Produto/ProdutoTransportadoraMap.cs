using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class ProdutoTransportadoraMap : IEntityTypeConfiguration<ProdutoTransportadora>
    {
        public void Configure(EntityTypeBuilder<ProdutoTransportadora> builder)
        {
            builder.ToTable("ProdutoTransportadora");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Produto).WithMany(x => x.ProdutoTransportadoras).HasForeignKey(x => x.IdProduto);
            builder.HasOne(x => x.Transportadora).WithMany(x => x.ProdutoTransportadoras).HasForeignKey(x => x.IdTransportadora);
        }
    }
}
