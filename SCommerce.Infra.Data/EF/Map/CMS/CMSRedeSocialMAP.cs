using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CMS
{
    public class CMSRedeSocialMAP : IEntityTypeConfiguration<CMSRedeSocial>
    {
        public void Configure(EntityTypeBuilder<CMSRedeSocial> builder)
        {
            builder.ToTable("CMSRedeSocial");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Loja).WithMany(x => x.CMSRedeSocials).HasForeignKey(x => x.IdLoja);
        }
    }
}
