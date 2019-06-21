using PizzaAbstractFactory;
using PizzaAbstractFactory.IngredientFactories;
using PizzaAbstractFactory.PizzaTypes;
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
			Pizza pizza = null;

			PizzaIngredientFactory nyIngredientFactory = new NYPizzaIngredientFactory();

			if (type == "c")
			{
				pizza = new CheesePizza(nyIngredientFactory);
				pizza.Name = "NY style cheese pizza";
			}
			else if (type == "s")
			{
				pizza = new SalamiPizza(nyIngredientFactory);
				pizza.Name = "NY style salami pizza";
			}

			return pizza;
		}
	}
}
