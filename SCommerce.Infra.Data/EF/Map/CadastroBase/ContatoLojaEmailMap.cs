using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class ContatoLojaEmailMap : IEntityTypeConfiguration<ContatoLojaEmail>
    {
        public void Configure(EntityTypeBuilder<ContatoLojaEmail> builder)
        {
            builder.ToTable("ContatoLojaEmail");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.ContatoLoja).WithMany(x => x.ContatoLojaEmails).HasForeignKey(x => x.IdContatoLoja);
            builder.HasOne(x => x.ContatoEmail).WithMany(x => x.ContatoLojaEmails).HasForeignKey(x => x.IdContatoEmail);
        }
    }
}
