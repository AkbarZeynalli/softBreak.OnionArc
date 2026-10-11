using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.DOMAIN.Entities.Concretes
{
    public class OrderDetail : BaseEntity
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        //Releational Properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
