using CarAbstractFactory.CarElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory.CarElementsFactories
{
	public interface ICarElementsFactory
	{
		IEngine CreateEngine();
		IBrakes CreateBrakes();
		IWheels CreateWheels();
	}
}
