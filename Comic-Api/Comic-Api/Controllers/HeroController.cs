using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Comic_Api.Models;
using Comic_Api.Models.DB;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers
{
	public class HeroController : Controller
	{
		private List<Hero> heroes;

		public HeroController()
		{
			string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "heroes.json");
			string json = System.IO.File.ReadAllText(jsonFilePath);
			heroes = JsonSerializer.Deserialize<List<Hero>>(json);
		}


		[HttpGet]
		public ActionResult Search(string query)
		{
			List<Hero> results = new List<Hero>();

			if (string.IsNullOrEmpty(query))
			{
				ViewBag.ErrorMessage = "Search a hero please.";
				return View(results);
			}

			if (!string.IsNullOrEmpty(query))
			{
				results = heroes.Where(h => h.name.Contains(query)).ToList();
			}

			return View(results);
		}

		[HttpGet]
		public ActionResult SearchEmpty()
		{
			if (string.IsNullOrEmpty(Request.Cookies["UserID"]))
			{

			}
			else
			{
				String UserIDS = Request.Cookies["UserID"];
				int UserID = Convert.ToInt32(UserIDS);

				FavoriteSuperheroDB DB = new FavoriteSuperheroDB();
				var listFavvanUser = DB.GetFavoriteSuperheroesByUserID(UserID);
				ViewBag.ListFavs = listFavvanUser;
			}

			string query = TempData["SearchQuery"] as string;

			List<Hero> results = new List<Hero>();

			if (string.IsNullOrEmpty(query))
			{
				return RedirectToAction("Search");
			}

			query = query.ToLower();
			query = query.TrimStart();
			query = query.TrimEnd();

			var exactMatches = heroes.Where(h => h.name.ToLower() == query).ToList();
			results.AddRange(exactMatches);

			if (exactMatches.Count == 0)
			{
				var KoppeltekenQuery = query.Replace(" ", "-");
				var nietKoppeltekenQuery = query.Replace("-", " ");

				var KoppeltekenMatch = heroes.Where(h => h.name.ToLower() == KoppeltekenQuery).ToList();
				results.AddRange(KoppeltekenMatch);

				if (KoppeltekenMatch.Count == 0)
				{
					var nietKoppeltekenMatch = heroes.Where(h => h.name.ToLower() == nietKoppeltekenQuery).ToList();
					results.AddRange(nietKoppeltekenMatch);

					if (nietKoppeltekenMatch.Count == 0)
					{
						results.AddRange(heroes.Where(h => h.name.ToLower().Contains(query)).ToList());
					}
				}
			}

			if (results.Count == 0)
			{
				ViewBag.ErrorMessage = "No results found.";
			}

			return View("Search", results);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult SearchPost(string query)
		{

			if (string.IsNullOrEmpty(Request.Cookies["UserID"]))
			{

			}
			else
			{
				String UserIDS = Request.Cookies["UserID"];
				int UserID = Convert.ToInt32(UserIDS);

				FavoriteSuperheroDB DB = new FavoriteSuperheroDB();
				var listFavvanUser = DB.GetFavoriteSuperheroesByUserID(UserID);
				ViewBag.ListFavs = listFavvanUser;
			}

			List<Hero> results = new List<Hero>();

			if (string.IsNullOrEmpty(query))
			{
				return RedirectToAction("Search");
			}

			query = query.ToLower();
			query = query.TrimStart();
			query = query.TrimEnd();

			var exactMatches = heroes.Where(h => h.name.ToLower() == query).ToList();
			results.AddRange(exactMatches);

			if (exactMatches.Count == 0)
			{
				var KoppeltekenQuery = query.Replace(" ", "-");
				var nietKoppeltekenQuery = query.Replace("-", " ");

				var KoppeltekenMatch = heroes.Where(h => h.name.ToLower() == KoppeltekenQuery).ToList();
				results.AddRange(KoppeltekenMatch);

				if (KoppeltekenMatch.Count == 0)
				{
					var nietKoppeltekenMatch = heroes.Where(h => h.name.ToLower() == nietKoppeltekenQuery).ToList();
					results.AddRange(nietKoppeltekenMatch);

					if (nietKoppeltekenMatch.Count == 0)
					{
						results.AddRange(heroes.Where(h => h.name.ToLower().Contains(query)).ToList());
					}
				}
			}

			if (results.Count == 0)
			{
				ViewBag.ErrorMessage = "No results found.";
			}

			return View("Search", results);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult SearchPost2(string query, int ID, bool Bool)
		{
			TempData["SearchQuery"] = query;
			if (string.IsNullOrEmpty(Request.Cookies["UserID"]))
			{
				ViewBag.ErrorMessage = "You must be logged in.";
				return RedirectToAction("SearchEmpty");
			}
			else
			{
				String UserIDS = Request.Cookies["UserID"];
				int UserID = Convert.ToInt32(UserIDS);

				FavoriteSuperheroDB DB = new FavoriteSuperheroDB();
				var listFavvanUser = DB.GetFavoriteSuperheroesByUserID(UserID);
				ViewBag.ListFavs = listFavvanUser;


				if (!Bool)
				{
					DB.AddFavoriteSuperhero(UserID, ID);
				}
				else
				{
					DB.RemoveFavoriteSuperhero(UserID, ID);
					//ViewBag.ErrorMessage = "Je zal deze unfavoriten";
				}

				return RedirectToAction("SearchEmpty");
			}
		}

		public ActionResult SearchFavoriteHeroesOnID()
		{
			if (string.IsNullOrEmpty(Request.Cookies["UserID"]))
			{
				ViewBag.ErrorMessage = "You need to be logged in.";
				return View("Search");
			}
			else
			{
				String UserIDS = Request.Cookies["UserID"];
				int UserID = Convert.ToInt32(UserIDS);

				FavoriteSuperheroDB DB = new FavoriteSuperheroDB();
				var listFavvanUser = DB.GetFavoriteSuperheroesByUserID(UserID);
				ViewBag.ListFavs = listFavvanUser;


				List<Hero> results = new List<Hero>();


				foreach (Hero h in heroes)
				{
					foreach (FavoriteSuperhero s in listFavvanUser)
					{
						if (h.id == s.SuperheroID)
						{
							results.Add(h);
						}
					}
					
				}

			
				return View("Search",results);
			}

			


			
		}
	}
}
