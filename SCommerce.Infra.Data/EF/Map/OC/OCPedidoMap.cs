//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.OC;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.OC
//{
//    public class OCPedidoMap : IEntityTypeConfiguration<OCPedido>
//    {
//        public void Configure(EntityTypeBuilder<OCPedido> builder)
//        {
//            builder.ToTable("OCPedido");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.OC).WithMany().HasForeignKey("IdOC").IsRequired();
//        }
//    }
//}
