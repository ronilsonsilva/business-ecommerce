using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class ProvinciaMap : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> builder)
        {
            builder.ToTable("Provincia");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.HasOne(x => x.Pais).WithMany(x => x.Provincias).HasForeignKey(x => x.IdPais);
            builder.HasMany(x => x.Cidades).WithOne(x => x.Provincia).HasForeignKey(x => x.IdProvincia);
        }
    }
}
