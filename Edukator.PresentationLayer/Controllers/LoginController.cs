﻿using Edukator.EntityLayer.Concrete;
using Edukator.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AddUser> _signInManager;

        public LoginController(SignInManager<AddUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(LoginViewModel model)
        {  var result=await _signInManager.PasswordSignInAsync(model.Username, model.Password,false,false);
            
            if(result.Succeeded) 
            {
                return RedirectToAction("Index", "Course");
            
            
            }
            
            
            
            return View();
        }
    }
}