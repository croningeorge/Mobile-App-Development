﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class DriverOrderDetailsDto
    {
        public int order_id { get; set; }
        public string invoice_number { get; set; }
        public string order_date { get; set; }
        public string consumer_name { get; set; }
        public string consumer_mobile { get; set; }
        public string consumer_address { get; set; }
        public string order_type { get; set; }
        public string order_time { get; set; }
        public decimal grand_total { get; set; }
        public int delivery_timeslot_id { get; set; }

    }
}
