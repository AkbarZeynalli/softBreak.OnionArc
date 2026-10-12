using Microsoft.AspNetCore.Identity;
using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using SoftBreak.Onion.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Concretes
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Releational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}
