using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieTimeV3.Data;

namespace MovieTimeV3.Controllers
{
    public class HomeController : Controller
    {
        private IMovieRepository movieRepository;
        public HomeController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        [Route("")]

        public IActionResult Index()
        {
            //moviesModel
            var model = movieRepository.GetMovies();
            return View(model);
        }

    }
}
