using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class LojaImagensMap : IEntityTypeConfiguration<LojaImagens>
    {
        public void Configure(EntityTypeBuilder<LojaImagens> builder)
        {
            builder.ToTable("LojaImagens");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Formato).IsRequired();
            builder.Property(x => x.Arquivo).IsRequired();
            builder.HasOne(x => x.Loja).WithMany(x => x.LojaImagens).HasForeignKey(x => x.IdLoja);
        }
    }
}
