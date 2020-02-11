using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Cliente
{
    public class ClienteMensagemMap : IEntityTypeConfiguration<ClienteMensagem>
    {
        public void Configure(EntityTypeBuilder<ClienteMensagem> builder)
        {
            builder.ToTable("ClienteMensagem");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.ClienteProcesso).WithMany(x => x.ClienteMensagens).HasForeignKey(x => x.IdClienteProcesso);
        }
    }
}
