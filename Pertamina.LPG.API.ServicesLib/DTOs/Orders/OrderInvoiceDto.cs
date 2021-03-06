﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class OrderInvoiceDto
    {
        public int order_id { get; set; }
        public string invoice_number { get; set; }
        public string order_date { get; set; }
        public TimeSpan order_time { get; set; }
        public string consumer_name { get; set; }
        public string consumer_mobile { get; set; }
        public string consumer_address { get; set; }
        public string consumer_location { get; set; }
        public string postal_code { get; set; }
        public int agency_id { get; set; }
        public string agency_name { get; set; }
        public string agency_address { get; set; }
        public string agency_location { get; set; }
        public ProductsDto[] products { get; set; }
        public decimal grand_total { get; set; }
        public decimal grand_discount { get; set; }
        public decimal grand_total_with_discount { get; set; }
        public int has_exchange { get; set; }
        public List<ExchangeDto> exchange { get; set; }
    }
}
