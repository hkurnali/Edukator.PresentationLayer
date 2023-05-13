using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class CoursePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
