using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class FanOffCommand : ICommand
    {
        Fan _fan;

        public FanOffCommand(Fan Fan)
        {
            _fan = Fan;
        }

        public void Execute()
        {
            _fan.Off();
        }

        public void Undo()
        {
            _fan.On();
        }
    }
}
