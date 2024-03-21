using Comic_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Comic_Api.Controllers
{
    public class AlignmentController : Controller
    {
        private List<Hero> heroes;
        private AlignmentListModel viewModel = new AlignmentListModel();

        public AlignmentController()
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "heroes.json");
            string json = System.IO.File.ReadAllText(jsonFilePath);
            heroes = JsonSerializer.Deserialize<List<Hero>>(json);

            viewModel.Publishers = heroes.Select(h => h.biography.publisher).Distinct().ToList();
            Fill();
        }

        public IActionResult Index()
        {
            ViewBag.GoodColor = "blue";
            ViewBag.NeutralColor = "gray";
            ViewBag.BadColor = "red";

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult FilterHeroes(string publisher)
        {
            if (string.IsNullOrEmpty(publisher))
            {
                Fill();
            }
            else
            {
                viewModel.GoodHeroList = heroes.Where(h => h.biography.publisher == publisher && h.biography.alignment == "good").ToList();
                viewModel.BadHeroList = heroes.Where(h => h.biography.publisher == publisher && h.biography.alignment == "bad").ToList();
                viewModel.NeutralHeroList = heroes.Where(h => h.biography.publisher == publisher && h.biography.alignment == "-").ToList();
            }

            ViewBag.GoodColor = "blue";
            ViewBag.NeutralColor = "gray";
            ViewBag.BadColor = "red";

            return View("Index", viewModel);
        }

        private void Fill()
        {
            viewModel.GoodHeroList = heroes.Where(h => h.biography.alignment == "good").ToList();
            viewModel.BadHeroList = heroes.Where(h => h.biography.alignment == "bad").ToList();
            viewModel.NeutralHeroList = heroes.Where(h => h.biography.alignment == "-").ToList();
        }
    }
}
