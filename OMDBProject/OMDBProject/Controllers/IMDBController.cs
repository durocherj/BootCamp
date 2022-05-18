using Microsoft.AspNetCore.Mvc;
using OMDBProject.Models;
using OMDBProject.Models.DataAccessLayer;
using System.Net.Http.Json;

namespace OMDBProject.Controllers
{
    public class IMDBController : Controller
    {
        private readonly IIMDBRepository _iMDBRepository;

        public IMDBController(IIMDBRepository iMDBRepository)
        {
            _iMDBRepository = iMDBRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MovieSearch(MovieSearch movie)
        {
            IMDBResponse movieResponse = await _iMDBRepository.SearchMovieResult(movie.Title);

            return RedirectToAction("MovieSearchResult", movieResponse);
        }

        public async Task<IActionResult> MovieSearch()
        {
            return View();
        }

        public async Task<IActionResult> MovieSearchResult(IMDBResponse movie)
        {
            return View(movie);
        }

        public IActionResult MovieNight()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MovieNightResult(MovieNight movies)
        {
            List<IMDBResponse> movieList = new List<IMDBResponse>();

            movieList.Add(await _iMDBRepository.SearchMovieResult(movies.Movie1));
            movieList.Add(await _iMDBRepository.SearchMovieResult(movies.Movie2));
            movieList.Add(await _iMDBRepository.SearchMovieResult(movies.Movie3));

            return View(movieList);

        }

        

        
    }
}
