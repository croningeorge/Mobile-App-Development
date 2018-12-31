using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetDriverOrderListResponse : ResponseDto
    {
        public int order_count { get; set; }
        public DriverOrderDetailsDto[] order_details { get; set; }
    }
}
