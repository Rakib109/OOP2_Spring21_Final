using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    abstract class Calculator
    {

        public String nm { get; set; }
        public String power { get; set; }

        public Calculator() { }
        public Calculator(String nm, String power)
        {
            this.nm = nm;
            this.power = power;
        }
        public void ShowInfo()
        {
            Console.WriteLine("The calculator name is: " + nm);
            Console.WriteLine("The Power of the calculator is: " + power);
        }
    }
}

