using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPILab.Data;
using WebAPILab.Models;

namespace WebAPILab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        
        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }

            return await _context.Movies.ToListAsync();
        }

        [HttpGet("{category}")]
        public async Task<ActionResult<List<Movie>>> GetMovieByCategory(string category)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }

            var movieList = await _context.Movies.Where(x => x.Category.ToLower() == category.ToLower()).ToListAsync();

            if (movieList == null)
            {
                return NotFound();
            }

            return movieList;
        }

        [HttpGet("GetRandomMovie")]
        public async Task<ActionResult<Movie>> GetRandomMovie()
        {  
            if (_context.Movies == null)
            {
                return NotFound();
            }

            var rand = new Random();
            int number = rand.Next(1, _context.Movies.Count() + 1);

            var movie = await _context.Movies.Where(x => x.Id == number).FirstOrDefaultAsync();

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpGet("GetRandomCategory/{category}")]
        public async Task<ActionResult<Movie>> GetRandomByCategory(string category)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }
            List<Movie> movieList = await _context.Movies.Where(x => x.Category.ToLower() == category.ToLower()).ToListAsync();
            var random = new Random();
            int randomMovieId = movieList.OrderBy(x => random.Next()).Select(x => x.Id).FirstOrDefault();
            
            Movie movie = movieList.Where(x => x.Id == randomMovieId).FirstOrDefault();
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        [HttpGet("GetAllCategories")]

        public async Task<ActionResult<List<string>>> GetAllCategories()
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }

            List<string> categories = await _context.Movies.Select(x=> x.Category).Distinct().ToListAsync();

            if (categories == null)
            {
                return NotFound();
            }

            return categories;
        }

    }
}
