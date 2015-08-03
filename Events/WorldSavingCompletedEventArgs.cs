using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class WorldSavingCompletedEventArgs : EventArgs
    {
        public string Saviour { get; set; }
        public DateTime TimeForNextCatastrophy { get; set; }
        public int HoursItTookToSaveTheWorld { get; set; }
        public string MessageFromSaviour { get; set; }
    }
}
