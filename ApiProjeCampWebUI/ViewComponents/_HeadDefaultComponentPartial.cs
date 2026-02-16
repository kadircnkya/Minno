using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
