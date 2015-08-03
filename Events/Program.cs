using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superman = new SuperHero();

            superman.WorldSavedCompleted += superman_WorldSavedCompleted;
            superman.WorldSaved += hero_WorldSaved;
            
            superman.SaveTheWorld("Ronald", DateTime.Now.AddDays(10));
        }

        static void superman_WorldSavedCompleted(object sender, WorldSavingCompletedEventArgs e)
        {
            Console.WriteLine(string.Format( "{0} ,has Finished saving the world :)!", e.Saviour));
        }

        static void hero_WorldSaved(object sender, WorldSavedEventArgs e)
        {
            StringBuilder superHeroMessageBuilder = new StringBuilder();
            superHeroMessageBuilder.Append("Superhero reporting progress! Name: ")
            .Append(e.SaviourName).Append(", has been working for ").Append(e.WorkHasBeenOngoingHours)
            .Append(" hours, ").Append(" date of next occasion: ").Append(e.DateOfNextCatastrophy);
            Console.WriteLine(superHeroMessageBuilder.ToString());
        }
    }
}
