using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftBreak.Onion.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.Persistence.Configurations
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            // Additional configuration for Product can be added here if needed
            builder.Property(x=> x.Price).HasColumnType("money");
        }
    }
}
