﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.SuperUser
{
   public class SuperUserDetailsDto
    {
        public int super_user_id { get; set; }
        public string profile_image { get; set; }
        public string super_user_name { get; set; }
        public string mobile_number { get; set; }
        public string super_user_email { get; set; }
    }
}
