using Comic_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Comic_Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Main();
            return View();
        }


   //     static async Task Main()
   //     {
   //         string sUrl = AppDomain.CurrentDomain.BaseDirectory;

   //         HttpClient client = new HttpClient();

   //         string sAPIUrl = "https://cdn.jsdelivr.net/gh/akabab/superhero-api@0.3.0/api/all.json";

   //         string sHero = await client.GetStringAsync(sAPIUrl);

   //         List<Hero> heroes = JsonSerializer.Deserialize<List<Hero>>(sHero);

			//foreach (Hero hero in heroes)
   //         {
   //             hero.name = hero.name.ToLower();
   //         }

   //         // Write the list to a JSON file
   //         string jsonFilePath = "heroes.json";
   //         await WriteToJsonFile(jsonFilePath, heroes);

   //         Console.WriteLine("JSON file has been created successfully.");
   //     }

   //     static async Task WriteToJsonFile<T>(string filePath, T data)
   //     {
   //         using (StreamWriter sw = new StreamWriter(filePath))
   //         {
   //             await JsonSerializer.SerializeAsync(sw.BaseStream, data);
   //         }
   //     }

    }
}
