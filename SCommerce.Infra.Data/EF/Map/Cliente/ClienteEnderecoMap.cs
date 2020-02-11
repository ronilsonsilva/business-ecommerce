//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Cliente;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Cliente
//{
//    public class ClienteEnderecoMap : IEntityTypeConfiguration<ClienteEndereco>
//    {
//        public void Configure(EntityTypeBuilder<ClienteEndereco> builder)
//        {
//            builder.ToTable("ClienteEndereco");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Cliente).WithMany(x => x.cli);
//            builder.HasOne(x => x.Endereco).WithMany().HasForeignKey("IdEndereco");
//        }
//    }
//}
