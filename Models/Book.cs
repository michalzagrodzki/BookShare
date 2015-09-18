using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShare.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public int LocationID { get; set; }
        public int UserID { get; set; }
        public int GenreID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public string Publisher { get; set; }
        public int PublishedDate { get; set; }
        public int PageCount { get; set; }

        public virtual User User { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}