using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(default(int));
            Console.WriteLine(default(float));
            Console.WriteLine(default(char));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(String));

            Console.WriteLine(default(DateTime));   
           
            Console.WriteLine(default(Guid));
            //get default value using default(type)
            int i = default(int); // 0
            float f = default(float);// 0
            decimal d = default(decimal);// 0
            bool b = default(bool);// false
            char c = default(char);// '\0'

            // C# 7.1 onwards
            //get default value using default
            int i2 = default; // 0
            float f2 = default;// 0
            decimal d2 = default;// 0
            bool b2 = default;// false
            char c2 = default;// '\0'

            Console.WriteLine(i);
            Console.WriteLine(i2);

            Console.ReadKey();


        }
    }
}
