using System.ComponentModel.DataAnnotations;

namespace BookHive.Model 
{
    public class Book
    {
        public int ID { get; set; } 

        [Required] 
        [StringLength(100)]
        public string? Title { get; set; } = string.Empty;

        [Required]
        [StringLength(100)] 
        public string? Author { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Genre { get; set; } = string.Empty;

        [Range(868,9999)]
        public int PublicationYear { get; set; }
    }
}

