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

        public async Task<IActionResult> Index()
        {
            //moviesModel
           // var model = await movieRepository.GetMovies();
            var model = await movieRepository.GetMovie();
            return View(model);
        }

        public async Task<IActionResult> Movie()
        {
            //moviesModel
            // var model = await movieRepository.GetMovies();
            var modelMovie = await movieRepository.GetMovie();
            return View(modelMovie);
        }

    }
}
