using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedClass
{
    sealed class clsA 
    {

    }

    class clsB //: clsA 
    {


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsA clsA = new clsA();
            clsB clsB = new clsB();
        }
    }
}
