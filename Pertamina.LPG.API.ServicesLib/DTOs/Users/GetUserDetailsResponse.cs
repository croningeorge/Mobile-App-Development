using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Users
{
    public class GetUserDetailsResponse : ResponseDto
    {
        public UserDetailsDto user_details { get; set; }
    }
}