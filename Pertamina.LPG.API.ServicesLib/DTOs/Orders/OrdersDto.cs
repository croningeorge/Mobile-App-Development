﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class OrdersDto
    {
        public OrgOrderListDto[] orders { get; set; }
    }
}