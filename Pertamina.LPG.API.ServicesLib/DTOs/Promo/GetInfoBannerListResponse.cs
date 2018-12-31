using Pertamina.LPG.API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Promo
{
    public class GetInfoBannerListResponse : ResponseDto
    {
        public InfoBannerListDto[] info_banners { get; set; }

    }
}