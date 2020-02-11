using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class ContatoLojaEnderecoMap : IEntityTypeConfiguration<ContatoLojaEndereco>
    {
        public void Configure(EntityTypeBuilder<ContatoLojaEndereco> builder)
        {
            builder.ToTable("ContatoLojaEndereco");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.ContatoLoja).WithMany(x => x.ContatoLojaEnderecos).HasForeignKey(x => x.IdContatoLoja);
            builder.HasOne(x => x.Endereco).WithMany(x => x.ContatoLojaEnderecos).HasForeignKey(x => x.IdEndereco);
            builder.HasMany(x => x.CMSEnderecoLojas).WithOne(x => x.ContatoLojaEndereco).HasForeignKey(x => x.IdContatoLojaEndereco);
        }
    }
}
