using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetAssignedOrderCountResponse : ResponseDto
    {
        public AssignedOrderCountDto order { get; set; } 
    }
}
