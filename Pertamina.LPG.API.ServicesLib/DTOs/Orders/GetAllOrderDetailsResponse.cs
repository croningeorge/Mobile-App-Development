﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetAllOrderDetailsResponse : ResponseDto
    {
        public List<AllOrderDetails> order_details { get; set; }        
    }
}
