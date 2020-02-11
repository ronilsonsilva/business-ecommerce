using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SCommerce.Domain.Entities.Carrinho;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;

namespace SCommerce.Infra.Data.EF.Map.Carrinho
{
    public class CarrinhoMap : IEntityTypeConfiguration<Domain.Entities.Carrinho.Carrinho>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Carrinho.Carrinho> builder)
        {
            builder.ToTable("Carrinho");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Loja).WithMany(x => x.Carrinhos).HasForeignKey(x => x.IdLoja);
            builder.HasOne(x => x.Cliente).WithMany(x => x.Carrinhos).HasForeignKey(x => x.IdCliente);
            builder.HasMany(x => x.CarrinhoProdutos).WithOne(x => x.Carrinho).HasForeignKey(x => x.IdCarrinho);
        }
    }
}
