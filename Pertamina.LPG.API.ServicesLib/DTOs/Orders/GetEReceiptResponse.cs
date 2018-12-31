using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetEReceiptResponse : ResponseDto
    {
        public OrderInvoiceDto orders { get; set; }        
    }
}
