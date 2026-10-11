using Microsoft.AspNetCore.Identity;
using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using SoftBreak.Onion.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Concretes
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DataStatus Status { get; set; }


        //Releational Properties
        public virtual AppUserProfile Profile { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
