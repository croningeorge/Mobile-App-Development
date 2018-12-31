using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Agent
{
    public class ForgotPasswordResponseAgentAdmin : ResponseDto
    {
        public ResetPasswordDto reset_password { get; set; }
    }
}