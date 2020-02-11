using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;

using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class CategoriaLojaMap : IEntityTypeConfiguration<CategoriaLoja>
    {
        public void Configure(EntityTypeBuilder<CategoriaLoja> builder)
        {
            builder.ToTable("CategoriaLoja");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Loja).WithMany(x => x.CategoriaLojas).HasForeignKey(x => x.IdLoja);
            builder.HasOne(x => x.Categoria).WithMany(x => x.CategoriaLojas).HasForeignKey(x => x.IdCategoria);
        }
    }
}
