using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Concretes
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //Releational Properties
        public virtual AppUserProfile Profile { get; set; }
    }
}
