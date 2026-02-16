using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _NavbarAdminLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
