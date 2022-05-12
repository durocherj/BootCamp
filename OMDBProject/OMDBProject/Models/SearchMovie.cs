using System.ComponentModel.DataAnnotations;

namespace OMDBProject.Models
{
    public class SearchMovie
    {
        [Required]
        public string Title { get; set; }
    }
}
