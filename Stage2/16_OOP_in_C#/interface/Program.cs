using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IPersone
    { 
         string FirstName { get; set; }
         string LastName { get; set; }

        void Introduce();
        void print();
        string To_String();
    
    
    }
  public abstract class  Person :IPersone
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public abstract void Introduce();

        public void print()
        {
            Console.WriteLine("hello world");
        }

        public string To_String() => "string";

    }
    public class Employee : Person
    {
        public int EmployeeId { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName}, and my employee ID is {EmployeeId}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Mohammed";
            employee.LastName = "Abu-Hadhoud";
            employee.EmployeeId = 123;
            employee.Introduce(); // Output: "Hi, my name is John Doe, and my employee ID is 123."
            employee.print();
            Console.ReadKey();
        }
    }
}
