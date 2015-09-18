using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShare.Models
{
    public class Tag
    {
        public int TagID { get; set; }
        public int BookID { get; set; }
        public string Name { get; set; }

        public virtual Book Book { get; set; }
    }
}