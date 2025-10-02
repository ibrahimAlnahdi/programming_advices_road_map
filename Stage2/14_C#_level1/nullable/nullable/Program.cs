using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable <bool> n = default; // null 
            Console.WriteLine(n);
            //  Nullable<int> can be assigned any value
            //  from -2147483648 to 2147483647, or a null value.

            Nullable<int> i = null;



            Console.ReadKey();
        }
    }
}
