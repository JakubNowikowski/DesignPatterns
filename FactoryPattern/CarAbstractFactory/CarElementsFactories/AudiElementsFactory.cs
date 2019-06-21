using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAbstractFactory.CarElements;

namespace CarAbstractFactory.CarElementsFactories
{
	class AudiElementsFactory : ICarElementsFactory
	{
		public IBrakes CreateBrakes()
		{
			return new AudiBrakes();
		}

		public IEngine CreateEngine()
		{
			return new AudiEngine();
		}

		public IWheels CreateWheels()
		{
			return new AudiWheels();
		}
	}
}
