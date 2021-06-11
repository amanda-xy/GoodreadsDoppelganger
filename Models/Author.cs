using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodreadsDoppelganger.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImageUrl { get; set; }
        public string FullName { get => FirstName + " " + LastName; }
        public virtual List<Book> Books { get; set; }
    }
}
