using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Concretes
{
    public class AppRole : BaseEntity
    {
        public string RoleName { get; set; }

        //Releational Properties
        public virtual ICollection<AppUserRole> AppUserRoles { get; set; } 
    }
}
