using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers
{
	public class CompareController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(string query)
		{

			return View();
		}
	}
}
