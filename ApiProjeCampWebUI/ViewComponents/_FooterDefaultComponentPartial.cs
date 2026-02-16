using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.ViewComponents
{
    public class _FooterDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
