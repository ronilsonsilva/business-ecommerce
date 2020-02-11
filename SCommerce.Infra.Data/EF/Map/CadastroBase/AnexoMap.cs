using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class AnexoMap : IEntityTypeConfiguration<Anexo>
    {
        public void Configure(EntityTypeBuilder<Anexo> builder)
        {
            builder.ToTable("Anexo");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Arquivo).IsRequired();
            builder.Property(x => x.Tipo).IsRequired();
            builder.HasOne(x => x.OCMensagems).WithMany(x => x.Anexos).HasForeignKey(x => x.IdOCMensagem);
        }
    }
}
