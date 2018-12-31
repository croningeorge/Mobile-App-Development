using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pertamina.LPG.API.DTOs.Gen
{
    public class FAQDto
    {
        public int faq_id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
    }
}