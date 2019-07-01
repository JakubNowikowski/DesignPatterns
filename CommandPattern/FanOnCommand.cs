using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class FanOnCommand : ICommand
    {
        Fan _fan;

        public FanOnCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.On();
            _fan.SetSpead(11);
        }

        public void Undo()
        {
            _fan.Off();
        }
    }
}
