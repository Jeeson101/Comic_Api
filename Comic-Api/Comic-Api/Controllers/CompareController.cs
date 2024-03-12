using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers
{
	public class CompareController : Controller
	{
		[HttpGet, HttpPost]
		public IActionResult Index()
		{
			return View();
		}


	}
}
