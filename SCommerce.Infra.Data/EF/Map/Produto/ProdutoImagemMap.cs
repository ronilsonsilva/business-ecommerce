using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class ProdutoImagemMap : IEntityTypeConfiguration<ProdutoImagem>
    {
        public void Configure(EntityTypeBuilder<ProdutoImagem> builder)
        {
            builder.ToTable("ProdutoImagem");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Produto).WithMany(x => x.imagens).HasForeignKey(x => x.IdProduto);
        }
    }
}
