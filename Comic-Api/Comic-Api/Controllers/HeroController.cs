using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Comic_Api.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers
{
	public class HeroController : Controller
	{
		private List<Hero> heroes;

		public HeroController()
		{
			// Load heroes from JSON file
			string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "heroes.json");
			string json = System.IO.File.ReadAllText(jsonFilePath);
			heroes = JsonSerializer.Deserialize<List<Hero>>(json);
		}

		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Search(string query)
		{
			List<Hero> results = new List<Hero>(); // Initialize a list to hold the search results

			if (!string.IsNullOrEmpty(query))
			{
				results = heroes.Where(h => h.name.Contains(query)).ToList();
			}

			return View(results);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult SearchPost(string query)
		{
			var results = heroes.Where(h => h.name == (query.ToLower())).ToList();

			if (results.Any())
			{
				return View("Search", results);
			}
			else if (!string.IsNullOrEmpty(query))
			{
				ViewBag.ErrorMessage = "No results found.";
			}

			return View("Search");
		}
	}
}
