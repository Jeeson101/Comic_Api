using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
