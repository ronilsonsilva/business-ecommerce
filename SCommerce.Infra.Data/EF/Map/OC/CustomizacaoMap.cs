//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.OC;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.OC
//{
//    public class CustomizacaoMap : IEntityTypeConfiguration<Customizacao>
//    {
//        public void Configure(EntityTypeBuilder<Customizacao> builder)
//        {
//            builder.ToTable("Customizacao");
//            builder.HasKey(x => x.ID);
//            builder.Property(x => x.Nome).IsRequired();
//        }
//    }
//}
