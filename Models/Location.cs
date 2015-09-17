using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShare.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Place { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}