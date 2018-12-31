using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Users
{
    public class GetAddressesResponse : ResponseDto
    {
        public List<UserAddressesDto> user_addresses { get; set; }
    }
}