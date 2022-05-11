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
        public async Task<IActionResult> MovieSearch(SearchMovie movie)
        {
            return await SearchMovieResult(movie.Title);
            
        }

        public async  Task<IActionResult> SearchMovieResult(string searchTerm)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://www.omdbapi.com");

            var response = await client.GetFromJsonAsync<IMDBResponse>("?t=" + searchTerm + "&apiKey=aa5bb7ad");

            return View(response);
        }
    }
}
