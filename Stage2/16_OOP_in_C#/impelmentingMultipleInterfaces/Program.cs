using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impelmentingMultipleInterfaces
{
    interface IPersone
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        void Introduce();
        void print();
        string To_String();


    }

    public interface ICommunicate
    {
        void CallPhone();
        void SendEmail(string Title, string Body);
        void SendSMS(string Title, string Body);
        void SendFax(string Title, string Body);

    }
    public abstract class Person : IPersone, ICommunicate
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public abstract void Introduce();

        public void print()
        {
            Console.WriteLine("hello world");
        }

        public string To_String() => "string";

        public void CallPhone()
        {
            Console.WriteLine("Calling Phone... :-)");

        }
        public void SendEmail(string Title, string body)
        {
            Console.WriteLine("send email ");
        }
        public void SendFax(string Title, string body)
        {
            Console.WriteLine("send Fax ");
        }
        public void SendSMS(string Title, string body)
        {
            Console.WriteLine("send SMS ");
        }

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
            employee.CallPhone();
            employee.SendSMS("hi", body: "welcom");
            employee.SendFax("hi",  "welcom");
            employee.SendEmail(Title:"hi",  "welcom");

            
            Console.ReadKey();

        }
    }
}
