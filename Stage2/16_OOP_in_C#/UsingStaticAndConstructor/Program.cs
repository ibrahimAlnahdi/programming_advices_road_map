using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStaticAndConstructor
{
    public class clsPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public string FullName
        {
            get { return FirstName + " "+ LastName; }
        }
        public clsPerson(int id, string name, string lastName, int age)
        {
            Id = id;
            FirstName = name;
            LastName = lastName;
            Age = age;
        }
        public virtual void Print()
        {
            Console.WriteLine(Id);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
        }
        public static clsPerson Find(int id)
        {
            if (id == 10)
            {
                return new clsPerson(10, "ibrahim", "taher", 23);
            }
            else
                return null;
        }

        public static clsPerson Find(string userName, string password)
        {
            if (userName == "ibrahim" && password == "p1234")
            {
                return new clsPerson(10, "ibrahim", "taher", 23);

            }
            else
                return null;
        }

    }
    public class clsEmployee : clsPerson
    {
        public float salary { get; set; }
        public string DepartmentName { get; set; }

        public void IncreaseSalary(float Amount)
        {
            salary += Amount;
        }
        public clsEmployee(int id, int age, string firstName, string LastName,
            float salary, string departmentName): base (id,firstName,LastName,age)
        {
            this.salary = salary;
            this.DepartmentName = departmentName;
        }
        public override void Print()
        {

            base.Print();
            Console.WriteLine(salary);
            Console.WriteLine(DepartmentName) ;
        }
    }

    internal class Program
    {
        public static void PrintPerson(clsPerson p1)
        {
            if (p1 != null)
            {
                Console.WriteLine($"id : {p1.Id}\nName : {p1.FullName}\nAge: {p1.Age}");
            }
            else
                Console.WriteLine("This object is not found ");
        }
        static void Main(string[] args)
        {
            // clsPerson p1 = new clsPerson(name:"salem",id:1, age:22);

            clsPerson p1 = clsPerson.Find(10);
            PrintPerson(p1);
            clsPerson p2 = clsPerson.Find("karem", password: "p1234");
            PrintPerson(p2);
            
            clsEmployee emp1 = new clsEmployee(1,18,"abobaker", "taher",5000,"hr");
            clsPerson persone1 = new clsPerson(id: 2, name: "salem", lastName: "hassen", age: 20);
            emp1.Print();

            Console.ReadKey();
        }
    }
}
