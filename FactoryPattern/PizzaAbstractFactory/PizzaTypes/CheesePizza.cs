using PizzaFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAbstractFactory.PizzaTypes
{
	public class CheesePizza : Pizza
	{
		PizzaIngredientFactory _ingredientFactory;

		public CheesePizza(PizzaIngredientFactory ingredientFactory)
		{
			_ingredientFactory = ingredientFactory;
		}

		public override void Prepare()
		{
			Console.WriteLine("Preparing " + Name);
			dough = _ingredientFactory.CreateDough();
			sauce = _ingredientFactory.CreateSauce();
		}
	}
}
