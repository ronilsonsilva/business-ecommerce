using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class ProdutoPromocaoMAP : IEntityTypeConfiguration<ProdutoPromocao>
    {
        public void Configure(EntityTypeBuilder<ProdutoPromocao> builder)
        {
            builder.ToTable("ProdutoPromocao");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Produto).WithMany(x => x.ProdutoPromocaos).HasForeignKey(x => x.IdProduto);
        }
    }
}
