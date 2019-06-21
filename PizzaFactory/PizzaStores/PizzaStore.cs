using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
	public abstract class PizzaStore
	{
		public Pizza OrderPizza(string type)
		{
			Pizza pizza;

			pizza = CreatePizza(type);

			pizza.Prepare();
			pizza.Bake();
			return pizza;
		}

		public abstract Pizza CreatePizza(string type); //factory method
	}
}
