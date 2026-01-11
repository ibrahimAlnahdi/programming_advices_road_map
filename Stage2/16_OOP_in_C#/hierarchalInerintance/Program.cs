using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchalInerintance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {Name} and I'm {Age} years old.");
        }
    }


    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public decimal Salary { get; set; }


        public void Work()
        {
            Console.WriteLine($"Employee with ID {EmployeeId} and salary {Salary:C} is working.");
        }
    }

    public class User : Person
    {
        public string UserName { get; set; }    
        public string Password { get; set; }
        public int Permissions { get; set; }    

        public void Info()
        {
            Console.WriteLine($"User Name : {UserName} Password {Password}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();
            emp.Name = "hosien";
            emp.Age = 28;
            emp.Salary = 2800;
            emp.EmployeeId = 2;
            Console.WriteLine("Employee");
            emp.Work();

            User user = new User();
            user.Name = "ibrhim";
            user.Age = 28;
            user.UserName = "ibrahim1234";
            user.Password = "1234";
            user.Permissions = -1;

            Console.WriteLine("\n\nUser: ");
            user.Info();

        }
    }
}
