using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAbstractFactory.CarElements;

namespace CarAbstractFactory.CarElementsFactories
{
	class BMWElementsFactory : ICarElementsFactory
	{
		public IBrakes CreateBrakes()
		{
			return new BMWBrakes();
		}

		public IEngine CreateEngine()
		{
			return new BMWEngine();
		}

		public IWheels CreateWheels()
		{
			return new BMWWheels();
		}
	}
}
