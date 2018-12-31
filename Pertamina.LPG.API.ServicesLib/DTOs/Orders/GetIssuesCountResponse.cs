using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertamina.LPG.API.DTOs.Orders
{
    public class GetIssuesCountResponse:ResponseDto
    {
        public IssueCountDto issues { get; set; }
    }
}
