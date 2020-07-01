using Abp.Extensions;
using Abp.WebApi.Controllers;
using DEM.Project.Common;
using DEM.Project.Products.Interface;
using Microsoft.AspNetCore.Cors;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace DEM.Project.Web.Host.Controllers
{
    [Route("api/product")]
    [EnableCors("AllowSpecificOrigin")]
    public class ProductController : AbpApiController
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Route("get-homepage")]
        public async Task<APIResult> Get(long id)
        {
            return new APIResult()
            {
                Result = 0,
                Data = await _productService.GetAll()
            };
        }
    }
}
