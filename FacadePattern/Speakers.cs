using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Speakers
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on speakers");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off speakers");
        }

        public void SetVolume(int val)
        {
            Console.WriteLine($"Setting volume to {val}");
        }
    }
}
