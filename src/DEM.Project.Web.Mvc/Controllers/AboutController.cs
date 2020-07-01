using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using DEM.Project.Controllers;

namespace DEM.Project.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
