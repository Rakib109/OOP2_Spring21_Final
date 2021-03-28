using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    class Ipod : MusicPlayer
    {
        public void Play(bool on)
        {
            Console.WriteLine("Music is Playing....");
        }

        public void PlayNext()
        {
            Console.WriteLine("Next Music is Playing.... ");
        }

        public void PlayPrevious()
        {
            Console.WriteLine("Previous Music is Playing.... ");
        }

        public void SetVolume(int loudness)
        {
            Console.WriteLine("Setting volume...The volume is: " + loudness);
        }

        public void Switch(bool on)
        {
            Console.WriteLine("Switch is Turning  ON....");
        }
    }
}