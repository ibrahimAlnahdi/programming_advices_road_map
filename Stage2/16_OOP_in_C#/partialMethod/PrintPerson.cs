using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialMethod
{
    public partial class Person
    {
        partial void PringAge()
        {
            Console.WriteLine($"Current Age {Age}");

        }
    }
}
