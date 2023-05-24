using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class RoleAssingnController : Controller
    {  private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AddUser> _userManager;

        public RoleAssingnController(RoleManager<AppRole> roleManager, UserManager<AddUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> RoleAssing(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles=_roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            return View();
        }
    }
}
