using Microsoft.AspNetCore.Mvc;

namespace Comic_Api.Controllers;

public class ComicVineController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}