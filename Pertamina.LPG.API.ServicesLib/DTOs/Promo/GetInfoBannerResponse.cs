using Pertamina.LPG.API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Promo
{
    public class GetInfoBannerResponse : ResponseDto
    {
        public int info_id { get; set; }
        public string caption { get; set; }
        public string image_name { get; set; }
        public int position { get; set; }
        public int status_id { get; set; }
    }
}