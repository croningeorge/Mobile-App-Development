﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Gen
{
    public class GetContactResponse : ResponseDto
    {
        public ContactDto contact_details { get; set; }
    }
}
