﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Reports
{
    public class GetAgencyNameResponse : ResponseDto
    {
     
        public List<GetAgencyNameDto> agency_names { get; set; }
    }
}
