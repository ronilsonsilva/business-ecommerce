//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.CMS;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.CMS
//{
//    public class CMSCategoriaMap : IEntityTypeConfiguration<CMSCategoria>
//    {
//        public void Configure(EntityTypeBuilder<CMSCategoria> builder)
//        {
//            builder.ToTable("CMSCategoria");
//            builder.HasKey(x => x.ID);
//            builder.Property(x => x.Nome).IsRequired();
//        }
//    }
//}
