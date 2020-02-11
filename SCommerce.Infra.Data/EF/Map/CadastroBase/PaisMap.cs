using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class PaisMap : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Codigo).IsRequired();
            builder.HasMany(x => x.Provincias).WithOne(x => x.Pais).HasForeignKey(x => x.IdPais);
        }
    }
}
