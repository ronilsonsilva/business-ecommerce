//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Cliente;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Cliente
//{
//    public class ClienteGrupoMap : IEntityTypeConfiguration<ClienteGrupo>
//    {
//        public void Configure(EntityTypeBuilder<ClienteGrupo> builder)
//        {
//            builder.ToTable("ClienteGrupo");
//            builder.HasKey(x => x.ID);
//            //builder.HasOne(x => x.Cliente).WithMany().HasForeignKey("IdCliente");
//            //builder.HasOne(x => x.Grupo).WithMany().HasForeignKey("IdGrupo");
//        }
//    }
//}
