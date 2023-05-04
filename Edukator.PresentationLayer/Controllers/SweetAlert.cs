using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
	public class SweetAlert : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
