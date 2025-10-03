using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dimensional_Arry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] hello = { 'H', 'E', 'L', 'L' ,'O' };
            int[] numbers2 = {  1, 2, 3, 4,  5, 6, 7, 8, };
            //initializing 2D array
            int[,] numbers = { { 12, 13 }, { 55, 77 } };

            // access first element from the first row
            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);
            foreach (char item in hello)
            {
                Console.WriteLine(item );
            }
            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender)
            {
                if (g == 'm')
                    male++;
                else if (g == 'f')
                    female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);
            // Note that we used System.Linq above.

            Console.WriteLine($"smallest Elemant : {numbers2.Min()}");
            Console.WriteLine($"Largest Elemant : {numbers2.Max()}");
            Console.WriteLine($"Sum of Elemants : {numbers2.Sum()}");
            Console.WriteLine($"Average of Elemants : {numbers2.Average()}");
            Console.WriteLine($"Count of Elemants : {numbers2.Count()}");
        }
    }
}
