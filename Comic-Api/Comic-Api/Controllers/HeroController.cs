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



		[HttpPost]
		public ActionResult Search(string query)
		{
			// Perform search
			var results = heroes.FindAll(h => h.name.Contains(query));

			if (results.Any())
			{
				return View(results);
			}
			else if (!string.IsNullOrEmpty(query))
			{
				ViewBag.ErrorMessage = "No results found.";
			}

			return View();
		}
	}
}
