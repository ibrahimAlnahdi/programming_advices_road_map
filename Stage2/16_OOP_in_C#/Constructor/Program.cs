using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            Console.WriteLine("Parameterized Constructor Called");

        }
        public clsPerson ()
        {
           this.Age = 0;
            this.Name = "empyt";
            this.Id = -1;
            Console.WriteLine("Parameterless Constructor Called");

        }
        ~clsPerson()
        {
            Console.WriteLine("Destructor Called");
        }
    }
   static class Settings
    {
        public static int DayNumber
        {

            get
            {
                return DateTime.Today.Day;
            }
        }
        public static string DayName
        {
            get { return DateTime.Today.DayOfWeek.ToString(); }
        }
        public static string Path { get; set; }
        static Settings()
        {
            Path = @"C:\Projects";
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person1 = new clsPerson(id: 1, age: 23, name: "ibrahim");
            Console.WriteLine($"Id : {person1.Id} \nName: {person1.Name}\nAge : {person1.Age}");

            clsPerson person2 = new clsPerson();
            Console.WriteLine($"Id : {person2.Id} \nName: {person2.Name}\nAge : {person2.Age}");

            Console.WriteLine(Settings.Path);
            Console.WriteLine(Settings.Path);
            Console.ReadKey();

            // // You cannot create an object here because class is static
            //// Settings Obj1 = new Settings();


            // //
            // // Read the static properties.
            // //
            // Console.WriteLine(Settings.DayNumber);
            // Console.WriteLine(Settings.DayName);

            // //
            // // Change the value of the static bool property.
            // //
            // Settings.Path = @"C:\MyProjects\";
            // Console.WriteLine(Settings.Path);
            // Console.ReadKey();
        }
    }
}
