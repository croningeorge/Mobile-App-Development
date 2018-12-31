using Pertamina.LPG.API.DTOs.TeleOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.TeleOrder
{
    public class AddTeleOrderResponse : ResponseDto
    {
        public TeleOrderDto order_details { get; set; }
    }
}