using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Lights
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on lights");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off lights");
        }

        public void SetBrightness(int val)
        {
            Console.WriteLine($"Setting brightness to {val}");
        }
    }
}
