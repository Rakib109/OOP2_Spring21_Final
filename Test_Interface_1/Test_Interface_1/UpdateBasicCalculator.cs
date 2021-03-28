using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class UpdateBasicCalculator : Calculator, BasicCalculatorInterface
    {
        public UpdateBasicCalculator() { }
        public UpdateBasicCalculator(string nm, string power) : base(nm, power)
        {

        }
        public void sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("The summation is : " + sum);
            Console.WriteLine();
        }

        public void sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("The subtraction is: " + sub);
            Console.WriteLine();
        }


        public void division(int x, int y)
        {
            int d = x / y;
            Console.WriteLine("The division is : " + d);
            Console.WriteLine();
        }

        public void multiplication(int x, int y)
        {
            int m = x * y;
            Console.WriteLine("The multiplication is: " + m);
            Console.WriteLine();
        }

       
       

    }
}
