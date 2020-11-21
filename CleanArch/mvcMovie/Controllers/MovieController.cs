using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Application.DTOs;
using mvcMovie.ViewModels;
using Domain.Entities.Helpers;
using Application.Interfaces;

namespace Domain.Entities.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public IActionResult Index(string sortOrder, string movieGenre, string searchString, int pageIndex = 1)
        {
            int pageSize = 3;
            int count;
            var movies = movieService.GetMovies(sortOrder, movieGenre, searchString, pageIndex, pageSize, out count);
            var genres = movieService.GetGenres();

            var indexVM = new IndexViewModel()
            {
                Movies = new PaginatedList<MovieDto>(movies, count, pageIndex, pageSize),
                Genres = new SelectList(genres),
                MovieGenre = movieGenre,
                SearchString = searchString,
                SortOrder = sortOrder
            };

            return View(indexVM);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieDto movie)
        {
            if (ModelState.IsValid)
            {
                movieService.CreateMovie(movie);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            var movie = movieService.GetMovie(id);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieDto movie)
        {
            if (ModelState.IsValid)
            {
                movieService.UpdateMovie(movie);

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Details(int id)
        {
            var movie = movieService.GetMovie(id);

            return View(movie);
        }

        public IActionResult Delete(int id)
        {
            var movie = movieService.GetMovie(id);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(int id, bool notUsed)
        {
            movieService.DeleteMovie(id);

            return RedirectToAction("Index");
        }
    }
}