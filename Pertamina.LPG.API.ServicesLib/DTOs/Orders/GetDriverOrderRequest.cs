﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetDriverOrderRequest
    {
        public int user_id { get; set; }
        public int order_id { get; set; }
        public string auth_token { get; set; }
        public string order_type { get; set; }
    }
}
