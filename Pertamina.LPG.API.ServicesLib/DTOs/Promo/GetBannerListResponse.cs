using Pertamina.LPG.API.DTOs;
using Pertamina.LPG.API.DTOs.Promo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Promo
{
    public class GetBannerListResponse : ResponseDto
    {
        public BannerDto[] banners { get; set; }
    }
}