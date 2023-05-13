using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.CoursePage
{
    public class _ContactPageMessagePartial : ViewComponent
    { private readonly IContactPageMessageService _contactPageMessageService;

        public _ContactPageMessagePartial(IContactPageMessageService contactPageMessageService)
        {
            _contactPageMessageService = contactPageMessageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactPageMessageService.TGetList();
            return View(values);
        }
    }
    
}
