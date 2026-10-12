using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SoftBreak.Onion.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.Persistence.Configurations
{
    public class AppUserRoleConfiguration : BaseConfiguration<AppUserRole> 
    {
        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            base.Configure(builder);
            // Additional configuration for AppUserRole can be added here if needed
            //builder.Ignore(x => x.Id);

            //builder.HasKey(x => new { x.UserId, x.RoleId });
        }
    }
}
