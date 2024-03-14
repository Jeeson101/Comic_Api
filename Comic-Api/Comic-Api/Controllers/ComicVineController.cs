using Comic_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Ui.Mvc.Controllers
{
	public class ComicVineController : Controller
	{
		private ComicVineApi _comicVineApi;

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(string heroName)
		{
			if (string.IsNullOrEmpty(heroName))
			{
				// Handle empty input
				return RedirectToAction(nameof(Index));
			}

			var comicVineApi = new ComicVineApi(); // Create an instance of ComicVineApi
			var superheroComics = await comicVineApi.SearchHero(heroName);

			// Pass the retrieved data to the view
			return View(superheroComics);
		}
	}
}