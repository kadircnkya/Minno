using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.ViewComponents.AdminLayoutNavbarViewComponents
{
    public class _NavbarFormInlineLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
