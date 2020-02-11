using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.Produto
{
    public class TagMap : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");
            builder.HasKey(x => x.ID);
            builder.HasMany(x => x.ProdutoTags).WithOne(x => x.Tag).HasForeignKey(x => x.IdTag);
        }
    }
}
