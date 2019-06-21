using PizzaAbstractFactory.Ingredients;
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

		public Dough dough;

		public Sauce sauce;

		public abstract void Prepare();

		public void Bake()
		{
			Console.WriteLine("Baking " + Name);
		}
	}
}
