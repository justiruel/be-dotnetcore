using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace VDI.Demo.Web.Controllers
{
    public class HomeController : DemoControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
