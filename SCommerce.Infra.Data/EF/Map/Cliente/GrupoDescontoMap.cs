//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SCommerce.Domain.Entities.Cliente;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SCommerce.Infra.Data.EF.Map.Cliente
//{
//    public class GrupoDescontoMap : IEntityTypeConfiguration<GrupoDesconto>
//    {
//        public void Configure(EntityTypeBuilder<GrupoDesconto> builder)
//        {
//            builder.ToTable("ClienteGrupoDesconto");
//            builder.HasKey(x => x.ID);
//            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey("IdCategoria");
//            builder.HasOne(x => x.Grupo).WithMany().HasForeignKey("IdGrupo");
//        }
//    }
//}
