using PizzaAbstractFactory;
using PizzaAbstractFactory.IngredientFactories;
using PizzaAbstractFactory.PizzaTypes;

namespace PizzaFactory.PizzaStores
{
	public class ChicagoPizzaStore : PizzaStore
	{
		PizzaIngredientFactory chicagoIngredientFactory = new ChicagoPizzaIngredientsFactory();
		public override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;
			if (type == "c")
			{
				pizza = new CheesePizza(chicagoIngredientFactory);
				pizza.Name = "Chicago style cheese pizza";
			}
			else if (type == "s")
			{
				pizza= new SalamiPizza(chicagoIngredientFactory);
				pizza.Name = "Chicago style cheese pizza";
			}

			return pizza;
		}
	}
}
