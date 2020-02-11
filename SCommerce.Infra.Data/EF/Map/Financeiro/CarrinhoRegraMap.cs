//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Financeiro;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Financeiro
//{
//    public class CarrinhoRegraMap : IEntityTypeConfiguration<CarrinhoRegra>
//    {
//        public void Configure(EntityTypeBuilder<CarrinhoRegra> builder)
//        {
//            builder.ToTable("CarrinhoRegra");
//            builder.HasKey(x => x.ID);
//            builder.Property(x => x.Nome).IsRequired();
//        }
//    }
//}
