using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class UpdateScientificCalculator : Calculator, BasicCalculatorInterface, ScientificCalculator
    {
        public int fact { get; set; }
        public UpdateScientificCalculator() { }
        public UpdateScientificCalculator(String nm, String power) : base(nm, power)
        {

        }
        public void sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("IThe summation is: " + sum);
            Console.WriteLine();
        }
        public void division(int x, int y)
        {
            int d = x / y;
            Console.WriteLine("The division is : " + d);
            Console.WriteLine();
        }

        public void sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("The subtraction is: " + sub);
            Console.WriteLine();
        }

        public void multiplication(int x, int y)
        {
            int m = x * y;
            Console.WriteLine("The multiplication is: " + m);
            Console.WriteLine();
        }




        public void factorial(int number)
        {

            {

                fact = number;

                for (int i = 1; i <= number; i++)
                {
                    fact = fact * i;
                }
                Console.Write("Factorial of " + number + " is: " + fact);
                Console.WriteLine();
            }
        }

       
        public void XtoY(int x, int y)
        {
            int basetothepower = x ^ y;
            Console.WriteLine("The base power is: " + basetothepower);
            Console.WriteLine();
        }
    }
}
