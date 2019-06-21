using CarAbstractFactory.CarElementsFactories;
using CarAbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory
{
	public class BMWFactory : CarFactory
	{
		public override Car BuildCar(string carType)
		{
			Car car = null;
			ICarElementsFactory bmwElementsFactory = new BMWElementsFactory();
			if (carType == "c")
			{
				car = new CoupeCar(bmwElementsFactory);
				car.Name = "BMW coupe";
			}
			else if (carType == "s")
			{
				car = new SedanCar(bmwElementsFactory);
				car.Name = "BMW sedan";
			}

			return car;
		}
	}
}
