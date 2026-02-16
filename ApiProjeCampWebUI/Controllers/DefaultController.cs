using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
