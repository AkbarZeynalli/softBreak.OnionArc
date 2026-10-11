using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Concretes
{
    public class Catregories : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Releational Properties
        public virtual ICollection<Product> Products { get; set; }
    }
}
