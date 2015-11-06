using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Ementor.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : EmentorControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}