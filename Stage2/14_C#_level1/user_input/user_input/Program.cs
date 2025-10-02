using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your UserName ? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"UserName : {userName}");

            /*
             The Console.ReadLine() method returns a string.
            Therefore, you cannot get information from another data type, such as int.

              therefore you should use casting when you read.
            */

            Console.WriteLine("Enter your age?");
            //if you dont convert you will get error, and if you enter string you will get error
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("your age is : "+ age);
        }
    }
}
