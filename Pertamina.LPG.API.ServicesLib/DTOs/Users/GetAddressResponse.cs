using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Users
{
    public class GetAddressResponse : ResponseDto
    {
        public UserAddressesDto user_address { get; set; }
    }
}