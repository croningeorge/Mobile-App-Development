﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Agent
{
    public class GetAgentAdminDetailsResponse : ResponseDto
    {
        public AgentAdminDetailsDto agent_admin_details { get; set; }
    }
}