using PizzaAbstractFactory.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaAbstractFactory
{
	public interface PizzaIngredientFactory
	{
		Dough CreateDough();
		Sauce CreateSauce();
	}
}
