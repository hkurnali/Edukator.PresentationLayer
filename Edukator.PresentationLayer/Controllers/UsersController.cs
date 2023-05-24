using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.Controllers
{
    public class UsersController : Controller
    { private readonly UserManager<AddUser> _userManager;

        public UsersController(UserManager<AddUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
    }
}
