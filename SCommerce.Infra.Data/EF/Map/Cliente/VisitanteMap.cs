//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Cliente;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Cliente
//{
//    public class VisitanteMap : IEntityTypeConfiguration<Visitante>
//    {
//        public void Configure(EntityTypeBuilder<Visitante> builder)
//        {
//            builder.ToTable("Visitante");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Cliente).WithMany().HasForeignKey("IdCliente");
//            builder.HasOne(x => x.SistemaOperacional).WithMany().HasForeignKey("IdSistemaOperacional");
//            builder.HasOne(x => x.WebBrownser).WithMany().HasForeignKey("IdWebBrownser");
//        }
//    }
//}
