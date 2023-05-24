using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class ProfilController : Controller
    {
        private readonly UserManager<AddUser> _userManager;

        public ProfilController(UserManager<AddUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {  var values=await _userManager.FindByNameAsync(User.Identity.Name);  
            return View(values);
        }
    }
}
    