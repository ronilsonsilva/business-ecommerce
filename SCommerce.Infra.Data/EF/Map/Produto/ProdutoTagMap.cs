using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class ProdutoTagMap : IEntityTypeConfiguration<ProdutoTag>
    {
        public void Configure(EntityTypeBuilder<ProdutoTag> builder)
        {
            builder.ToTable("ProdutoTag");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Produto).WithMany(x => x.ProdutoTags).HasForeignKey(x => x.IdProduto);
            builder.HasOne(x => x.Tag).WithMany(x => x.ProdutoTags).HasForeignKey(x => x.IdTag);
        }
    }
}
