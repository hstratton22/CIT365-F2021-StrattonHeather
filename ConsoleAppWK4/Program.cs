using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWK4
{
    class Program
    {
        private static Globals _globals;
        private const string JsonPeopleFile = @"Data\PeopleList.json"; //@"Data\PeopleList.json";
        static void Main(string[] args)
        {
            _globals = new Globals();
            ReadFromJsonFile();
            NavigationMenu();
        }
        private static void NavigationMenu()
        {
            Console.WriteLine("================================");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press (A) to add a person.");
            Console.WriteLine("Pres (L) to list all people.");
            Console.WriteLine("Press (Q) to quit.");
            Console.WriteLine("================================"); ;
            var response = Console.ReadLine();
            switch (response)
            {
                case "A":
                    AddPerson();
                    break;
                case "L":
                    ListPeople();
                    break;
                case "Q":
                    QuitApp();
                    break;
                default:
                    NavigationMenu();
                    break;
            }

        }
        private static void QuitApp()
        {
            System.Environment.Exit(0);
        }

        private static void AddPerson()
        {
            var person = new Person();
            Console.Write("What is your first name? ");

            person.FirstName = Console.ReadLine();
            Console.Write($@"Hello {person.FirstName}. What is your last name? ");
            person.LastName = Console.ReadLine();
            AddPersonToList(person);
            NavigationMenu();



        }
        private static void AddPersonToList(Person person)
        {
            _globals.People.Add(person);
            SaveToJsonFile();

        }
        private static void ListPeople()
        { foreach (Person person in _globals.People)
            {
                Console.WriteLine($"- {person.FirstName} {person.LastName}");

            }
            NavigationMenu();
        }
        private static void SaveToJsonFile()
        {
            if (File.Exists(JsonPeopleFile))
            {
                try
                { var jsonData = JsonConvert.SerializeObject(_globals.People, Formatting.Indented);
                    File.WriteAllText(JsonPeopleFile, jsonData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine("Error: Could not find JSON File.");
            }
            NavigationMenu();
        }
   
    private static void ReadFromJsonFile()
    {
        if (File.Exists(JsonPeopleFile))
        {
            try
            {
                var jsonData = File.ReadAllText(JsonPeopleFile);
                 if (jsonData.Length > 0)
                {
                        _globals.People = JsonConvert.DeserializeObject<List<Person>>(jsonData);
                }
            }
                catch (Exception ex)
                { Console.WriteLine(ex);
                }
        }
        else
            {
                Console.WriteLine("Error: Could not find JSON file.");
            }
    }
}
}
