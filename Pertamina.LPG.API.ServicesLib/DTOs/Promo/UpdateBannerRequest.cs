﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Promo
{
    public class UpdateBannerRequest
    {
        public int suser_id { get; set; }
        public string auth_token { get; set; }
        public int banner_id { get; set; }
        public string caption { get; set; }
        public string image_name { get; set; }
        public int category { get; set; }
        public int status_id { get; set; }
    }
}