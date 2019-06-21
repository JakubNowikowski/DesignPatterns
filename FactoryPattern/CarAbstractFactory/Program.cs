using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			CarFactory factory = null;
			string input;
			string carType;
			int amountOfCars;

			Console.WriteLine("What car brand do you want? (a - Audi/b - BMW)");

			input = Console.ReadLine();

			factory = SetBrandFactory(factory, input);

			Console.WriteLine("What kind of car? (c - coupe/ s - sedan)");

			carType = Console.ReadLine();

			Console.WriteLine("How many cars?");

			amountOfCars = Convert.ToInt32(Console.ReadLine());

			factory.CreateCar(carType, amountOfCars);

			Console.ReadKey();
		}

		private static CarFactory SetBrandFactory(CarFactory factory, string kind)
		{
			if (kind == "a")
				factory = new AudiFactory();
			else if (kind == "b")
				factory = new BMWFactory();
			return factory;
		}
	}
}

