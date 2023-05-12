using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutPageValuePartial:ViewComponent

    {
        private readonly IAboutPageValueService _aboutPageValueService;

        public _AboutPageValuePartial(IAboutPageValueService aboutPageValueService)
        {
            _aboutPageValueService = aboutPageValueService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutPageValueService.TGetList();
            return View(values);
        }
    }
}
