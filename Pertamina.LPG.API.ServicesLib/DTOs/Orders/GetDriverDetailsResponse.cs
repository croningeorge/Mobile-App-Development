using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetDriverDetailsResponse : ResponseDto
    {
        public DriverDetailsDto driver_details { get; set; }
    }
}