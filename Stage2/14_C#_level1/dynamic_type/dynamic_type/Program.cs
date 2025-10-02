using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic myDynamicVar = 100;
            Console.WriteLine($"value : {myDynamicVar} , Type : {myDynamicVar.GetType()}");
            myDynamicVar = 'c';
            Console.WriteLine($"value : {myDynamicVar} , Type : {myDynamicVar.GetType()}");
            myDynamicVar = true ;
            Console.WriteLine($"value : {myDynamicVar} , Type : {myDynamicVar.GetType()}");
            myDynamicVar = 3.14f;
            Console.WriteLine($"value : {myDynamicVar} , Type : {myDynamicVar.GetType()}");
            myDynamicVar = DateTime.Now;
            Console.WriteLine($"value : {myDynamicVar} , Type : {myDynamicVar.GetType()}");
             myDynamicVar = "end of program";
            Console.WriteLine($"value : {myDynamicVar} , Type : {myDynamicVar.GetType()}");

        }
    }
}
