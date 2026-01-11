using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 25;
            person.BirthDay();
        }
    }
}
