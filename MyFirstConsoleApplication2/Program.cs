using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// by Heather Stratton
/// </summary>

namespace MyFirstConsoleApplication2
{
    class Program
    {
        //static 
        static void Main()
        {
            //get Person
            getUserNameAndLocation();

            //countdown
            var date = DateTime.Now;
            ChristmasCountdown(date);

            //glazer app
            //
            //getGlazer();
            GlazerApp.RunExample();

            //prompt for exit
            PromptForExit();


        }/// <summary>
        /// create new person from user input from prompts for name and location
        /// </summary>
        private static void getUserNameAndLocation()
        {
            var person = new Person();
            Console.WriteLine("What is your name? ");
            person.name =Console.ReadLine();
            Console.WriteLine($"Hi {person.name}! Where are you from?");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue.");
            Console.ReadKey(true);
        }/// <summary>
        /// display current date and countdown until Christmas
        /// </summary>
        /// <param name="date"></param>
        private static void ChristmasCountdown(DateTime date)
        {
            //var date = DateTime.Now;
            Console.WriteLine($"Today's date is: {date:d}");
            DateTime end = new DateTime(2021, 12, 25);//date:year;
            TimeSpan difference = end - date;
            //var daysToChristmas = //calculate days until Christmas, 
            Console.WriteLine($"There are {difference.Days} days until Christmas!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);// hides input


        }
        /// <summary>
        /// prompt user for exit by pressing a key
        /// </summary>
        private static void PromptForExit()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(true);//ReadLine()
        }
    }
}
