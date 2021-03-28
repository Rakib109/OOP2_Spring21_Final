using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            UpdateBasicCalculator c = new UpdateBasicCalculator("Abacus", "100");
            c.ShowInfo();
            c.division(15, 5);
            c.multiplication(10, 10);
            c.sub(18, 13);
            c.sum(1, 100);

            UpdateScientificCalculator s = new UpdateScientificCalculator("Casio", " fx-991EX"); ;
            s.ShowInfo();
            s.factorial(5);
            s.XtoY(2, 8);
            s.sum(20,00);
            s.sub(23,12);
            s.multiplication(5, 10);
            s.division(10,10);

        }
    }
}

