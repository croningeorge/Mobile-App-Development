﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Users
{
    public class NewUserDto
    {
        public int user_id { get; set; }
        public int send_otp { get; set; }
        public string auth_token { get; set; }
    }
}