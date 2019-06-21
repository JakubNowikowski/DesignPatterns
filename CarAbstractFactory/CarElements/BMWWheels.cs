using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory.CarElements
{
	class BMWWheels : IWheels
	{
		public string Name => "BMW Wheels";
		public BMWWheels()
		{
			Console.WriteLine(Name);
		}
	}
}
