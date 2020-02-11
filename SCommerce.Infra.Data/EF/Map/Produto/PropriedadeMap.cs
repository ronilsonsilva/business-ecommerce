using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class PropriedadeMap : IEntityTypeConfiguration<Propriedade>
    {
        public void Configure(EntityTypeBuilder<Propriedade> builder)
        {
            builder.ToTable("Propriedade");
            builder.HasKey(x => x.ID);
            builder.HasMany(x => x.propriedadeValors).WithOne(x => x.Propriedade).HasForeignKey(x => x.IdPropriedade);
            builder.HasMany(x => x.ProdutoPropriedades).WithOne(x => x.Propriedade).HasForeignKey(x => x.IdPropriedade);
        }
    }
}
