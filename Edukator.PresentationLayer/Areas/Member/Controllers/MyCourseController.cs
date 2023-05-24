using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[action]")]
    public class MyCourseController : Controller
    { 
        private readonly ICourseRegisterService _courseRegisterService;
        private readonly UserManager<AddUser> _userManager;

        public MyCourseController(ICourseRegisterService courseRegisterService, UserManager<AddUser> userManager)
        {
            _courseRegisterService = courseRegisterService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var values2 = _courseRegisterService.TCourseRegisterListWithCourseByUser(values.Id);
            return View(values2);
        }
        [HttpGet]
        public IActionResult Register(int id)
        {
            List<SelectListItem> values = (from x in _courseRegisterService.TCourseRegisterListWithCoursesAndUsers()
                                           select new SelectListItem
                                           {
                                               Text = x.Course.Title,
                                               Value = x.CourseID.ToString()
                                           }).ToList();
            //var values1 = _courseRegisterService.TGetByID(id);
            ViewBag.v = values;
            
            return View();
        }
        [HttpPost]
        public IActionResult Register(CourseRegister p)
        {
            var per = _courseRegisterService.TCourseRegisterListWithCoursesAndUsers().Where(x => x.CourseID == p.Course.CourseID).FirstOrDefault();
          p.CourseID = per.Course.CourseID;
            
            return RedirectToAction("Index");
        }

        
       
    }
}
