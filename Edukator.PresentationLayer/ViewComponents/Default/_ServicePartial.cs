﻿using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _ServicePartial:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _ServicePartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_serviceService.TGetList();
            return View(values);
        }
    }
}
