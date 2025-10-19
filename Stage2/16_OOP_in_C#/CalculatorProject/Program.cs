using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class clsCalculator
    {
        private double _Value  = 0;
        private string _lastOperation;
        private double _lastNumber;

        private bool _IsZero(double number)
        {
            return number == 0;
        }
        public void Add (double number )
        {
            _Value += number;
            _lastNumber = number;
            _lastOperation = "Adding";
        }
        public void Subtract( double number)
        {
            _Value -= number;
            _lastNumber = number;
            _lastOperation = "Subtracting";
        }
        public void Multiplay(double number)
        {
            _Value *= number;
            _lastNumber = number;
            _lastOperation = "MultiPlaying";
        }
        public bool Divide(double number)
        {
            _lastOperation = "Dividing";
            _lastNumber = number;
            if (_IsZero(number))
            {
                _Value /= 1;
                return false;
            }
            _Value /= number;
            return true;
            
            
        }
         public void Clear()
        {
            _lastOperation = "Clearing";
            _lastNumber = 0;   
            _Value = 0;
        }
        public void PrintResult()
        {
            Console.WriteLine( $"Result After {_lastOperation} {_lastNumber} is : {_Value}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator Calculator1 = new clsCalculator();
            Calculator1.PrintResult();

            Calculator1.Add(10);
            Calculator1.PrintResult();
            Calculator1.Add(100);
            Calculator1.PrintResult();
            Calculator1.Subtract(20);
            Calculator1.PrintResult();

            Calculator1.Divide(0);
            Calculator1.PrintResult();

            Calculator1.Divide(2);
            Calculator1.PrintResult();

            Calculator1.Multiplay(3);
            Calculator1.PrintResult();
           
            Calculator1.Clear();
            Calculator1.PrintResult();



        }
    }
}
