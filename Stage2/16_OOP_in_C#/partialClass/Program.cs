using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialClass
{
    partial class Employee
    {
        public void method1() => Console.WriteLine("method 1 called");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.method1();
            emp.method2();
        }
    }
}
