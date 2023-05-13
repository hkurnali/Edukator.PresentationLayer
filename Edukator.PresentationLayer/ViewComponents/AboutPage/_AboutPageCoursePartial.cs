using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutPageCoursePartial:ViewComponent
    {
        private readonly IAboutPageCourseService _aboutPageCourseService;

        public _AboutPageCoursePartial(IAboutPageCourseService aboutPageCourseService)
        {
            _aboutPageCourseService = aboutPageCourseService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_aboutPageCourseService.TGetList();
            return View(values);
        }
    }
}
