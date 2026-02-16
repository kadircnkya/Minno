using Microsoft.AspNetCore.Mvc;

namespace ApiProjeCampWebUI.ViewComponents
{
    public class _FeatureDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
        
        return View();
        }
    }
}
