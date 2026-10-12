using SoftBreak.Onion.APPLICATION.DTOs.Orders;
using SoftBreak.Onion.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.Managers
{
    public interface IOrderManager: IManager<Order, OrderDto>
    {
    }
}
