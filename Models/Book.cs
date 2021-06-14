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
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int NumberOfPages { get; set; }
        public string ImageUrl { get; set; }
        [Column(TypeName = "decimal(9,1)")]
        public decimal Rating { get
            {
                if (Reviews.Count == 0)
                    return 0m;

                decimal sum = Reviews.Sum(r => r.Rating);
                decimal rating = sum / Reviews.Count;

                return rating;
            }
        }
        [Required]
        public Genre Genre { get; set; }
        [Required(ErrorMessage ="The field Author is required")]
        public int? AuthorId { get; set; }
        #nullable enable
        public virtual Author? Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public virtual List<Review> Reviews { get; set; } = new List<Review>();

        public Book()
        {
            Reviews = new List<Review>();
        }
    }
}
