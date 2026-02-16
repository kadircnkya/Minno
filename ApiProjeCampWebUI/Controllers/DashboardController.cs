using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
