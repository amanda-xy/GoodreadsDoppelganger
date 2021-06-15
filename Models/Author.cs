using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodreadsDoppelganger.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Biography { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public string ImageUrl { get; set; }
        public string FullName { get => FirstName + " " + LastName; }
        public virtual List<Book> Books { get; set; } = new List<Book>();
        public decimal AverageRating { get 
            { 
                if (Books.Count == 0)
                    return 0;

                var rating = Books.Sum(b => b.Rating);
                var average = rating / Books.Count;
                return average;
            } }
    }
}
