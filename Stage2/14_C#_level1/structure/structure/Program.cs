using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    internal class Program
    {
        struct stStudent
        {
            public int Id;
            public string Name;
            public byte Class;
        }
        static void Main(string[] args)
        {
            //A struct object can be created with or without the new operator,
            //same as primitive type variables.
            stStudent Student = new stStudent(); // when you use new keyword -> no compile error (default value) 
            stStudent student2;
            student2.Class = 9;
            student2.Name = "abu-baker";
            student2.Id = 1;

            Console.WriteLine($"name = {student2.Name}, class = {student2.Class}, id : {student2.Id}");
            Console.WriteLine($"name = {Student.Name}, class = {Student.Class}, id : {Student.Id}");
        }
    }
}
