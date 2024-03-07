using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Comic_Api.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
             return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
