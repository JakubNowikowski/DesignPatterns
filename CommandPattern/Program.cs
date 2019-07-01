using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();
            Fan fan = new Fan();

            FanOnCommand fanOn = new FanOnCommand(fan);
            FanOffCommand fanOff = new FanOffCommand(fan);

            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            remoteControl.SetCommand(0, fanOn, fanOff);
            remoteControl.SetCommand(1, lightOn, lightOff);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            Console.WriteLine("**Undo**");
            remoteControl.UndoButtonWasPushed();
            remoteControl.OffButtonWasPushed(1);

            Console.WriteLine(remoteControl);

            Console.ReadKey();
        }
    }
}
