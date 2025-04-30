using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public required string Title { get; set; }
        public required string Author { get; set; }

        [Required]
        public int Pages { get; set; }



    }
}
