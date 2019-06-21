using CarAbstractFactory.CarElementsFactories;
using CarAbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory
{
	class AudiFactory : CarFactory
	{
		public override Car BuildCar(string carType)
		{
			Car car = null;
			ICarElementsFactory audiElementsFactory = new AudiElementsFactory();
			if (carType == "c")
			{
				car = new CoupeCar(audiElementsFactory);
				car.Name = "Audi coupe";
			}
			else if (carType == "s")
			{
				car = new SedanCar(audiElementsFactory);
				car.Name = "Audi sedan";
			}

			return car;
		}
	}
}
