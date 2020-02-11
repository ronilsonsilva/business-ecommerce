//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.CMS;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.CMS
//{
//    public class CMSMap : IEntityTypeConfiguration<Domain.Entities.CMS.CMS>
//    {
//        public void Configure(EntityTypeBuilder<Domain.Entities.CMS.CMS> builder)
//        {
//            builder.ToTable("CMS");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.CMSCategoria).WithMany().HasForeignKey("IdCMSCategoria").IsRequired();

//        }
//    }
//}
