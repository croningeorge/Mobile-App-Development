﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetIssuesListRequest
    {
        public int user_id { get; set; }
        public string auth_token { get; set; }
    }
}
