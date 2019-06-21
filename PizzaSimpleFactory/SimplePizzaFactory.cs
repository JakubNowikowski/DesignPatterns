using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
	public class SimplePizzaFactory
	{
		public Pizza CreatePizza(string typeOfPizza)
		{
			if (typeOfPizza == "c")
				return new CheesePizza();
			else if (typeOfPizza == "s")
				return new SalamiPizza();
			else
				return null;
		}

	}
}
