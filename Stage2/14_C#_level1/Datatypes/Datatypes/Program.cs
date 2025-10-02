using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Numbers datatypes 
            byte b = 200;
            sbyte sb = 127;
            short sh = 32000; // int16
            ushort ush = 44000;
            int in1 = 2000000000; // int 32 
            uint in2 = 4000000000;
            long l = 0l; // int64 
            ulong ul = 100ul;

            Console.WriteLine("byte  min: {0} , max: {1} ", Byte.MinValue, Byte.MaxValue);
            Console.WriteLine("Sbyte  min: {0} , max: {1} ", SByte.MinValue, SByte.MaxValue);
            Console.WriteLine("short  min: {0} , max: {1} ", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("ushort min: {0} , max: {1} ", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine("int  min: {0} , max: {1} ", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("UInt  min: {0} , max: {1} ", UInt32.MinValue, UInt32.MaxValue);
            Console.WriteLine("Long  min: {0} , max: {1} ", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("Ulong  min: {0} , max: {1} ", UInt64.MinValue, UInt64.MaxValue );

            float f = 3.14F;
            
            double d = 9.134d;
            decimal c = 1000000000000m;
            Console.WriteLine("float  min: {0} , max: {1} ", Single.MinValue, float.MaxValue);
            Console.WriteLine("double  min: {0} , max: {1} ", double.MinValue, Double.MaxValue);
            Console.WriteLine("decimal  min: {0} , max: {1} ", decimal.MinValue, Decimal.MaxValue);
            Console.WriteLine("decimal  min: {0} , max: {1} ", decimal.MinValue, Decimal.MaxValue);
            float n = 1e3f;
            Console.WriteLine($"n = {n}");

            // hex   & binary 
            int hex = 0x5a;
            int binary = 0b1101010;

            Console.WriteLine($"hex = {hex}");
            Console.WriteLine($"binary = {binary}");


        }
    }
}
