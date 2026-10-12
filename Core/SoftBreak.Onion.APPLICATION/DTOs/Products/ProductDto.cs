using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.DTOs.Products
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
    }
}
