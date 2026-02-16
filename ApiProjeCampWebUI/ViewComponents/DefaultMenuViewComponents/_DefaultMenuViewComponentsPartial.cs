using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.ViewComponents.DefaultMenuViewComponents
{
    public class _DefaultMenuViewComponentsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
