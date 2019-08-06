using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook_Console
{
    class Program
    {
        public static List<Person> People = new List<Person>();
        static void Main(string[] args)
        {
            string command = "";
            while(command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();
                switch(command)
                {
                    case "add":
                        AddPerson();
                        break;
                    case "remove":
                        RemovePerson();
                        break;
                    case "list":
                        ListPeople();
                        break;

                }
            }
        }
        private static void AddPerson()
        {
            Person person = new Person();

            Console.WriteLine("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Address 1: ");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();
            Console.WriteLine("Enter Addres 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            person.Addresses = addresses;

            People.Add(person);
        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address 1: " + person.Addresses[0]);
            Console.WriteLine("Address 2: " + person.Addresses[1]);
            Console.WriteLine("------------------------------------------");
        }

        private static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;

            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintPerson(person);

            }
            Console.WriteLine("\nPress an key to continue.");
            Console.ReadKey();
        }

        private static void RemovePerson()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintPerson(person);
            if(Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }

        }
    }
}
