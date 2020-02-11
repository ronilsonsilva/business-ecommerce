using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class ContatoLojaRedeSocialMap : IEntityTypeConfiguration<ContatoLojaRedeSocial>
    {
        public void Configure(EntityTypeBuilder<ContatoLojaRedeSocial> builder)
        {
            builder.ToTable("ContatoLojaRedeSocial");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.ContatoLoja).WithMany(x => x.ContatoLojaRedeSocials).HasForeignKey(x => x.IdContatoLoja);
            builder.HasOne(x => x.ContatoRedeSocial).WithMany(x => x.ContatoLojaRedeSocials).HasForeignKey(x => x.IdContatoRedeSocial);
        }
    }
}
