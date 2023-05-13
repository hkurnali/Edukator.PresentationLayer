using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.ContactPage
{
    public class _ContactPagePartial:ViewComponent
    {  public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
