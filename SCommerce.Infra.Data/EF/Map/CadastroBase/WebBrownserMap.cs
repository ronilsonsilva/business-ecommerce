using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCommerce.Domain.Entities.CadastroBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCommerce.Infra.Data.EF.Map.CadastroBase
{
    public class WebBrownserMap : IEntityTypeConfiguration<WebBrownser>
    {
        public void Configure(EntityTypeBuilder<WebBrownser> builder)
        {
            builder.ToTable("WebBrownser");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Nome).IsRequired();
        }
    }
}
