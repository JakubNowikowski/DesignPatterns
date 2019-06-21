using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAbstractFactory.CarElementsFactories;

namespace CarAbstractFactory.Cars
{
	public class CoupeCar : Car
	{
		ICarElementsFactory _elementsFactory;

		public CoupeCar(ICarElementsFactory elementsFactory)
		{
			_elementsFactory = elementsFactory;
			Prepare();
		}

		public override void Prepare()
		{
			Console.WriteLine("Preparing " + Name + ":");
			_elementsFactory.CreateEngine();
			_elementsFactory.CreateBrakes();
			_elementsFactory.CreateWheels();
		}
	}
}
