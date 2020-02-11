using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(x => x.ID);
            builder.HasMany(x => x.Produtos).WithOne(x => x.CategoriaPadrao).HasForeignKey(x => x.IdCategoriaPadrao);
            builder.HasMany(x => x.CategoriaLojas).WithOne(x => x.Categoria).HasForeignKey(x => x.IdCategoria);
        }
    }
}
