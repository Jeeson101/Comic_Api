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

		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> Index(string heroName)
		{
			if (string.IsNullOrEmpty(heroName))
			{
				// Handle empty input
				return RedirectToAction(nameof(Index));
			}

			var comicVineApi = new ComicVineApi(); // Create an instance of ComicVineApi
			var superheroComics = await comicVineApi.SearchHero(heroName);
            if (superheroComics._responseVolume.Length == 0)
            {
	            superheroComics._response.error = "NotFound";
            }

			// Pass the retrieved data to the view
			return View(superheroComics);
		}
		[HttpGet]
		public IActionResult Movie()
		{
			return View();
		}

		[HttpPost, ValidateAntiForgeryToken]
		public async Task<IActionResult> Movie(string MovieName)
		{
			if (string.IsNullOrEmpty(MovieName))
			{
				// Handle empty input
				return RedirectToAction(nameof(Movie));
			}

			var comicVineApi = new ComicVineApi(); // Create an instance of ComicVineApi
			var SuperheroMovies = await comicVineApi.GetMovie(MovieName);


			// Pass the retrieved data to the view
			return View(SuperheroMovies);
		}
	}
}