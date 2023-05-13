using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutPageEntrancePartial:ViewComponent
    {
        private readonly IAboutPageEntranceService _aboutPageEntranceService;

        public _AboutPageEntrancePartial(IAboutPageEntranceService aboutPageEntranceService)
        {
            _aboutPageEntranceService = aboutPageEntranceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutPageEntranceService.TGetList();
            return View(values); 
        }
    }
}
