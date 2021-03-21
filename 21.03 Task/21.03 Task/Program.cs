using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Account ss = new SuperSavings("salmir", "004", 1000f);
            
            ss.ShowInfo();

            Account overdraft = new Overdraft("kaif", "005", 1000f, 5000);
            overdraft.Transfer(ss, 1000);
            overdraft.ShowInfo();

           

        }
    }
}