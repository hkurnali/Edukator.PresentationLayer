using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    { private readonly IFooterService _footerService;

        public _FooterPartial(IFooterService footerService)
        {
            _footerService = footerService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_footerService.TGetList();
            return View(values);
            
        }
    }
}
