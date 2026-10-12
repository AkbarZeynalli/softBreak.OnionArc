using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Concretes
{
    public  class AppUserRole : BaseEntity
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        //Releational Properties
        public virtual AppUser AppUser { get; set; }
        public virtual AppRole AppRoles { get; set; }
    }
}
