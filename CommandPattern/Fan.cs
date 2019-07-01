using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Fan
    {
        public void On()
        {
            Console.WriteLine("Fan on");
        }

        public void Off()
        {
            Console.WriteLine("Fan off");
        }

        public void SetSpead(int value)
        {
            Console.WriteLine($"Set speed to {value}");
        }
    }
}
