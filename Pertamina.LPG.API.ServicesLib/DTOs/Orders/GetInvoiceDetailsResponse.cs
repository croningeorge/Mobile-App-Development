using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetInvoiceDetailsResponse : ResponseDto
    {
        public OrderInvoiceDto orders { get; set; }
    }
}