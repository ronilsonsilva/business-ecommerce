using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class ProdutoMap : IEntityTypeConfiguration<Domain.Entities.Produto.Produto>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Produto.Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.ID);
            builder.HasMany(x => x.imagens).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.CarrinhoProdutos).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.ProdutoPropriedades).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.ProdutoTags).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.ProdutoFornecedors).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.ProdutoTransportadoras).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.ProdutoGrupos).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.ProdutoLojas).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.OCDetalhes).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasMany(x => x.ProdutoPromocaos).WithOne(x => x.Produto).HasForeignKey(x => x.IdProduto);
            builder.HasOne(x => x.CategoriaPadrao).WithMany(x => x.Produtos).HasForeignKey(x => x.IdCategoriaPadrao);
        }
    }
}
