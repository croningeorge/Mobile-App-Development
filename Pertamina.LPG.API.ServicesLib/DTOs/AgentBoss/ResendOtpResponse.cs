﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.AgentBoss
{
    public class ResendOtpResponseAgentBoss : ResponseDto
    {
        public OtpDetailsDto otp_details { get; set; }
    }
}
