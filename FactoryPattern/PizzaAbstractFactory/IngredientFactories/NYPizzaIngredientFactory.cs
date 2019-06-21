
using PizzaAbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAbstractFactory.IngredientFactories
{
	public class NYPizzaIngredientFactory : PizzaIngredientFactory
	{
		public Dough CreateDough()
		{
			return new NYDough();
		}

		public Sauce CreateSauce()
		{
			return new NYSauce();
		}
	}
}
