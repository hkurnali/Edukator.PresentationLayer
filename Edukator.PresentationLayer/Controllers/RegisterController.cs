using Edukator.DataAccesLayer.Concrete;
using Edukator.DataAccesLayer.Migrations;
using Edukator.EntityLayer.Concrete;
using Edukator.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Edukator.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
		
           private readonly UserManager<AddUser> _userManager;

		public RegisterController(UserManager<AddUser> userManager)
		{
			_userManager = userManager;
		}

		

		[HttpGet]
		public IActionResult Index()
        {  
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Index(RegisterViewModel model)
        {
          AddUser adduser = new AddUser()
            {
               Name= model.Name,
               SUrname=model.Surname,
               Ctiy=model.City,
               Email=model.Email,
               UserName=model.Username

            };
            var result =await _userManager.CreateAsync(adduser,model.Password);
            if(result.Succeeded) 
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

            }
            return View();
		}
        
        
       
    }
}
