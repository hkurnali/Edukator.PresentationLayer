using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.CoursePage
{
    public class _CoursePagePartial:ViewComponent

    {   

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
