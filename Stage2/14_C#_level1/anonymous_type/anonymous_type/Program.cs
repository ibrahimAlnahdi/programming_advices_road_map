using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new { id = 10, firstName = "ibrahim", lastName = "alnahdi",
             address = new { City = "almuklla ", country = "yemen"}
            };
            Console.WriteLine(student);
            Console.WriteLine("Student info \n_________________");
            Console.WriteLine($"student id: {student.id}" );
            Console.WriteLine($"first name: {student.firstName}" );
            Console.WriteLine($"last name : {student.lastName}" );
            Console.WriteLine($" City     : {student.address.City}" );
            Console.WriteLine($" country  : {student.address.country}" );

            //you dont specify any type here , automatically will be specified
            var student2 = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };

            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student2.Id); //output: 20
            Console.WriteLine(student2.FirstName); //output: Mohammed
            Console.WriteLine(student2.LastName); //output: Abu-Hadhoud

            //You can print like this:
            Console.WriteLine(student);


            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

            // student.Id = 2;//Error: cannot chage value
            // student.FirstName = "Ali";//Error: cannot chage value


            //An anonymous type's property can include another anonymous type.
            var student3 = new
            {
                Id = 20,
                FirstName = "Mohammed",
                LastName = "Abu-Hadhoud",
                Address = new { Id = 1, City = "Amman", Country = "Jordan" }
            };

            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student3.Id);
            Console.WriteLine(student3.FirstName);
            Console.WriteLine(student3.LastName);
                                     
            Console.WriteLine(student3.Address.Id);
            Console.WriteLine(student3.Address.City);
            Console.WriteLine(student3.Address.Country);
            Console.WriteLine(student3.Address);
        }
    }
}
