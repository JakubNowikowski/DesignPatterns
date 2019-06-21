using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAbstractFactory.CarElementsFactories;

namespace CarAbstractFactory.Cars
{
	public class SedanCar:Car
	{
		ICarElementsFactory _carElementsFactory;

		public SedanCar(ICarElementsFactory carElementsFactory)
		{
			_carElementsFactory = carElementsFactory;
		}

		public override void Prepare()
		{
			Console.WriteLine("Preparing " + Name + ":");
			_carElementsFactory.CreateEngine();
			_carElementsFactory.CreateBrakes();
			_carElementsFactory.CreateWheels();
		}
	}
}
