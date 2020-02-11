using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("Cidade");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.HasOne(x => x.Provincia).WithMany(x => x.Cidades).HasForeignKey(x => x.IdProvincia);
            builder.HasMany(x => x.Enderecos).WithOne(x => x.Cidade).HasForeignKey(x => x.IdCidade);
        }
    }
}
