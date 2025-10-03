using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_in_C_sharp
{
    internal class Program
    {
        static  void printMyName()
        {
            Console.WriteLine("Ibrahim Alnahdi");
        }
        static void Print(string text)
        { Console.WriteLine(text); }
        static void Print(int num) // overloading
        {
            Console.WriteLine(num);
        }
        static void PrintInfo(string Name, byte Age, string Address = "No Address")
        {
            Console.WriteLine("Name= {0} , Age= {1}, Address= {2}", Name, Age, Address);
        }
        static string GetMyName()
        {
            return "Ibrahim Alnahdi";

        }
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }


        static void Main(string[] args)
        { 
           
           printMyName();
            Print("hello world");
            PrintInfo("ibrahim", 22);
            PrintInfo("ibrahim", 22,"Al-Muklla");
            MyMethod(child3: "khalel", child1: "taher", child2:"esmael"); ;

            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Random r = new Random();
            
            Console.WriteLine(r.Next(10, 20));

        }
    }
}
