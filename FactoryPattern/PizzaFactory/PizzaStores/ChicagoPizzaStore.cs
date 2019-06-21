using PizzaFactory.PizzaTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.PizzaStores
{
	public class ChicagoPizzaStore : PizzaStore
	{
		public override Pizza CreatePizza(string type)
		{
			if (type == "c")
				return new ChicagoStyleCheesePizza();
			else if (type == "s")
				return new ChicagoStyleSalamiPizza();
			else
				return null;
		}
	}
}
