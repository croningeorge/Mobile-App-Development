﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Reports
{
    public class SUserReviewReasonRequest : AuthBase
    {
        public int periodical_data { get; set; }
        public int agency_id { get; set; }
    }
}
