//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.OC;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.OC
//{
//    public class DetalhePedidoMap : IEntityTypeConfiguration<DetalhePedido>
//    {
//        public void Configure(EntityTypeBuilder<DetalhePedido> builder)
//        {
//            builder.ToTable("DetalhePedido");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.OCDetalhes).WithMany().HasForeignKey("IdOCDetalhes").IsRequired();
//            builder.HasOne(x => x.OCPedido).WithMany().HasForeignKey("IdOCPedido").IsRequired();
//        }
//    }
//}
