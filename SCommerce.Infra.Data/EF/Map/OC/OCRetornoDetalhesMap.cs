//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.OC;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.OC
//{
//    public class OCRetornoDetalhesMap : IEntityTypeConfiguration<OCRetornoDetalhes>
//    {
//        public void Configure(EntityTypeBuilder<OCRetornoDetalhes> builder)
//        {
//            builder.ToTable("OCRetornoDetalhes");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.OCRetorno).WithMany().HasForeignKey("IdOCRetorno").IsRequired();
//        }
//    }
//}
