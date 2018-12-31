using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pertamina.LPG.API.DTOs.Reports;
using Pertamina.LPG.API.Models;

namespace Pertamina.LPG.API.Services.Helpers
{
    public class ReportsHelper
    {
        public static void CopyFromEntity(GetProductsDto dto, Product product)
        {
            dto.product_id = product.ProdID;
            dto.product_name = product.ProductName;
        }
        public static void CopyFromEntity(GetAgencyNameDto dto, Agency agency)
        {
            dto.agency_id = agency.AgenID;
            dto.agency_name = agency.AgencyName;
        }
    }
}
