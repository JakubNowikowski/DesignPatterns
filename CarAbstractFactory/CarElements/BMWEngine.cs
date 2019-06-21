using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory.CarElements
{
	class BMWEngine : IEngine
	{
		public string Name => "BMW Engine";

		public BMWEngine()
		{
			Console.WriteLine(Name);
		}
	}
}
