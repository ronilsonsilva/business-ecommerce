using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Carrinho;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Carrinho
{
    public class CarrinhoProdutoMap : IEntityTypeConfiguration<CarrinhoProduto>
    {
        public void Configure(EntityTypeBuilder<CarrinhoProduto> builder)
        {
            builder.ToTable("CarrinhoProduto");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Carrinho).WithMany(x => x.CarrinhoProdutos).HasForeignKey(x => x.IdCarrinho);
            builder.HasOne(x => x.Produto).WithMany(x => x.CarrinhoProdutos).HasForeignKey(x => x.IdProduto);
        }
    }
}
