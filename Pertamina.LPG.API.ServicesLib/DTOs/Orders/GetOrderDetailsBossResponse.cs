﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetOrderDetailsBossResponse : ResponseDto
    {
        public OrderFullDetailsBossDto order_details { get; set; }
    }
}
