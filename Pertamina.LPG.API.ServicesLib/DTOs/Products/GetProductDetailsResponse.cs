using Pertamina.LPG.API.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Product
{
    public class GetProductDetailsResponse : ResponseDto
    {
        public ProductDetailsDto product_details { get; set; }
    }
}