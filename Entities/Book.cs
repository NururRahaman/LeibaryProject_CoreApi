using System.ComponentModel.DataAnnotations;

namespace Libary.CoreApi.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [StringLength(50),Required]
        public string BookName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public string Descrition { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Edition { get; set; }
        [StringLength(50)]
        public string ISBN { get; set; }
        public int NumberOfPage { get; set; }
        [StringLength(50)]
        public string Language { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }

    }
}
