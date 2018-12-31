using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pertamina.LPG.API.DTOs.Driver;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetDriverListResponse : ResponseDto
    {
        public List<DriverDetailListDto> driver_details { get; set; }
    }
}
