using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
