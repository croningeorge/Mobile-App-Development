﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Driver
{
    public class GetAgentDriverResponse : ResponseDto
    {
        public DriverDetailsDto driver_details { get; set; }
    }
}
