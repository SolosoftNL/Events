using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events
{

    public class SuperHero
    {
        public event MyDelegates.WorldSavedHandler WorldSaved;
        public event EventHandler<WorldSavingCompletedEventArgs> WorldSavedCompleted;

        public void SaveTheWorld(string saviourName, DateTime dateForNextCatastrophy)
        {
            int hoursToSaveTheWorld = 4;

            for (int i = 0; i < hoursToSaveTheWorld; i++)
            {
                OnWorldSaved(i + 1, saviourName, dateForNextCatastrophy);
                Thread.Sleep(2000);
                OnWorldSavedCompleted(2, "", saviourName, dateForNextCatastrophy);
            }
        }

        private void OnWorldSaved(int hoursPassed, string saviourName, DateTime dateForNextCatastrophy)
        {
            if (null != WorldSaved)
            {
                WorldSavedEventArgs e = new WorldSavedEventArgs()
                {
                    DateOfNextCatastrophy = dateForNextCatastrophy,
                    SaviourName = saviourName,
                    WorkHasBeenOngoingHours = hoursPassed
                };
                WorldSaved(this, e);
            }
        }

        private void OnWorldSavedCompleted(int totalHoursWorked, string message, string saviour, DateTime timeOfNextCatastrophy)
        {
            if (WorldSavedCompleted != null)
            {
                WorldSavingCompletedEventArgs e = new WorldSavingCompletedEventArgs()
                {
                    Saviour = saviour,
                    MessageFromSaviour = message,
                    HoursItTookToSaveTheWorld = totalHoursWorked,
                    TimeForNextCatastrophy = timeOfNextCatastrophy
                };
                WorldSavedCompleted(this, e);
            }
        }
    }
}
