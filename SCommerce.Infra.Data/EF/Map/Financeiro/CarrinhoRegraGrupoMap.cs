//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Financeiro;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Financeiro
//{
//    public class CarrinhoRegraGrupoMap : IEntityTypeConfiguration<CarrinhoRegraGrupo>
//    {
//        public void Configure(EntityTypeBuilder<CarrinhoRegraGrupo> builder)
//        {
//            builder.ToTable("CarrinhoRegraGrupo");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.CarrinhoRegra).WithMany().HasForeignKey("CarrinhoRegraId").IsRequired();
//            builder.HasOne(x => x.Grupo).WithMany().HasForeignKey("GrupoId").IsRequired();
//        }
//    }
//}
