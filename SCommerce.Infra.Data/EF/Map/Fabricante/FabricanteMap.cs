using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Fabricante;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Fabricante
{
    public class FabricanteMap : IEntityTypeConfiguration<Domain.Entities.Fabricante.Fabricante>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Fabricante.Fabricante> builder)
        {
            builder.ToTable("Fabricante");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.HasMany(x => x.FabricanteFornecedor).WithOne(x => x.Fabricante).HasForeignKey(x => x.IdFabricante);
            builder.HasMany(x => x.FabricanteLoja).WithOne(x => x.Fabricante).HasForeignKey(x => x.IdFabricante);
            builder.HasMany(x => x.FabricanteProduto).WithOne(x => x.Fabricante).HasForeignKey(x => x.IdFabricante);
        }
    }
}
