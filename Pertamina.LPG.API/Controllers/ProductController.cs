using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pertamina.LPG.API.DTOs;
using Pertamina.LPG.API.DTOs.Product;
using System.Web.Http;
using System.Web.Http.Results;
using System.Net;
using Pertamina.LPG.API.Services;

namespace Pertamina.LPG.API.Controllers
{
    public class ProductController : ApiController
    {
        private ProductServices _productServices = new ProductServices();

        [HttpPost]
        [ActionName("get_product_list")]
        public NegotiatedContentResult<GetProductListResponse> PostGetProductList([FromBody]GetProductListRequest request)
        {
            GetProductListResponse resp = _productServices.GetProductList(request);
            return Content(HttpStatusCode.OK, resp);
        }

        [HttpPost]
        [ActionName("get_product_details")]
        public NegotiatedContentResult<GetProductDetailsResponse> PostGetProductDetails([FromBody]GetProductDetailsRequest request)
        {
            GetProductDetailsResponse resp = _productServices.GetProductDetails(request);
            return Content(HttpStatusCode.OK, resp);
        }
    }
}