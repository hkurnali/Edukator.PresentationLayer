using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutPageTeamPartial:ViewComponent
    {
        private readonly IAboutPageTeamService _aboutPageTeamService;

        public _AboutPageTeamPartial(IAboutPageTeamService aboutPageTeamService)
        {
            _aboutPageTeamService = aboutPageTeamService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_aboutPageTeamService.TGetList();
            return View(values);

        }
    }
}
