using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAbstractFactory.Cars;

namespace CarAbstractFactory
{
	public abstract class Car
	{
		public string Name { get; set; }

		public void CreateMessage()
		{
			Console.WriteLine(Name + " was created\n");
		}

		public abstract void Prepare();
	}
}
