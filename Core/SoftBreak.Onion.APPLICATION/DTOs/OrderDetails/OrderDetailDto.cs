using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.DTOs.OrderDetails
{
    public class OrderDetailDto : BaseDto
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
