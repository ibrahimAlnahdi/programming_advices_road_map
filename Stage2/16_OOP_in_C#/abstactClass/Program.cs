using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstactClass
{
    public abstract class Person
    {
        public String Name { get; set; }
        public String Address { get; set; }

        public abstract void introduce();

        public void SayGoodBye()
        {
            Console.WriteLine("Good bye");
        }
    }

    public class Employee: Person
    {
        public int EmpID { get; set; }  

        public override void introduce()
        {
            Console.WriteLine($"Hi, my name is {Name}, my address is  {Address}, and my employee ID is {EmpID}.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           // Person person = new Person();
           // can't create object from abstract class

            Employee emp = new Employee();
            emp.Name = "ibrahim";
            emp.Address = "Mukalla";
            emp.EmpID = 10;
            emp.introduce();
            emp.SayGoodBye(); 

        }
    }
}
