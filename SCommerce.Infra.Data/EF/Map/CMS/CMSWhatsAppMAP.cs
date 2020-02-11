using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CMS;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CMS
{
    public class CMSWhatsAppMAP : IEntityTypeConfiguration<CMSWhatsApp>
    {
        public void Configure(EntityTypeBuilder<CMSWhatsApp> builder)
        {
            builder.ToTable("CMSWhatsApp");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.ContatoLojaTelefone).WithMany(x => x.CMSWhatsApps).HasForeignKey(x => x.IDContatoLojaTelefone);
        }
    }
}
