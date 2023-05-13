using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class ContactPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
