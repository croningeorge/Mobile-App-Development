﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Driver
{
    public class ChangePasswordDriverRequest
    {
        public int user_id { get; set; }
        public string auth_token { get; set; }
        public string old_password { get; set; }
        public string new_password { get; set; }
    }
}
