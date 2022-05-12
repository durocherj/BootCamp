using Microsoft.AspNetCore.Mvc;

namespace OMDBProject.Models.DataAccessLayer
{
    public interface IIMDBRepository
    {
        Task<IMDBResponse> SearchMovieResult(string searchTerm);
    }
}
