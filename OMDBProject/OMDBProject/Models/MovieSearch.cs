using System.ComponentModel.DataAnnotations;

namespace OMDBProject.Models
{
    public class MovieSearch
    {
        [Required]
        public string Title { get; set; }
    }
}
