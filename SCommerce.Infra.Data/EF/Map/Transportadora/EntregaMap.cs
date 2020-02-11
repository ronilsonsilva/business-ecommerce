using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Transportadora;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Transportadora
{
    public class EntregaMap : IEntityTypeConfiguration<Entrega>
    {
        public void Configure(EntityTypeBuilder<Entrega> builder)
        {
            builder.ToTable("Entrega");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Transportadora).WithMany(x => x.Entregas).HasForeignKey(x => x.IdTransportadora);
            builder.HasOne(x => x.OC).WithMany(x => x.Entregas).HasForeignKey(x => x.IdOC);
        }
    }
}
