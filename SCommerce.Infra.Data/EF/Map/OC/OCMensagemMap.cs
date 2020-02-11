using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.OC
{
    public class OCMensagemMap : IEntityTypeConfiguration<OCMensagem>
    {
        public void Configure(EntityTypeBuilder<OCMensagem> builder)
        {
            builder.ToTable("OCMensagem");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.OC).WithMany(x => x.OCMensagens).HasForeignKey(x => x.IdOC);
            builder.HasMany(x => x.Anexos).WithOne(x => x.OCMensagems).HasForeignKey(x => x.IdOCMensagem);
        }
    }
}
