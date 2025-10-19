using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class clsPerson
    { 
       
        public int Id { set; get; }
        public string FirstName;
        private string MidName;
        protected string LastName;
        public static int Counter = 0;
        public string Address;
        private int _ID;
        
        public int ID
        {
             // read only property
            get
            {
                return _ID;
            }
            
        }
       

        public static int  Fun2()
        {
            return Counter;
        }
        public string Fun1()
        {
            return FirstName;
        }
        public string FullName()
        {
            return FirstName + " " + MidName + " " + LastName;
        }
    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson();
            
            clsPerson.Counter++;
            clsPerson Person2 = new clsPerson();
            clsPerson.Counter++;
            Person1.FirstName = "ibrahim";
            
            Console.WriteLine("Accessing to object 1");
            Console.WriteLine(Person1.FullName());
            Console.WriteLine(clsPerson.Counter);
            Person2.FirstName = "Salem";
            Console.WriteLine("Accessing to object 2");
            Console.WriteLine(Person2.FullName());

            


        }
    }
}
