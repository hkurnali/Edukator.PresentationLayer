using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _SocialMediaPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _SocialMediaPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetList();
            return View(values);
        }
    }
}
