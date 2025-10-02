using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_date_and_time
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);
            Console.WriteLine(dt2.Year);
            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            DateTime dt = new DateTime(2006, 7, 08, 22, 30, 00, DateTimeKind.Local); // Local Birth Day

            DateTime dtUniversal = dt.ToUniversalTime(); // Convert from local to UTC 

            Console.WriteLine(dt2); // 7 / 8 / 2006 10:30:00 PM
            Console.WriteLine(dtUniversal); // 7 / 8 / 2006 7:30:00 PM

            DateTime Start = DateTime.Now;
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            Console.WriteLine("Hello world");
            DateTime End = DateTime.Now;

            long Duriton = End.Ticks - Start.Ticks;

            Console.WriteLine("how many ticks to run this function: " + Duriton);


            //number of 100-nanosecond intervals that have elapsed
            //since January 1, 0001, at 00:00:00.000 in the Gregorian calendar. 

            DateTime d = new DateTime(2020, 1, 1);
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks
            TimeSpan s = new TimeSpan(10, 5, 3, 30);
            Console.WriteLine(s.Days);
            DateTime newd = d.Add(s);
            Console.WriteLine(newd);
            DateTime date1 = new DateTime(2023, 4, 21);
            DateTime date2 = new DateTime(2023, 6, 25);
            TimeSpan result = date2.Subtract(date1);
            Console.WriteLine($"Subtracion : {result}");
            var str = "6/12/2023";
            DateTime date;
            var isValidDate = DateTime.TryParse(str, out date);
            if (isValidDate)
                Console.WriteLine(date);
            else
                Console.WriteLine("not valid date");
        }
    }
}
