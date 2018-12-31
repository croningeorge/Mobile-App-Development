using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pertamina.LPG.API.DTOs.Orders;

namespace Pertamina.LPG.API.DTOs.TeleOrder
{
    public class ConfirmTeleOrderResponse : ResponseDto
    {
        public TeleOrderFullDetailsDto orders { get; set; }
    }
}