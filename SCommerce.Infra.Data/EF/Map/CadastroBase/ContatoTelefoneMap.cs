using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class ContatoTelefoneMap : IEntityTypeConfiguration<ContatoTelefone>
    {
        public void Configure(EntityTypeBuilder<ContatoTelefone> builder)
        {
            builder.ToTable("ContatoTelefone");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CodigoLocal).IsRequired();
            builder.Property(x => x.CodigoNacional).IsRequired();
            builder.Property(x => x.Numero).IsRequired();
            builder.HasOne(x => x.Cliente).WithMany(x => x.ContatoTelefones).HasForeignKey(x => x.IdCliente);
            builder.HasMany(x => x.ContatoLojaTelefones).WithOne(x => x.ContatoTelefone).HasForeignKey(x => x.IdContatoTelefone);
        }
    }
}
