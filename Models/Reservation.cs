using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShare.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime ReservationDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}