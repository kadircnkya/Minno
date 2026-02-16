using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.ViewComponents
{
    public class _AboutDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
