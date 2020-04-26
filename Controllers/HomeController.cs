using AspWebCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspWebCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };

            List<Movie> movies = new List<Movie>();
            movies.Add(movie);

            return View("index", movies);
        }
    }
}
