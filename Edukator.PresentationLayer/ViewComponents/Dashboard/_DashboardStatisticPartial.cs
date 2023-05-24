﻿using Edukator.DataAccesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardStatisticPartial:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.totalCourseCount=context.Courses.Count();
            ViewBag.totalCategory=context.Categories.Count();
            ViewBag.totalMerberCount=context.Users.Count();
            ViewBag.messageBoxCount=context.Contacts.Count();

            return View();

        }
    }
}