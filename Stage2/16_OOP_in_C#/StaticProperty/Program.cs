using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperty
{
    class clsSettings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }
        public static string DayName
        {
            get { return DateTime.Today.DayOfWeek.ToString(); }
        }
        public static string ProjectPath { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(clsSettings.DayName);
            Console.WriteLine(clsSettings.DayNumber);
            clsSettings.ProjectPath = @"C:\Users\Projects\p1";
            Console.WriteLine(clsSettings.ProjectPath);
        }
    }
}
