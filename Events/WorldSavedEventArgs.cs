using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    public class WorldSavedEventArgs : EventArgs
    {
        public string SaviourName { get; set; }
        public DateTime DateOfNextCatastrophy { get; set; }
        public int WorkHasBeenOngoingHours { get; set; } 
    }
}
