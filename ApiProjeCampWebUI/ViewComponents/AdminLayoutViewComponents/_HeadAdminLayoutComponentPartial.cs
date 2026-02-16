using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.ViewComponents.AdminLayoutViewComponents
{
    public class _HeadAdminLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
