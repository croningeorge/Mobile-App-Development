﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.SuperUser
{
    public class ResendOtpResponseSuperUser : ResponseDto
    {
        public OtpDetailsDto otp_details { get; set; }
    }
}