using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiLevelInferitance
{
    public class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public void introduce()
        {
            Console.WriteLine($"Hi, My name is {Name}, and my age is {Age}");
        }
    }

    public class Employee : Person
    {
        public int EmployeeID { get; set; } 
        public float Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"Employee With ID {EmployeeID} and Salary {Salary:C}");
        }
    }

    public class Doctor : Employee
    {
        public string Specialty { get; set; }

        public void Heal()
        {
            Console.WriteLine($"Doctor {Name}, With ID {EmployeeID}, Salary {Salary:C} And Specialty {Specialty}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();

            doctor.Name = "ysleem";
            doctor.Age = 19;
            doctor.Salary = 1500;
            doctor.EmployeeID = 1;
            doctor.Specialty = "Booladalgy";
            doctor.introduce();
            doctor.Work();
            doctor.Heal();
        }
    }
}
