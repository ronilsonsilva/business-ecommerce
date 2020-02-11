//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Financeiro;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Financeiro
//{
//    public class CarrinhoRegraPaisMap : IEntityTypeConfiguration<CarrinhoRegraPais>
//    {
//        public void Configure(EntityTypeBuilder<CarrinhoRegraPais> builder)
//        {
//            builder.ToTable("CarrinhoRegraPais");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.CarrinhoRegra).WithMany().HasForeignKey("CarrinhoRegraId").IsRequired();
//            builder.HasOne(x => x.Pais).WithMany().HasForeignKey("PaisId").IsRequired();
//        }
//    }
//}
