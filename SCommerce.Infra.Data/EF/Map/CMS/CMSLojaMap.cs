using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CMS
{
    public class CMSLojaMap : IEntityTypeConfiguration<CMSLoja>
    {
        public void Configure(EntityTypeBuilder<CMSLoja> builder)
        {
            builder.ToTable("CMSLoja");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Loja).WithMany(x => x.CMSLojas).HasForeignKey(x => x.IdLoja);
        }
    }
}
