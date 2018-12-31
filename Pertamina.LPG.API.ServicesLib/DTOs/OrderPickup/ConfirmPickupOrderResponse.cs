using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pertamina.LPG.API.DTOs.Orders;

namespace Pertamina.LPG.API.DTOs.OrderPickup
{
    public class ConfirmPickupOrderResponse : ResponseDto
    {
        public PickupOrderDto orders { get; set; }
    }
}