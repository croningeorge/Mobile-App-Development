﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Agent
{
    public class ResetPasswordRequest
    {
        public string mobile_number { get; set; }
        public string new_password { get; set; }
        public string confirm_password { get; set; }
    }
}
