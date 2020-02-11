using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CMS
{
    public class CMSEnderecoLojaMAP : IEntityTypeConfiguration<CMSEnderecoLoja>
    {
        public void Configure(EntityTypeBuilder<CMSEnderecoLoja> builder)
        {
            builder.ToTable("CMSEnderecoLoja");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.ContatoLojaEndereco).WithMany(x => x.CMSEnderecoLojas).HasForeignKey(x => x.IdContatoLojaEndereco);
        }
    }
}
