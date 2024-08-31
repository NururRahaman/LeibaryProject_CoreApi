using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libary.CoreApi.Entities
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [StringLength(30),Required]
        public string AuthorName { get; set; }
        [Column (TypeName ="date"),DataType(DataType.Date)]
        public DateTime DoB { get; set; }
        [StringLength(20), Required]
        public string ContectNo { get; set; }
        [StringLength(30), Required, EmailAddress]
        public string Email { get; set; }
        [StringLength(200)]
        public string Address { get; set; }

        public string AuthorInfo { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
