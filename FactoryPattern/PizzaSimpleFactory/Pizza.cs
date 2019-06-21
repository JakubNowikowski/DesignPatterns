using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
	public abstract class Pizza
	{
		public string Name{ get; set; }

		public int Time { get; set; }

		public void Prepare()
		{
			Console.WriteLine("Preaparing " + Name);
		}

		public void Bake()
		{
			Console.WriteLine("Baking for " + Time + " minutes");
		}

	}
}
