using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Cliente;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Cliente
{
    public class ClienteMap : IEntityTypeConfiguration<Domain.Entities.Cliente.Cliente>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Cliente.Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Senha).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Usuario).IsRequired();
            builder.HasMany(x => x.Enderecos).WithOne(x => x.Cliente).HasForeignKey(x => x.IdCliente);
            builder.HasMany(x => x.ContatoTelefones).WithOne(x => x.Cliente).HasForeignKey(x => x.IdCliente);
            builder.HasMany(x => x.OCs).WithOne(x => x.Cliente).HasForeignKey(x => x.IdCliente);
            builder.HasMany(x => x.Carrinhos).WithOne(x => x.Cliente).HasForeignKey(x => x.IdCliente);

        }
    }
}
