//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.OC;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.OC
//{
//    public class CustomizacaoDadosMap : IEntityTypeConfiguration<CustomizacaoDados>
//    {
//        public void Configure(EntityTypeBuilder<CustomizacaoDados> builder)
//        {
//            builder.ToTable("CustomizacaoDados");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Customizacao).WithMany().HasForeignKey("IdCustomizacao");
//        }
//    }
//}
