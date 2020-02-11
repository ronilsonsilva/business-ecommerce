using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class SistemaOperacionalMap : IEntityTypeConfiguration<SistemaOperacional>
    {
        public void Configure(EntityTypeBuilder<SistemaOperacional> builder)
        {
            builder.ToTable("SistemaOperacional");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
        }
    }
}
