using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Cidade).WithMany(x => x.Enderecos).HasForeignKey(x => x.IdCidade);
            builder.HasOne(x => x.Cliente).WithMany(x => x.Enderecos).HasForeignKey(x => x.IdCliente);
            builder.HasMany(x => x.ContatoLojaEnderecos).WithOne(x => x.Endereco).HasForeignKey(x => x.IdEndereco);
            builder.HasMany(x => x.TransportadoraEnderecos).WithOne(x => x.Endereco).HasForeignKey(x => x.IdEndereco);
            builder.HasMany(x => x.EmpregadoEnderecos).WithOne(x => x.Endereco).HasForeignKey(x => x.IdEndereco);

        }
    }
}
