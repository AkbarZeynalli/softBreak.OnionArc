using SoftBreak.Onion.APPLICATION.DTOs.OrderDetails;
using SoftBreak.Onion.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.Managers
{
    public interface IOrderDetailManager : IManager<OrderDetail, OrderDetailDto>
    {
    }
}
