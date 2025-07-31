using DapperProject.Services.MovieService;
using Microsoft.AspNetCore.Mvc;


namespace DapperProject.Controllers
{
    public class FilmController : Controller
    {
        private readonly IMovieServices _movieServices;

        public FilmController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        public async Task<IActionResult> Index(int page = 1, string year = "", string sort = "", string genre = "", string search = "")
        {
            ViewData["Title"] = "Film Listesi";
            const int moviesPerPage = 12;
            
            var (movies, totalCount, totalPages) = await _movieServices.GetMoviesWithPaginationAsync(page, moviesPerPage, year, sort, genre, search);

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalCount = totalCount;
            ViewBag.MoviesPerPage = moviesPerPage;
            ViewBag.YearFilter = year;
            ViewBag.SortFilter = sort;
            ViewBag.GenreFilter = genre;
            ViewBag.SearchFilter = search;

            return View(movies);
        }
        public async Task<IActionResult> MovieDetail(int id)
        {
            var movie = await _movieServices.GetMovieDetailById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
    }
} 