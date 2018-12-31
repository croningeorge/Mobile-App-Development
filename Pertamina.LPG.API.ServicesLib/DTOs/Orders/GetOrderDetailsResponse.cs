using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetOrderDetailsResponse : ResponseDto
    {
        public OrderDetailsDto order_details { get; set; }
    }
}