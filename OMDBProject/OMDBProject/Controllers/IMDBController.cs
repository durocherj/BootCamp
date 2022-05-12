using Microsoft.AspNetCore.Mvc;
using OMDBProject.Models;
using System.Net.Http.Json;

namespace OMDBProject.Controllers
{
    public class IMDBController : Controller
    {
        private readonly IIMDRepository iMDBRepository;
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

        
    }
}
