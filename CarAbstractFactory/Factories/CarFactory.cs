using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory
{
	public abstract class CarFactory
	{
		public Car CreateCar(string carType, int amountOfCars)
		{
			Car Car = null;

			for (int i = 0; i < amountOfCars; i++)
			{
				Car = BuildCar(carType);
				Car.CreateMessage();
			}

			Console.WriteLine("\n" + amountOfCars + " cars have been created");

			return Car;
		}
		public abstract Car BuildCar(string carType);
	}
}
