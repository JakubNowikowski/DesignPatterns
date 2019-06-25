using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Projector
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on projector");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off projector");
        }
    }
}
