using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoodreadsDoppelganger.Models
{
    public enum Genre { Fantasy, SciFi, Horror, Fiction, Historic, Drama, Romantic, Thriller, Biography }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public string ImageUrl { get; set; }
        [Column(TypeName = "decimal(9,1)")]
        public decimal Rating { get; set; }
        public Genre Genre { get; set; }
        public int? AuthorId { get; set; }
        #nullable enable
        public virtual Author? Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public virtual List<Review> Reviews { get; set; }

        public Book()
        {
            Reviews = new List<Review>();
        }
    }
}
