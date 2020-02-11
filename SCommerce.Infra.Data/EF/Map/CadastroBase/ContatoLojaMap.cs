using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class ContatoLojaMap : IEntityTypeConfiguration<ContatoLoja>
    {
        public void Configure(EntityTypeBuilder<ContatoLoja> builder)
        {
            builder.ToTable("ContatoLoja");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.NomeContato).IsRequired();
            builder.HasOne(x => x.Loja).WithMany(x => x.ContatoLojas).HasForeignKey(x => x.IdLoja).IsRequired();
            builder.HasMany(x => x.ContatoLojaTelefones).WithOne(x => x.ContatoLoja).HasForeignKey(x => x.IdContatoLoja);
            builder.HasMany(x => x.ContatoLojaEmails).WithOne(x => x.ContatoLoja).HasForeignKey(x => x.IdContatoLoja);
            builder.HasMany(x => x.ContatoLojaEnderecos).WithOne(x => x.ContatoLoja).HasForeignKey(x => x.IdContatoLoja);
            builder.HasMany(x => x.ContatoLojaRedeSocials).WithOne(x => x.ContatoLoja).HasForeignKey(x => x.IdContatoLoja);
        }
    }
}
