using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodHiding_shadowing_
{
   public class BaceClass
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual void MyMethod()
        {
            Console.WriteLine("Bace Class Im ");
        }
        public virtual void   MeOtherMethod()
        {
            Console.WriteLine("Base Class impelmention another method");
        }
    }
    public class DerivedClass : BaceClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("Derived Class impelmentaion");
        }

        public new  void MeOtherMethod()
        {

            Console.WriteLine("Derived Class impelmentatoin Other Method ");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            BaceClass BaseObject = new BaceClass(); 
            DerivedClass DerivedObject = new DerivedClass();
            

            BaseObject.MyMethod();
            BaseObject.MeOtherMethod();

            DerivedObject.MyMethod();
            DerivedObject.MeOtherMethod();

            //BaseObject = new DerivedClass(); // up casting 
            BaceClass myDerivedObjAsBase = DerivedObject;

            Console.WriteLine("\nAfter Castring:\n");
            myDerivedObjAsBase.MyMethod(); // Output: "Derived class implementation using override"
            myDerivedObjAsBase.MeOtherMethod(); // Output: "Base class implementation of MyOtherMethod"


            // differance between new and override key words is that 

            // override when we do up casting all function will perform from base class
            // but new will still implemnt function from drived class 

        }
    }
}
