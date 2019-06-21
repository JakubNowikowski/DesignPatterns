using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory.CarElements
{
	class AudiWheels : IWheels
	{
		public string Name => "Audi Wheels";
		public AudiWheels()
		{
			Console.WriteLine(Name);
		}
	}
}
