using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Phone : MusicPlayer, RadioPlayer
    {
        public void ChangeChannel()
        {
            Console.WriteLine("The Channel is Changing....");
        }

        public void Play(bool on)
        {
            Console.WriteLine(" Music is playing.....");
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Setting volume... Now the volume is:" + loudness);
        }

        public void PlayNext()
        {
            Console.WriteLine("Next Music is playing....");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Previous Music is playing .....");
        }

        public void Retune(double frequency)
        {
            Console.WriteLine("Retuning to Frequency....The frequency is:" + frequency);
        }

        
        public void Switch(bool on)
        {
            Console.WriteLine("Switch is Turning  ON...");
        }
    }
}