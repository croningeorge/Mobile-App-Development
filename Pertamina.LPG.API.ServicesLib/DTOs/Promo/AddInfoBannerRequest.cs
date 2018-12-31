﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Promo
{
    public class AddInfoBannerRequest
    {
        public int suser_id { get; set; }
        public string auth_token { get; set; }
        public string caption { get; set; }
        public string image_name { get; set; }
        public int position { get; set; }
        public int status_id { get; set; }
    }
}