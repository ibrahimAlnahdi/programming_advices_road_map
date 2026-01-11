using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialMethod
{
    public partial class Person
    {
        public int Age { get; set; }
        partial void PringAge();

        public void BirthDay()
        {
            Age++;
            PringAge();
        }
    }
    
}
