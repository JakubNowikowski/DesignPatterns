using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CinemaFacade
    {
        Lights lights = new Lights();
        Speakers speakers = new Speakers();
        Projector projector = new Projector();

        public void WatchMovie(string name)
        {
            Console.WriteLine("Preaparing all devices...\n");

            lights.TurnOn();
            lights.SetBrightness(10);

            Console.WriteLine();

            speakers.TurnOn();
            speakers.SetVolume(40);

            Console.WriteLine();

            projector.TurnOn();

            Console.WriteLine($"\n*** Start playing: {name} ***");
        }

        public void EndMovie()
        {
            Console.WriteLine("\nTurning off all devices...\n");

            lights.TurnOff();

            Console.WriteLine();

            speakers.TurnOff();

            Console.WriteLine();

            projector.TurnOff();

            Console.WriteLine($"\nSystem turned off");
        }

    }
}
