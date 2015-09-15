using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HollyRoommateWebApp.Models
{
    public class Roommates
    {
        public Roommate[] roomMates { get; set; }

        public Roommates ()
        {
            roomMates = new Roommate[5];
        }
    }
}