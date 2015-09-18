﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShare.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}