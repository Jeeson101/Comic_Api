using Comic_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers;

public class ComicVineController : Controller
{
	private readonly ComicVineApi _comicVineApi = new ComicVineApi();

	public ActionResult Index()
	{
		return View();
	}

	[HttpPost, ValidateAntiForgeryToken]
	public async Task<ActionResult> Index(string heroName)
	{
		if (string.IsNullOrEmpty(heroName))
		{
			ViewBag.Error = "Please enter a superhero name.";
			return View();
		}

		try
		{
			var result = await _comicVineApi.SearchHero(heroName);
			ViewBag.Result = result;
		}
		catch (Exception ex)
		{
			ViewBag.Error = $"An error occurred: {ex.Message}";
		}

		return View();
	}
}