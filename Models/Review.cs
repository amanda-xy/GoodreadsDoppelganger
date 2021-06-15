using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodreadsDoppelganger.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public int Rating { get; set; }
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        public bool HasSpoilers { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
    }
}
