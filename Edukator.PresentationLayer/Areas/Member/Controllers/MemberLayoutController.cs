using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberLayoutController : Controller
    {
        private readonly UserManager<AddUser> _userManager;

        public MemberLayoutController(UserManager<AddUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = values.Name + " " + values.SUrname;
            return View();
        }
        public async Task<PartialViewResult> MemberSideBarPartial()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = values.Name + " " + values.SUrname;
            return PartialView();
        }
    }
}
