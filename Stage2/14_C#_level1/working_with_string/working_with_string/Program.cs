using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ibrahim taher bin-kulaib";
            Console.WriteLine(text.Substring(2,5));
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Length);
            Console.WriteLine(text[2]);
            Console.WriteLine(text.Insert(3,"sss"));
            Console.WriteLine(text.Replace("bin-kulaib","alnahdi"));
            Console.WriteLine(text.IndexOf('i'));
            Console.WriteLine(text.LastIndexOf('i'));
            Console.WriteLine(text.Contains('i'));
            Console.WriteLine(text.Contains('x'));

            string S2 = "Ali,Ahmed,Khalid";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Abu-Hadhoud  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());

            //  String Interpolation

            string firstName = "Mohammed";
            string lastName = "Abu-Hadhoud";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);
            Console.WriteLine(@"welcom \nser \tsalem you are ''"); // use @ to ignore escape characters

        }
    }
}
