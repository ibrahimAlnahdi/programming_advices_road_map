using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedMethod
{
    public abstract class Person
    {
        public virtual void Greek()
        {
            Console.WriteLine("hello i am a person ");
        }
    }
    public class Employee : Person
    {
        public  sealed override void Greek()
        {
            Console.WriteLine("Hello I am  an Employee");
        }
    }

    public class Manager : Employee
    {
        // compiler time error can not override sealed method 
        //public override void Greek()
        //{
        //    Console.WriteLine("I am a Manager");
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Employee employee = new Employee();
            employee.Greek();
            Manager manager = new Manager();
            manager.Greek();
        }
    }
}
