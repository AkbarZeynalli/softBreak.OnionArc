using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.DTOs.Orders
{
    public class OrderDto : BaseDto
    {
        public string ShippingAddress { get; set; }
        public int? AppUserId { get; set; }
    }
}
 