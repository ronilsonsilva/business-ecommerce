//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.OC;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.OC
//{
//    public class OCHistoricoMap : IEntityTypeConfiguration<OCHistorico>
//    {
//        public void Configure(EntityTypeBuilder<OCHistorico> builder)
//        {
//            builder.ToTable("OCHistorico");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.OC).WithMany().HasForeignKey("IdOC").IsRequired();
//        }
//    }
//}
