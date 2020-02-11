using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class PropriedadeValorMap : IEntityTypeConfiguration<PropriedadeValor>
    {
        public void Configure(EntityTypeBuilder<PropriedadeValor> builder)
        {
            builder.ToTable("PropriedadeValor");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Propriedade).WithMany(x => x.propriedadeValors).HasForeignKey(x => x.IdPropriedade).IsRequired();

        }
    }
}
