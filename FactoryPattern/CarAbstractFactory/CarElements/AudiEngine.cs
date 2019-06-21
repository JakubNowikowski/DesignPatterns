using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAbstractFactory.CarElements
{
	class AudiEngine : IEngine
	{
		public string Name => "Audi Engine";
		public AudiEngine()
		{
			Console.WriteLine(Name);
		}
	}
}