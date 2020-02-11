//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Cliente;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Cliente
//{
//    public class ClienteContatoTelefoneMap : IEntityTypeConfiguration<ClienteContatoTelefone>
//    {
//        public void Configure(EntityTypeBuilder<ClienteContatoTelefone> builder)
//        {
//            builder.ToTable("ClienteContatoTelefone");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Cliente).WithMany(x => x.ClienteContatoTelefones).HasForeignKey(x => x.IdCliente);
//            builder.HasOne(x => x.ContatoTelefone).WithMany(x => x.ClienteContatoTelefones).HasForeignKey(x => x.IdContatoTelefone);
//        }
//    }
//}
