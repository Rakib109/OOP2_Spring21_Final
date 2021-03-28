using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Ipod Player... : ");
            Ipod ip1 = new Ipod();

            ip1.Switch(true);
            ip1.Play(true);
            ip1.PlayNext();
            ip1.PlayPrevious();
            ip1.SetVolume(15);

            Console.WriteLine();

            Console.WriteLine("This is Phone Player.... : ");
            Phone ph1 = new Phone();

            ph1.Switch(true);
            ph1.Retune(88.8);
            ph1.SetVolume(15);
            ph1.ChangeChannel();

            Console.WriteLine();
        }
    }
}
