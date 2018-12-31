using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetAllUnassignedOrdersResponse : ResponseDto
    {
        public ActiveOrdersDto active_orders { get; set; }
        public OrderFullDetailsDto[] orders { get; set; }
    }
}