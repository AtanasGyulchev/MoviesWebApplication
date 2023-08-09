using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; } = "No description";

    }
}
