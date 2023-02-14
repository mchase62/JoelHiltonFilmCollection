using JoelHiltonFilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonFilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext _blahContext { get; set; }
        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {
            _blahContext.Add(fr);
            _blahContext.SaveChanges();
            return View("Confirmation", fr);
        }
        
        public IActionResult Podcasts()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
