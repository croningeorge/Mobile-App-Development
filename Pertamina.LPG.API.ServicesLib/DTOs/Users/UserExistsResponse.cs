using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Users
{
    public class UserExistsResponse : ResponseDto
    {
        public UserStatusDto user_status { get; set; }
    }
}