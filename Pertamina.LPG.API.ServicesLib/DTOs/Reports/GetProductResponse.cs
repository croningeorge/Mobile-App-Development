﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Reports
{
    public class GetProductResponse : ResponseDto
    {       
        public List<GetProductsDto> product_names { get; set; }
    }
}
