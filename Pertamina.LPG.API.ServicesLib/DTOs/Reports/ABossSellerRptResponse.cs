﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Reports
{
    public class ABossSellerRptResponse :ResponseDto
    {
        public List<ABossSellerRptDto> sales_details { get; set; }
    }
}
