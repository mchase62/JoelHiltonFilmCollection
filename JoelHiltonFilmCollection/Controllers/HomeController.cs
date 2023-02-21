using JoelHiltonFilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieContext movieContext { get; set; }

        //Constructor
        public HomeController(MovieContext someName)
        {
            movieContext = someName;
        }

        public IActionResult Index() // home page
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm ()
        {
            ViewBag.Categories = movieContext.Categories.ToList(); // automatically passes to view parameter
            return View(new FormResponse());
        }
        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {
            if(ModelState.IsValid)
            {
                movieContext.Add(fr); // add to movies
                movieContext.SaveChanges();
                return View("Confirmation", fr);
            }
            else
            {
                ViewBag.Categories = movieContext.Categories.ToList(); // automatically passes to view parameter
                return View(fr);
            }
        }
        
        public IActionResult Podcasts()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = movieContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Year)
                .ToList(); // our movie list
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = movieContext.Categories.ToList(); // automatically passes to view parameter, fills in the category drop down
            var form = movieContext.Responses.Single(x => x.FormId == id); // get the form id from the url, lets us choose which row
            return View("MovieForm", form);
        }

        [HttpPost] // in order to update the form with the data in the get view
        public IActionResult Edit (FormResponse fr)
        {
            movieContext.Update(fr);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList"); // jump back into full IActionResult for movielist, not just the view
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var form = movieContext.Responses.Single(x => x.FormId == id);
            return View(form);
        }

        [HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            movieContext.Responses.Remove(fr);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
