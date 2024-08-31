using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Libary.CoreApi.Entities
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        [StringLength(50),Required]
        public string PublisherName { get; set;}
        [StringLength(20),Required]
        public string ContectNo { get; set;}
        [StringLength(30),Required ,EmailAddress]
        public string Email { get; set;}
        [StringLength(200)]
        public string Address { get; set;}
        public bool IsActive { get; set;}
        public ICollection<Book> Books { get; set;}
    }
}
