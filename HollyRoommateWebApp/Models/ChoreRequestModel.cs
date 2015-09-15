using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HollyRoommateWebApp.Models
{
    public class ChoreRequestModel
    {
        public Roommates roommates  { get; set; }
        public bool[] sendTo { get; set; }
        public string message { get; set; }

        public ChoreRequestModel()
        {
            sendTo = new bool[5];
            for (int i = 0; i < 5; i++)
            {
                sendTo[i] = false;
            }
        }
    }
}