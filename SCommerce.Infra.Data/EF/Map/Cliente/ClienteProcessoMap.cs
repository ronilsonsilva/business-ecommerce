using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Cliente
{
    public class ClienteProcessoMap : IEntityTypeConfiguration<ClienteProcesso>
    {
        public void Configure(EntityTypeBuilder<ClienteProcesso> builder)
        {
            builder.ToTable("ClienteProcesso");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.OC).WithMany(x => x.ClienteProcessos).HasForeignKey(x => x.IdOC);
            builder.HasMany(x => x.ClienteMensagens).WithOne(x => x.ClienteProcesso).HasForeignKey(x => x.IdClienteProcesso);
        }
    }
}
