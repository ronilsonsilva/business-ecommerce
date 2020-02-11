using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Fabricante;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Fabricante
{
    public class FabricanteLojaMap : IEntityTypeConfiguration<FabricanteLoja>
    {
        public void Configure(EntityTypeBuilder<FabricanteLoja> builder)
        {
            builder.ToTable("FabricanteLoja");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Fabricante).WithMany(x => x.FabricanteLoja).HasForeignKey(x => x.IdFabricante);
            builder.HasOne(x => x.Loja).WithMany(x => x.FabricanteLojas).HasForeignKey(x => x.IdLoja);
        }
    }
}
