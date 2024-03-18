using Comic_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Xml.Linq;

namespace Comic_Api.Controllers
{
	public class CompareController : Controller
	{
		private List<Hero> heroes;
		private static List<Hero> comparedHeroes = new List<Hero>();
		private HeroListsViewModel viewModel = new HeroListsViewModel();

		public CompareController()
		{
			string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "heroes.json");
			string json = System.IO.File.ReadAllText(jsonFilePath);
			heroes = JsonSerializer.Deserialize<List<Hero>>(json);


		}

		[HttpGet]
		public IActionResult Index()
		{
			fill();
			return View(viewModel);
		}
        
		[HttpPost]
		public IActionResult Index(int id)
		{


			if (comparedHeroes.Count == 2)
			{
				ViewBag.ErrorMessage = "You can only compare up to two heroes. \n Clear the heroes or compare them";
				fill(); 
				return View(viewModel);
			}

			var results = heroes.Where(h => h.id.Equals(id));


            comparedHeroes.AddRange(results);
			//return RedirectToAction("Index"); 
			fill();


			return View(viewModel);
		}

		[HttpGet]
		public IActionResult Compare()
		{
			return View(comparedHeroes);
		}

		public IActionResult Clear()
		{
			comparedHeroes.Clear();
			fill();
			return View("Index", viewModel);
		}

		private void fill()
		{
			viewModel.HeroesList1 = heroes;
			viewModel.HeroesList2 = comparedHeroes;
		}

	}
}
