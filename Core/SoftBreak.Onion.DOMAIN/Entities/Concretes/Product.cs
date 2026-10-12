using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Concretes
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }

        //Releational Properties
        public virtual Catregories Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
