using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutPagePartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
