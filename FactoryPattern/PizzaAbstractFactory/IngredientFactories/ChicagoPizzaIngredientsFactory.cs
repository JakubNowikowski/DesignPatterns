using PizzaAbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAbstractFactory.IngredientFactories
{
	class ChicagoPizzaIngredientsFactory : PizzaIngredientFactory
	{
		public Dough CreateDough()
		{
			return new ChicagoDough();
		}

		public Sauce CreateSauce()
		{
			return new ChicagoSauce();
		}
	}
}
