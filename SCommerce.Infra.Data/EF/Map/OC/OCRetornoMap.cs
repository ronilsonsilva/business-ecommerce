//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.OC;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.OC
//{
//    public class OCRetornoMap : IEntityTypeConfiguration<OCRetorno>
//    {
//        public void Configure(EntityTypeBuilder<OCRetorno> builder)
//        {
//            builder.ToTable("OCRetorno");
//            builder.HasKey(x => x.ID);
//            //builder.HasKey(x => new { x.OCId, x.ClienteId });
//            builder.HasOne(x => x.OC).WithMany().HasForeignKey("IdOC").IsRequired();
//            //builder.HasOne(x => x.Cliente).WithMany().HasForeignKey("IdCliente").IsRequired();
//        }
//    }
//}
