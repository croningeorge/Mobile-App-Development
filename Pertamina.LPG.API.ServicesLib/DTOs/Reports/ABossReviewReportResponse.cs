﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Reports
{
    public class ABossReviewReportResponse : ResponseDto
    {
        public List<ABossReviewReportDto> service_rating { get; set; }
    }
}
