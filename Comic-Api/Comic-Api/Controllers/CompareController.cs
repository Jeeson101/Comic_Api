using Comic_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

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
				ViewBag.ErrorMessage = "You can only compare up to two heroes. Clear the heroes or compare them";
				fill();
				return View(viewModel);
			}

			if (comparedHeroes.Any(h => h.id == id))
			{
				ViewBag.ErrorMessage = "You can't compare the same hero";
				fill();
				return View(viewModel);
			}

			var result = heroes.FirstOrDefault(h => h.id == id);
			if (result != null)
			{
				comparedHeroes.Add(result);
				fill();
			}

			return View(viewModel);
		}

		[HttpGet]
		public IActionResult Compare()
		{
			return View(comparedHeroes);
		}

		[HttpPost]
		public IActionResult Search(string query)
		{
			if (string.IsNullOrWhiteSpace(query))
			{
				var originalHeroesHtml = GenerateHeroesHtml(heroes);
				return Content(originalHeroesHtml, "text/html");
			}

			var results = heroes.Where(h => h.name.ToLower().Contains(query.ToLower())).ToList();
			var searchResultsHtml = GenerateHeroesHtml(results);

			return Content(searchResultsHtml, "text/html");
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


		private string GenerateHeroesHtml(List<Hero> heroesList)
		{
			StringBuilder htmlBuilder = new StringBuilder();
			foreach (var hero in heroesList)
			{
				htmlBuilder.Append("<div class=\"character\">");
				htmlBuilder.Append("<form method=\"post\" action=\"/Compare/Index\" id=\"compareForm\">");
				htmlBuilder.Append($"<input type=\"hidden\" id=\"heroId\" name=\"id\" value=\"{hero.id}\">");
				htmlBuilder.Append("<button type=\"button\" class=\"characterButton\" onclick=\"selectCharacter(" + hero.id + ")\">");
				htmlBuilder.Append($"<h2>{char.ToUpper(hero.name[0]) + hero.name.Substring(1)}</h2>");
				htmlBuilder.Append($"<img src=\"{hero.images.xs}\" alt=\"{hero.name}\" class=\"img-fluid\">");
				htmlBuilder.Append("</button>");
				htmlBuilder.Append("</form>");
				htmlBuilder.Append("</div>");
			}
			return htmlBuilder.ToString();
		}
	}
}
