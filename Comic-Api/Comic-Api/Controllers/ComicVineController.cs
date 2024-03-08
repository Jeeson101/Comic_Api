using Comic_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers;

public class ComicVineController : Controller
{
    // GET
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost, ValidateAntiForgeryToken]
    public ActionResult index(SuperHeroName sn)
    {
        ComicVineApi api = new ComicVineApi();
       String s = api.SearchHero(sn.naam).ToString();
       sn.naam = s;
       return View(sn);
    }
}