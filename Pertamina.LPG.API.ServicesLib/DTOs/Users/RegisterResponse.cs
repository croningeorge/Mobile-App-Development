using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Users
{
    public class RegisterResponse : ResponseDto
    {
        public NewUserDto new_user { get; set; }
    }
}