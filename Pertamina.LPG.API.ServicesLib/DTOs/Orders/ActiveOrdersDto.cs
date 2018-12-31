using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class ActiveOrdersDto
    {
        public int active_order_count { get; set; }
        public int user_id { get; set; }
    }
}