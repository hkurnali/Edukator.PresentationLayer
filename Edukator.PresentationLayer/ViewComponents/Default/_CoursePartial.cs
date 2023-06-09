﻿using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{      
    public class _CoursePartial:ViewComponent
    {
        private readonly ICourseService _courseService;

        public _CoursePartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetCoursesWithCategories();
            return View(values);
        }
    }
}
