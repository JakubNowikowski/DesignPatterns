using PizzaFactory.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
	public class NYPizzaStore : PizzaStore
	{
		public override Pizza CreatePizza(string type)
		{
			if (type == "c")
				return new NYStyleCheesePizza();
			else if (type == "s")
				return new NYStyleSalamiPizza();
			else
				return null;
		}
	}
}
