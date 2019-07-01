using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light on");
        }

        public void Off()
        {
            Console.WriteLine("Light off");
        }
    }
}
