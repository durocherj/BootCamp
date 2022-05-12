using Microsoft.AspNetCore.Mvc;
using OMDBProject.Models.DataAccessLayer;

namespace OMDBProject.Models
{
    public class IMDBRepository : IIMDBRepository

    {
        public async Task<IMDBResponse> SearchMovieResult(string searchTerm)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://www.omdbapi.com");

            var response = await client.GetFromJsonAsync<IMDBResponse>("?t=" + searchTerm + "&apiKey=aa5bb7ad");

            return response;
        }
    }
}
