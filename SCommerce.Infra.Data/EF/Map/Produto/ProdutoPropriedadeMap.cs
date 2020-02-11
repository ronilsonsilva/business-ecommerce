using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class ProdutoPropriedadeMap : IEntityTypeConfiguration<ProdutoPropriedade>
    {
        public void Configure(EntityTypeBuilder<ProdutoPropriedade> builder)
        {
            builder.ToTable("ProdutoPropriedade");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Produto).WithMany(x => x.ProdutoPropriedades).HasForeignKey(x => x.IdProduto);
            builder.HasOne(x => x.Propriedade).WithMany(x => x.ProdutoPropriedades).HasForeignKey(x => x.IdPropriedade);
        }
    }
}
