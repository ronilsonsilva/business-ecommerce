using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class ContatoLojaTelefoneMap : IEntityTypeConfiguration<ContatoLojaTelefone>
    {
        public void Configure(EntityTypeBuilder<ContatoLojaTelefone> builder)
        {
            builder.ToTable("ContatoLojaTelefone");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.ContatoLoja).WithMany(x => x.ContatoLojaTelefones).HasForeignKey(x => x.IdContatoLoja);
            builder.HasOne(x => x.ContatoTelefone).WithMany(x => x.ContatoLojaTelefones).HasForeignKey(x => x.IdContatoTelefone);
            builder.HasMany(x => x.CMSWhatsApps).WithOne(x => x.ContatoLojaTelefone).HasForeignKey(x => x.IDContatoLojaTelefone);
        }
    }
}
