using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetDriverListForAgentAdminResponse : ResponseDto
    {
        public List<AllDriversForAdmin> driver_details { get; set; }
    }
}
