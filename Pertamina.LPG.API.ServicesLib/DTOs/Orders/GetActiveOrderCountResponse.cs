using Pertamina.LPG.API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetActiveOrderCountResponse : ResponseDto
    {
        public ActiveOrdersDto active_orders { get; set; }
    }
}