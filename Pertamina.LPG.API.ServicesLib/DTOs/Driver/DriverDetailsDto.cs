﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Driver
{
    public class DriverDetailsDto
    {
        public int driver_id { get; set; }
        public string profile_image { get; set; }
        public string driver_name { get; set; }
        public string mobile_number { get; set; }
    }
}
