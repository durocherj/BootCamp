using System.ComponentModel.DataAnnotations;

namespace WebAPILab.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Year { get; set; }

    }
}
