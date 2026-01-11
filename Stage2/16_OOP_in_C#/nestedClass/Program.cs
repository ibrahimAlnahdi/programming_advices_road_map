using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedClass
{
    public class OuterClass
    {
        public int OuterVariable { get; set; }
        public  OuterClass(int outerVariable)
        {
            this.OuterVariable = outerVariable;
        }
        public void OuterMethod()
        {
            Console.WriteLine("Outer Method Called ...");
        }

        public class InnerClass
        {
            public int InnerVariable { get; set; }  
            public InnerClass(int innerVariable)
            {
                this.InnerVariable = innerVariable;
            }

            public void InnerMethod() => Console.WriteLine("Inner Method called");
            public void AccessOuterVariable (OuterClass outer)
            {
                Console.WriteLine("Outer variable is : "+ outer.OuterVariable);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OuterClass outer = new OuterClass(100);
            outer.OuterMethod();

            OuterClass.InnerClass  inner = new OuterClass.InnerClass(50);
            
            inner.InnerMethod();
            
            inner.AccessOuterVariable(outer);

        }
    }
}
