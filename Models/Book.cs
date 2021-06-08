using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodreadsDoppelganger.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public string ImageUrl { get; set; }
        public decimal Rating { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
    }
}
