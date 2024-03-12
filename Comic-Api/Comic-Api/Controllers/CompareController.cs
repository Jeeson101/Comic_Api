using Comic_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Comic_Api.Controllers
{
	public class CompareController : Controller
	{
		private List<Hero> heroes;
		private List<Hero> comparedHeroes;

		public CompareController()
		{
			string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "heroes.json");
			string json = System.IO.File.ReadAllText(jsonFilePath);
			heroes = JsonSerializer.Deserialize<List<Hero>>(json);
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(string query, int pos)
		{
			if (string.IsNullOrEmpty(query))
			{
				ViewBag.ErrorMessage = "Search a hero please.";
				return View();
			}



			query = query.ToLower();
			query = query.TrimStart();
			query = query.TrimEnd();

			comparedHeroes[pos] = heroes.FirstOrDefault(h => h.name.ToLower() == query);

			if (comparedHeroes == null)
			{
				ViewBag.ErrorMessage = "No results found.";
			}

			return View(comparedHeroes);
		}

	}
}
