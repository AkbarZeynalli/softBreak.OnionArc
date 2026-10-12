using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftBreak.Onion.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.Persistence.Configurations
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            // use parameterless WithOne() if AppUserProfile has no AppUser navigation
            builder.HasOne(x => x.Profile)
                   .WithOne()
                   .HasForeignKey<AppUserProfile>(x => x.Id);
        }
    }
}
