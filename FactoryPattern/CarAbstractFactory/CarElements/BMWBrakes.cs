using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory.CarElements
{
	class BMWBrakes : IBrakes
	{
		public string Name => "BMW Brakes";
		public BMWBrakes()
		{
			Console.WriteLine(Name);
		}
	}
}
