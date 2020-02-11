using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.OC;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.OC
{
    public class OCMap : IEntityTypeConfiguration<Domain.Entities.OC.OC>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.OC.OC> builder)
        {
            builder.ToTable("OC");
            builder.HasKey(x => x.ID);

            builder.HasOne(x => x.MetodoPagamento).WithMany(x => x.OCs).HasForeignKey(x => x.IdMetotoPagamento);
            builder.HasOne(x => x.OCStatus).WithMany(x => x.OCs).HasForeignKey(x => x.IdOCStatus);
            builder.HasOne(x => x.Cliente).WithMany(x => x.OCs).HasForeignKey(x => x.IdCliente);
            builder.HasOne(x => x.Loja).WithMany(x => x.OCs).HasForeignKey(x => x.IdLoja);

            builder.HasMany(x => x.ClienteProcessos).WithOne(x => x.OC).HasForeignKey(x => x.IdOC);
            builder.HasMany(x => x.OCDetalhes).WithOne(x => x.OC).HasForeignKey(x => x.IdOC);
            builder.HasMany(x => x.OCFaturas).WithOne(x => x.OC).HasForeignKey(x => x.IdOC);
            builder.HasMany(x => x.OCMensagens).WithOne(x => x.OC).HasForeignKey(x => x.IdOC);
            builder.HasMany(x => x.EmpregadoOCs).WithOne(x => x.OC).HasForeignKey(x => x.IdOC);
            builder.HasMany(x => x.Entregas).WithOne(x => x.OC).HasForeignKey(x => x.IdOC);
        }
    }
}
