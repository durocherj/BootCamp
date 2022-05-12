using Microsoft.AspNetCore.Mvc;
using OMDBProject.Models;
using System.Net.Http.Json;

namespace OMDBProject.Controllers
{
    public class IMDBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> MovieSearch()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MovieSearch(MovieSearch movie)
        {
            return RedirectToAction("MovieSearchResult", await SearchMovieResult(movie.Title));
        }

        public async Task<IActionResult> MovieSearchResult(IMDBResponse movie)
        {
            return View(movie);
        }

        public async Task<IActionResult> MovieNightSearch(IMDBResponse movie1, IMDBResponse movie2, IMDBResponse movie3)
        {
            //Make this into a list
            var response1 = await SearchMovieResult(movie1.Title);
            var response2 = await SearchMovieResult(movie2.Title);
            var response3 = await SearchMovieResult(movie3.Title);
            return RedirectToAction("MovieNightResult", response1, response2, response3);
        }

        public async  Task<IMDBResponse> SearchMovieResult(string searchTerm)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://www.omdbapi.com");

            var response = await client.GetFromJsonAsync<IMDBResponse>("?t=" + searchTerm + "&apiKey=aa5bb7ad");

            return response;
        }


    }
}
