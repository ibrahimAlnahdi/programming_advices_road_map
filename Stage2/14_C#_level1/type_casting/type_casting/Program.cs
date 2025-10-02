using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_casting
{
    internal class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            int myInt = 17;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 17
            Console.WriteLine(myDouble);   // Outputs 17

            double dbl = 160.234;
            int myInt2 = (int)dbl;
            bool check = true;
            Console.WriteLine(dbl);
            Console.WriteLine(myInt2);

            Console.WriteLine(Convert.ToInt32(dbl));
            Console.WriteLine(Convert.ToDouble(myInt2));
            Console.WriteLine(Convert.ToString(dbl));
            Console.WriteLine(Convert.ToString(check));

            // Casting Enums 


            Console.WriteLine(WeekDays.Friday);
            int day = (int) WeekDays.Friday;
            Console.WriteLine(day); // 4

            var wd = (WeekDays)2;
            Console.WriteLine(wd);
            Console.WriteLine(wd.GetType());

        }
    }
}
