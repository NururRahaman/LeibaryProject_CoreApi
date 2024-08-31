using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Libary.CoreApi.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50),Required]
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
