using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Agent
{
    public class LoginResponse : ResponseDto
    {
        public UserLoginDto user_login { get; set; }
    }
}