using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.OC
{
    public class OCDetalhesMap : IEntityTypeConfiguration<OCDetalhes>
    {
        public void Configure(EntityTypeBuilder<OCDetalhes> builder)
        {
            builder.ToTable("OCDetalhes");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.OC).WithMany(x => x.OCDetalhes).HasForeignKey(x => x.IdOC);
            builder.HasOne(x => x.Produto).WithMany(x => x.OCDetalhes).HasForeignKey(x => x.IdProduto);
        }
    }
}
