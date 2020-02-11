using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class ProdutoFornecedorMap : IEntityTypeConfiguration<ProdutoFornecedor>
    {
        public void Configure(EntityTypeBuilder<ProdutoFornecedor> builder)
        {
            builder.ToTable("ProdutoFornecedor");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Produto).WithMany(x => x.ProdutoFornecedors).HasForeignKey(x => x.IdProduto);
            builder.HasOne(x => x.Fornecedor).WithMany(x => x.ProdutoFornecedors).HasForeignKey(x => x.IdFornecedor);
        }
    }
}
